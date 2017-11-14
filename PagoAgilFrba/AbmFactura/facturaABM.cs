using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PagoAgilFrba.AbmFactura
{
    public partial class facturaABM : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();
        private RegistroPago.RegistroPago registroDePago = new RegistroPago.RegistroPago();

        public facturaABM()
        {
            InitializeComponent();
            llenarCombos(); 

        }

        public void llenarCombos() 
        {
            List<KeyValuePair<int, string>> empresas = Utils.GetEmpresas();
            List<KeyValuePair<int, string>> clientes = Utils.GetClientes();
            utils.llenar(empresaComboBox, empresas);
            utils.llenar(empresaFilterComboBox, empresas);

            utils.llenar(clienteComboBox, clientes);
            utils.llenar(clienteFilterComboBox, clientes);   

        }

        private void facturaABM_Load_1(object sender, EventArgs e)
        {

        }

        private void guardarFactButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (guardarFactButton.Text == "Guardar Factura")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");

                        sqlCmd.Parameters.AddWithValue("@cliente", clienteComboBox.SelectedIndex + 1); //+1 Porque arranca de 0
                        sqlCmd.Parameters.AddWithValue("@Empresa", empresaComboBox.SelectedIndex + 1); //+1 Porque arranca de 0

                        utils.validarYAgregarParam(sqlCmd, "@numeroFactura", numFactTextBox);
                        sqlCmd.Parameters.AddWithValue("@fecha_alta", fechaAltaFactDT.Value);

                        validarFechaVencimientoYAgregar(sqlCmd);

                        utils.validarImporte(sqlCmd, "@total", totalTextBox);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Factura creada");
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");

                        sqlCmd.Parameters.AddWithValue("@cliente", clienteComboBox.SelectedIndex + 1); //+1 Porque arranca de 0
                        sqlCmd.Parameters.AddWithValue("@Empresa", empresaComboBox.SelectedIndex + 1); //+1 Porque arranca de 0

                        utils.validarYAgregarParam(sqlCmd, "@numeroFactura", numFactTextBox);
                        sqlCmd.Parameters.AddWithValue("@fecha_alta", fechaAltaFactDT.Value);
                        validarFechaVencimientoYAgregar(sqlCmd);

                        utils.validarImporte(sqlCmd, "@total", totalTextBox);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Factura actualizada");

                        if (sqlCon.State == ConnectionState.Open) sqlCmd.Connection.Close();

                        numFactFilterTextBoxL.Text = numFactTextBox.Text.Trim();
                        searchBtnL_Click(sender, e);
                        tabControl1.SelectedIndex = 0;

                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 facturas con el mismo numero-factura", "Error Message");
                    else if (sqlException.Number == 8114) MessageBox.Show("Todos los campos correspondientes son obligatorios", "Error Message");
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
        }

        public void validarFechaVencimientoYAgregar(SqlCommand sqlCmd)
        {
            DateTime fechaVenc = Convert.ToDateTime(fechaVencDT.Value);
            if (fechaVenc > DateTime.Now.Date) throw new Exception("La fecha de vencimiento debe ser anterior a la fecha de hoy");
            else sqlCmd.Parameters.AddWithValue("@fecha_venc", fechaVencDT.Value);
        }

        private void agregarItemBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (agregarItemBtn.Text == "Agregar Item")
                {
                    insertarItem();
                    fillDataGridViewItems();
                }
                else
                    updateItem();
                    fillDataGridViewItems();
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    MessageBox.Show(ex.Message, "Mensaje de Error");
                }
                else
                {
                   MessageBox.Show(ex.Message, "Error Message");
                }
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        void insertarItem()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@idItem", 0);

                utils.validarYAgregarParam(sqlCmd, "@descripcion", descrTextBox);

                utils.validarConvYAgregarParam(sqlCmd, "@monto", montoTextBox);
                utils.validarConvYAgregarParam(sqlCmd, "@cantidad", cantTextBox);

                sqlCmd.Parameters.AddWithValue("@importe", Convert.ToDecimal(montoTextBox.Text.Trim()) * Convert.ToInt16(cantTextBox.Text.Trim()));
                if ((string.IsNullOrWhiteSpace(numFactTextBox.Text.Trim()))) throw new Exception("Ingrese un Numero de Factura");
                else sqlCmd.Parameters.AddWithValue("@numeroFactura", numFactTextBox.Text.Trim());

                int exitCode = sqlCmd.ExecuteNonQuery();
                if (exitCode == -1) MessageBox.Show("Ya existe el item ingresado para la factura" + " " + numFactTextBox.Text.Trim());
                else MessageBox.Show("Item creado");

                sqlCon.Close();
            }
        }


        void updateItem()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@idItem", Convert.ToInt32(itemsDataGrid.CurrentRow.Cells[0].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@numeroFactura", numFactLabel2.Text.Trim());

                if (!(string.IsNullOrWhiteSpace(descrTextBox.Text.Trim()))) sqlCmd.Parameters.AddWithValue("@descripcion", descrTextBox.Text.Trim());

                utils.validarConvYAgregarParam(sqlCmd, "@monto", montoTextBox);
                utils.validarConvYAgregarParam(sqlCmd, "@cantidad", cantTextBox);

                sqlCmd.Parameters.AddWithValue("@importe", Convert.ToDecimal(montoTextBox.Text.Trim()) * Int16.Parse(cantTextBox.Text.Trim()));

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Item actualizado correctamente");

                sqlCon.Close();
            }
        }

        void fillDataGridViewItems()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.ItemView", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                
                if (string.IsNullOrWhiteSpace(numFactTextBox.Text.Trim())) throw new Exception("Ingrese un Numero de Factura para ver sus items");
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirAValor(numFactTextBox));

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                itemsDataGrid.DataSource = dtbl;

                totalTextBox.Text = utils.calcularColumna("importe", dtbl);
                numFactLabel2.Text = numFactTextBox.Text;
                
                sqlCon.Close();
            }
        }

        private void itemsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void cantTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillDataGridViewItems();
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

        private void empresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiarBtn_Click_1(object sender, EventArgs e)
        {
            clienteComboBox.Text = empresaComboBox.Text = numFactTextBox.Text = fechaAltaFactDT.Text
                 = fechaVencDT.Text = totalTextBox.Text = montoTextBox.Text = cantTextBox.Text = descrTextBox.Text = numFactLabel2.Text = "";
            guardarFactButton.Text = "Guardar Factura";
            agregarItemBtn.Text = "Agregar Item";

            itemsDataGrid.DataSource = new DataTable();
        }

        private void itemsDataGrid_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (itemsDataGrid.CurrentRow.Index != -1)
            {
                descrTextBox.Text = itemsDataGrid.CurrentRow.Cells[1].Value.ToString();
                montoTextBox.Text = itemsDataGrid.CurrentRow.Cells[2].Value.ToString();
                cantTextBox.Text = itemsDataGrid.CurrentRow.Cells[3].Value.ToString();
                numFactLabel2.Text = numFactTextBox.Text;

                agregarItemBtn.Text = "Update Item";
            }
        }

        private void itemsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtnL_Click(object sender, EventArgs e)
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
        
        public void fillDataGridViewFacturas(){
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.FacturaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (string.IsNullOrWhiteSpace(numFactFilterTextBoxL.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", utils.convertirAValor(numFactFilterTextBoxL));

                if (string.IsNullOrWhiteSpace(empresaFilterComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idEmpresa", empresaFilterComboBox.SelectedIndex + 1);

                if (string.IsNullOrWhiteSpace(clienteFilterComboBox.Text.Trim())) sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", DBNull.Value);
                else sqlDa.SelectCommand.Parameters.AddWithValue("@idCliente", clienteFilterComboBox.SelectedIndex + 1);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                facturasDataGridL.DataSource = dtbl;
                importeCobroTextBox.Text = utils.calcularColumna("total", dtbl);
                sqlCon.Close();
            }
        }

        private void ABM_Click(object sender, EventArgs e)
        {
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void facturasDataGridL_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (facturasDataGridL.CurrentRow.Index != -1)
            {
                numFactTextBox.Text = facturasDataGridL.CurrentRow.Cells[0].Value.ToString();
                clienteComboBox.SelectedIndex = Convert.ToInt32(facturasDataGridL.CurrentRow.Cells[1].Value.ToString()) - 1;
                empresaComboBox.SelectedIndex = Convert.ToInt32(facturasDataGridL.CurrentRow.Cells[2].Value.ToString()) - 1;

                fechaAltaFactDT.Text = facturasDataGridL.CurrentRow.Cells[3].Value.ToString();
                fechaVencDT.Text = facturasDataGridL.CurrentRow.Cells[4].Value.ToString();
                totalTextBox.Text = facturasDataGridL.CurrentRow.Cells[5].Value.ToString();
                
                numFactLabel2.Text = numFactTextBox.Text;

                guardarFactButton.Text = "Update Factura";
                tabControl1.SelectedIndex = 1;

            }
        }

        private void facturasDataGrid_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        }

        private void limpiarBtnL_Click(object sender, EventArgs e)
        {
            numFactFilterTextBoxL.Text = importeCobroTextBox.Text = clienteFilterComboBox.Text = clienteCobroTextBox.Text = 
                empresaFilterComboBox.Text = sucursalCobroTextBox.Text = "";

            facturasDataGridL.DataSource = new DataTable();
        }

        private void eliminarBtnL_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (facturasDataGridL.CurrentRow == null) throw new Exception("No se selecciono ninguna factura");
                    sqlCmd.Parameters.AddWithValue("@numerofactura", Convert.ToInt64(facturasDataGridL.CurrentRow.Cells[0].Value.ToString()));

                    int exitCode = sqlCmd.ExecuteNonQuery();
                    if (exitCode == -1) MessageBox.Show("No se puede eliminar una factura pagada/rendida");
                    else
                    {
                        MessageBox.Show("Factura " + facturasDataGridL.CurrentRow.Cells[0].Value.ToString() + " Eliminada");
                        facturasDataGridL.Rows.RemoveAt(facturasDataGridL.CurrentRow.Index);
                    }

                    if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

                    searchBtnL_Click(sender, e);
                }
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

        private void eliminarItemBtn_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemDelete", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@numeroFactura", Convert.ToInt64(numFactLabel2.Text));
                sqlCmd.Parameters.AddWithValue("@idItem", Convert.ToInt64(itemsDataGrid.CurrentRow.Cells[0].Value.ToString()));

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Item " + itemsDataGrid.CurrentRow.Cells[0].Value.ToString() + " Eliminado");
                itemsDataGrid.Rows.RemoveAt(itemsDataGrid.CurrentRow.Index);

                sqlCon.Close();

                refreshBtn_Click_1(sender, e);
            }

        }

        private void registrarPagoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idPago = registroDePago.cobrar(clienteFilterComboBox, 1, importeCobroTextBox, formaDePagoTextBox);//sucursal hardcodeada. TODO se tiene que obtener del operador (cuando este lo del login)
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

        private void Listado_Click(object sender, EventArgs e)
        {

        }

        private void clienteFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteCobroTextBox.Text = clienteFilterComboBox.Text;
        }

    }
}
