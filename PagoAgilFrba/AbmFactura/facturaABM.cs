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

        public facturaABM()
        {
            InitializeComponent();
            List<KeyValuePair<int, string>> empresas = GetEmpresas();
            List<KeyValuePair<int, string>> clientes = GetClientes();
            llenar(empresaComboBox, empresas);
            llenar(clienteComboBox, clientes);

        }


        private void facturaABM_Load_1(object sender, EventArgs e)
        {

        }


        public void llenar(ComboBox combo, List<KeyValuePair<int, string>> items)
        {
            combo.Items.Clear();
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";

            items.ForEach(item => combo.Items.Add(item));
        }

        static public List<KeyValuePair<int, string>> GetEmpresas()
        {
            List<KeyValuePair<int, string>> empresas = new List<KeyValuePair<int, string>>();

            SqlCommand com = new SqlCommand("WEST_WORLD.GetEmpresas", sqlCon);
            com.CommandType = CommandType.StoredProcedure;

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                empresas.Add(new KeyValuePair<int, string>(Int32.Parse(reader["idEmpresa"].ToString()), reader["nombre"].ToString()));
            }
            reader.Close();
            sqlCon.Close();
            return empresas;
        }

        static public List<KeyValuePair<int, string>> GetClientes()
        {
            List<KeyValuePair<int, string>> clientes = new List<KeyValuePair<int, string>>();

            SqlCommand com = new SqlCommand("WEST_WORLD.GetClientes", sqlCon);
            com.CommandType = CommandType.StoredProcedure;

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                clientes.Add(new KeyValuePair<int, string>(Int32.Parse(reader["idCliente"].ToString()), reader["nombre"].ToString() + ' ' + reader["apellido"].ToString()));
            }
            reader.Close();
            sqlCon.Close();
            return clientes;
        }

        private void guardarFactButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (guardarFactButton.Text == "Guardar Factura")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaCreate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.AddWithValue("@cliente", clienteComboBox.SelectedIndex + 1); //+1 Porque arranca de 0
                        sqlCmd.Parameters.AddWithValue("@Empresa", empresaComboBox.SelectedIndex + 1); //+1 Porque arranca de 0
                        sqlCmd.Parameters.AddWithValue("@numeroFactura", numFactTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@fecha_alta", fechaAltaFactDT.Value);
                        sqlCmd.Parameters.AddWithValue("@fecha_venc", fechaVencDT.Value);
                        sqlCmd.Parameters.AddWithValue("@total", convertirAValor(totalTextBox));

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Factura creada");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;
                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 facturas con el mismo numero-factura", "Error Message");
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
        }

        private void agregarItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                insertarItem();
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        void insertarItem()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@descripcion", descrTextBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@monto", convertirAValor(montoTextBox));
                sqlCmd.Parameters.AddWithValue("@cantidad", convertirAValor(cantTextBox));
                sqlCmd.Parameters.AddWithValue("@numeroFactura", convertirAValor(numFactTextBox));

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Item creado");
                sqlCon.Close();
            }
        }

        public SqlDecimal convertirAValor(TextBox textBox)
        {
            return SqlDecimal.Parse(textBox.Text.Trim().ToString());
        }

        void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.ItemView", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                //sqlDa.SelectCommand.Parameters.AddWithValue("@descripcion", descrTextBox.Text.Trim());
                //sqlDa.SelectCommand.Parameters.AddWithValue("@monto", convertirAValor(montoTextBox));
                //sqlDa.SelectCommand.Parameters.AddWithValue("@cantidad", convertirAValor(cantTextBox));
                if ((numFactTextBox.Text.Trim().ToString() == null) | (numFactTextBox.Text.Trim().ToString() == "")) throw new Exception("Ingrese un Numero de Factura para ver sus items");
                else sqlDa.SelectCommand.Parameters.AddWithValue("@numeroFactura", convertirAValor(numFactTextBox));

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                itemsDataGrid.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void itemsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void cantTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
                sqlCon.Close();
            }
        }

        private void empresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
