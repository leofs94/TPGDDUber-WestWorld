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


namespace PagoAgilFrba.AbmFactura
{
    public partial class facturaABM : Form
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public facturaABM()
        {
            InitializeComponent();
            List<KeyValuePair<int, string>> empresas = GetEmpresas();
            llenar(empresaComboBox, empresas);
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
                empresas.Add(new KeyValuePair<int, string>(Int32.Parse(reader["cuit"].ToString()), reader["nombre"].ToString()));
            }
            reader.Close();
            sqlCon.Close();
            return empresas;
        }

        private void guardarFactButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (guardarFactButton.Text == "Guardar")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.FacturaCreate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                      
                        sqlCmd.Parameters.AddWithValue("@cliente", clienteTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@idEmpresa", empresaComboBox.SelectedIndex + 1); //+1 Porque arranca de 0
                        sqlCmd.Parameters.AddWithValue("@numeroFactura", numFactTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@fec_alta", fechaAltaFactDT.Value);
                        sqlCmd.Parameters.AddWithValue("@fec_venc", fechaVencDT.Value);
                        sqlCmd.Parameters.AddWithValue("@total", totalTextBox);

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
            SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ItemCreate", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@descripcion", descrTextBox.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@monto", montoTextBox.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@cantidad", cantidadTextBox.Text.Trim());

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Item creado");
        }

        void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.ItemCreate", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@descripcion", descrTextBox.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@monto", montoTextBox.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@cantidad", cantidadTextBox.Text.Trim());

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                itemsDataGrid.DataSource = dtbl;
                sqlCon.Close();
            }
        }
    }
}
