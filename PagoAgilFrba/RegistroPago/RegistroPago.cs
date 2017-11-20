using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.AbmFactura;

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPago : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private List<int> numFactList = new List<int>();

        public RegistroPago()
        {
            InitializeComponent();
            utils.llenar(empresaFilterComboBox, Utils.GetEmpresas());
            utils.llenar(formaPagoComboBox, Utils.GetFormasDePago());


        }


        public void searchBtnL_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridViewFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private void fillDataGridViewFacturas()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.FacturaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@estado", "Sin Pago");

                if (string.IsNullOrWhiteSpace(numFactFilterTextBoxL.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirAValor(numFactFilterTextBoxL));

                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex + 1);

                if (string.IsNullOrWhiteSpace(idClienteTextBox.Text)) sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", utils.convertirAValor(idClienteTextBox));

                DataTable dtbl = new DataTable();

                sqlDa.Fill(dtbl);
                facturasDataGridL.DataSource = dtbl;

                sqlCon.Close();
            }
        }

        private int cobrar()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.PagoCreate", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    utils.validarYAgregarParam(sqlCmd, "@idCliente", idClienteTextBox);

                    utils.validarImporte(sqlCmd, "@importe", importeCobroTextBox);

                    sucursalTextBox.Text = 1.ToString();//TODO sucursal harcodeada. el idSucursal sale del operador -> Usuario logueado
                    utils.validarYAgregarParam(sqlCmd, "@idSucursal", sucursalTextBox);
                    sqlCmd.Parameters.AddWithValue("@fechaCobro", DateTime.Now);
                    if (string.IsNullOrWhiteSpace(formaPagoComboBox.Text)) throw new Exception("Seleccione una forma de pago");
                    sqlCmd.Parameters.AddWithValue("@idFormaDePago", formaPagoComboBox.SelectedIndex + 1);

                    int idPago = -1;
                    var returnParameter = sqlCmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    sqlCmd.ExecuteNonQuery();
                    idPago = Convert.ToInt32(returnParameter.Value);

                    MessageBox.Show("Se registró el pago " + idPago.ToString() + " correctamente");
                    sqlCon.Close();
                    return idPago;
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 empresas con el mismo cuit", "Error Message");
                    else if (sqlException.Number == 8114) MessageBox.Show("Todos los campos son obligatorios", "Error Message");
                    else MessageBox.Show(ex.Message, "Mensaje de Error");

                }
                else
                {
                    MessageBox.Show(ex.Message, "Mensaje de Error");
                }
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return -1;
        }


        private void RegistroPago_Load_1(object sender, EventArgs e)
        {

        }

        private void cobrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idPago = cobrar();
                if (idPago == -1) throw new Exception("No se pudo registrar el pago");
                //TODO asignar el idPago a todas las facturas que estaban en la tabla al momento de cobrar

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private void seleccionarClienteBtn_Click(object sender, EventArgs e)
        {
            BuscarCliente busquedaDeCliente = new BuscarCliente();
            busquedaDeCliente.ShowDialog();

            if (!string.IsNullOrWhiteSpace(busquedaDeCliente.clienteTextBox.Text) & !string.IsNullOrWhiteSpace(busquedaDeCliente.idClienteTextBox.Text))
            {
                idClienteTextBox.Text = busquedaDeCliente.idClienteTextBox.Text;
                clienteTextBox.Text = busquedaDeCliente.clienteTextBox.Text;
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarFiltrosBtn_Click(sender, e);
            limpiarCobroBtn_Click(sender, e);

            fechaCobroDT.Value = Convert.ToDateTime(DateTime.Now.Date);

            facturasDataGridL.DataSource = new DataTable();
        }

        private void limpiarFiltrosBtn_Click(object sender, EventArgs e)
        {
            empresaFilterComboBox.Text = numFactFilterTextBoxL.Text = clienteTextBox.Text = idClienteTextBox.Text = "";
        }

        private void limpiarCobroBtn_Click(object sender, EventArgs e)
        {
            sucursalTextBox.Text = importeCobroTextBox.Text = formaPagoComboBox.Text = clienteTextBox.Text = "";
        }

        private void agregarABtn_Click(object sender, EventArgs e)
        {
            //TODO al apretar COBRAR limpiar la tabla temporal y facturasACobrarDataGrid
            try
            {
                if (facturasDataGridL.CurrentRow == null) throw new Exception("Seleccione una factura sin pago");
                facturasACobrarDataGrid.ColumnHeadersVisible = true;
                var numFact = facturasDataGridL.CurrentRow.Cells["Num Factura"].Value;

                if (!numFactList.Contains(Convert.ToInt32(numFact)))
                {
                    facturasACobrarDataGrid.Rows.Add(new object[] {numFact,
                                    facturasDataGridL.CurrentRow.Cells["Empresa"].Value,
                                    facturasDataGridL.CurrentRow.Cells["Total"].Value,
                                    facturasDataGridL.CurrentRow.Cells["Fecha Alta"].Value,
                                    facturasDataGridL.CurrentRow.Cells["Fecha Venc"].Value
                                    });
                
                    numFactList.Add(Convert.ToInt32(numFact));

                    //importeCobroTextBox.Text = utils.calcularColumna("total", dtbl); //TODO calcular al agregar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (facturasACobrarDataGrid.CurrentRow == null) throw new Exception("Seleccione una factura a pagar");

            var numFact = facturasACobrarDataGrid.CurrentRow.Cells[0].Value;
            numFactList.Remove(numFactList.IndexOf(Convert.ToInt32(numFact)));

            facturasACobrarDataGrid.Rows.Remove(facturasACobrarDataGrid.CurrentRow);
            
            if(!numFactList.Any()) facturasACobrarDataGrid.ColumnHeadersVisible = false;
        }

    }
}
