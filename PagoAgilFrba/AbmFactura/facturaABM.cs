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
            utils.llenar(empresaComboBox, empresas);
            utils.llenar(empresaFilterComboBox, empresas);
            
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

                        utils.validarYAgregarParam(sqlCmd, "@cliente", idClienteTextBox2);
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

                        utils.validarYAgregarParam(sqlCmd, "@cliente", idClienteTextBox2);
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
            if (fechaVenc.Date > DateTime.Now.Date) throw new Exception("La fecha de vencimiento no debe ser mayor a la fecha de hoy");
            else sqlCmd.Parameters.AddWithValue("@fecha_venc", fechaVencDT.Value);
        }

        private void agregarItemBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (agregarItemBtn.Text == "Agregar Item")
                {
                    insertarItem(sender, e);
                    fillDataGridViewItems();
                }
                else
                {
                    actualizarItem();
                    fillDataGridViewItems();
                }
                actualizarImporteDeFactura();
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

        public void actualizarImporteDeFactura()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaImporteUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                utils.validarYAgregarParam(sqlCmd, "@numeroFactura", numFactTextBox);
                utils.validarImporte(sqlCmd, "@total", totalTextBox);

                sqlCmd.ExecuteNonQuery();

                sqlCmd.Connection.Close();
            }
        }

        void insertarItem(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@idItem", 0);
                
                utils.validarConvYAgregarParam(sqlCmd, "@monto", montoTextBox);
                utils.validarConvYAgregarParam(sqlCmd, "@cantidad", cantTextBox);

                sqlCmd.Parameters.AddWithValue("@importe", Convert.ToDecimal(montoTextBox.Text.Trim()) * Convert.ToInt16(cantTextBox.Text.Trim()));
                if ((string.IsNullOrWhiteSpace(numFactTextBox.Text.Trim()))) throw new Exception("Ingrese un Numero de Factura");
                else sqlCmd.Parameters.AddWithValue("@numeroFactura", numFactTextBox.Text.Trim());

                int exitCode = sqlCmd.ExecuteNonQuery();
                if (exitCode == -1) throw new Exception("Ya existe el item ingresado para la factura" + " " + numFactTextBox.Text.Trim());
                MessageBox.Show("Item creado");

                sqlCon.Close();
            }
        }


        private void actualizarItem()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreateOrUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@idItem", Convert.ToInt32(itemsDataGrid.CurrentRow.Cells[0].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@numeroFactura", numFactLabel2.Text.Trim());

                utils.validarConvYAgregarParam(sqlCmd, "@monto", montoTextBox);
                utils.validarConvYAgregarParam(sqlCmd, "@cantidad", cantTextBox);

                sqlCmd.Parameters.AddWithValue("@importe", Convert.ToDecimal(montoTextBox.Text.Trim()) * Int16.Parse(cantTextBox.Text.Trim()));

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Item actualizado");

                sqlCon.Close();
            }
        }

        private void fillDataGridViewItems()
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

        private void actualizarTablaItemsBtn_Click(object sender, EventArgs e)
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
            empresaComboBox.Text = numFactTextBox.Text = fechaAltaFactDT.Text = idClienteTextBox2.Text = clienteTextBox2.Text
                 = fechaVencDT.Text = totalTextBox.Text = montoTextBox.Text = cantTextBox.Text = numFactLabel2.Text = "";
            guardarFactButton.Text = "Guardar Factura";
            agregarItemBtn.Text = "Agregar Item";

            itemsDataGrid.DataSource = new DataTable();
        }

        private void itemsDataGrid_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (itemsDataGrid.CurrentRow.Index != -1)
            {
                montoTextBox.Text = itemsDataGrid.CurrentRow.Cells[1].Value.ToString();
                cantTextBox.Text = itemsDataGrid.CurrentRow.Cells[2].Value.ToString();
                numFactLabel2.Text = numFactTextBox.Text;

                agregarItemBtn.Text = "Actualizar Item";
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
        
        private void fillDataGridViewFacturas(){
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.FacturaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@estado", "Todas");

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

        private void ABM_Click(object sender, EventArgs e)
        {
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void facturasDataGridL_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(facturasDataGridL.CurrentRow.Cells[7].Value.ToString())))
                    throw new Exception("No se puede actualizar una factura pagada y/o rendida");
            
                if (facturasDataGridL.CurrentRow.Index != -1)
                {
                    numFactTextBox.Text = facturasDataGridL.CurrentRow.Cells[0].Value.ToString();
                    idClienteTextBox2.Text = facturasDataGridL.CurrentRow.Cells[1].Value.ToString();

                    if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = "SELECT nombre + ' ' + apellido FROM WEST_WORLD.Cliente WHERE idCliente = " + idClienteTextBox2.Text;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = sqlCon;
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read()) clienteTextBox2.Text = reader.GetString(0);
                    sqlCon.Close();

                    empresaComboBox.SelectedIndex = Convert.ToInt32(facturasDataGridL.CurrentRow.Cells[2].Value.ToString()) - 1;

                    fechaAltaFactDT.Text = facturasDataGridL.CurrentRow.Cells[3].Value.ToString();
                    fechaVencDT.Text = facturasDataGridL.CurrentRow.Cells[4].Value.ToString();
                    totalTextBox.Text = facturasDataGridL.CurrentRow.Cells[5].Value.ToString();
                
                    numFactLabel2.Text = numFactTextBox.Text;

                    guardarFactButton.Text = "Actualizar Factura";
                    tabControl1.SelectedIndex = 1;

                    actualizarTablaItemsBtn_Click(sender, e); //actualiza DataGridView items

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

        private void facturasDataGrid_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        }

        private void limpiarBtnL_Click(object sender, EventArgs e)
        {
            numFactFilterTextBoxL.Text = clienteTextBox.Text = idClienteTextBox.Text = empresaFilterComboBox.Text = "";

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
                    if (exitCode == -1) MessageBox.Show("No se puede eliminar una factura pagada y/o rendida");
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
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    if (itemsDataGrid.CurrentRow == null) throw new Exception("No se selecciono ningun Item");
                    sqlCmd.Parameters.AddWithValue("@numeroFactura", Convert.ToInt64(numFactLabel2.Text));
                    sqlCmd.Parameters.AddWithValue("@idItem", Convert.ToInt64(itemsDataGrid.CurrentRow.Cells[0].Value.ToString()));

                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Item " + itemsDataGrid.CurrentRow.Cells[0].Value.ToString() + " Eliminado");
                    itemsDataGrid.Rows.RemoveAt(itemsDataGrid.CurrentRow.Index);

                    sqlCon.Close();

                    actualizarTablaItemsBtn_Click(sender, e);
                    actualizarImporteDeFactura();
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

        private void Listado_Click(object sender, EventArgs e)
        {

        }

        private void clienteFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void limpiarItemBtn_Click(object sender, EventArgs e)
        {
            montoTextBox.Text = cantTextBox.Text = "";
            agregarItemBtn.Text = "Agregar Item";
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

        private void seleccionarClienteBtn_Click_2(object sender, EventArgs e)
        {
            BuscarCliente busquedaDeCliente = new BuscarCliente();
            busquedaDeCliente.ShowDialog();

            if (!string.IsNullOrWhiteSpace(busquedaDeCliente.clienteTextBox.Text) & !string.IsNullOrWhiteSpace(busquedaDeCliente.idClienteTextBox.Text))
            {
                idClienteTextBox2.Text = busquedaDeCliente.idClienteTextBox.Text;
                clienteTextBox2.Text = busquedaDeCliente.clienteTextBox.Text;
            }
        }

        private void fechaVencDT_ValueChanged(object sender, EventArgs e)
        {   
            DateTime fechaVenc = Convert.ToDateTime(fechaVencDT.Value);
            if (fechaVenc.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de vencimiento no debe ser mayor a la fecha de hoy", "Error Message");
                fechaVencDT.Value = Convert.ToDateTime(DateTime.Now.Date);
            }
        }

    }
}
