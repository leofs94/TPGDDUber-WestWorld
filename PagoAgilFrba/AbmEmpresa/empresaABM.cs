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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class empresaABM : Form

    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public empresaABM()
        {
            InitializeComponent();
            llenarCombosRubro();
        }

        public void llenarCombosRubro()
        {
            List<KeyValuePair<int, string>> rubros = GetRubros();
            llenar(rubroComboBox, rubros);
            llenar(rubroFilterComboBox, rubros);
        }

        public void llenar(ComboBox combo, List<KeyValuePair<int,string>> items)
        {
            combo.Items.Clear();
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";

            items.ForEach(item => combo.Items.Add(item));
        }

        static public List<KeyValuePair<int, string>> GetRubros()
        {
            List<KeyValuePair<int, string>> rubros = new List<KeyValuePair<int, string>>();

            SqlCommand com = new SqlCommand("WEST_WORLD.GetRubros", sqlCon);
            com.CommandType = CommandType.StoredProcedure;

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                rubros.Add(new KeyValuePair<int, string>(Int32.Parse(reader["idRubro"].ToString()), reader["nombre"].ToString()));
            }
            reader.Close();
            return rubros;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                if (btnGuardar.Text == "Guardar")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.EmpresaCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@cuit", cuitTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@idRubro", rubroComboBox.SelectedIndex + 1); //+1 Porque arranca de 0
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Empresa creada");
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.EmpresaCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@cuit", cuitTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@idRubro", rubroComboBox.SelectedIndex + 1); //+1 Porque arranca de 0
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Empresa modificada correctamente");

                    }
            }catch (Exception ex)
            { 
                if(ex is SqlException)
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
                sqlCon.Close();
            }
        }

        private void habilitadoCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rubroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.EmpresaViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@nombre", nombreFilterTextBox.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@cuit", cuitFilter.Text.Trim());

                sqlDa.SelectCommand.Parameters.AddWithValue("@idRubro", rubroFilterComboBox.ValueMember);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                empresaDataGrid.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void empresaDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (empresaDataGrid.CurrentRow.Index != -1)
            {
                nombreTextBox.Text = empresaDataGrid.CurrentRow.Cells[1].Value.ToString();
                direccionTextBox.Text = empresaDataGrid.CurrentRow.Cells[2].Value.ToString();
                habilitadoCheck.Checked = (bool)empresaDataGrid.CurrentRow.Cells[3].Value;
                btnGuardar.Text = "Update";
            }
        }

        void reset()
        {
            nombreTextBox.Text = direccionTextBox.Text = "";
            btnGuardar.Text = "Guardar";
        }

        private void nombreFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rubroFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

    }
}
