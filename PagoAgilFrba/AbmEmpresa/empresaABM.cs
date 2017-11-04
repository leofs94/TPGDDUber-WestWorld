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
            llenar(rubroFilter, rubros);
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
                        sqlCmd.Parameters.AddWithValue("@idRubro", 3);//probando
                        sqlCmd.Parameters.AddWithValue("@habilitado", 1);//probando
                        //sqlCmd.Parameters.AddWithValue("@idRubro", rubroComboBox.ValueMember);
                        //sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);

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
                        sqlCmd.Parameters.AddWithValue("@idRubro", rubroComboBox.ValueMember);
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Empresa modificada correctamente");

                    }
            }catch (Exception ex)
            { 
                if(ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;

                    if (sqlException.Number == 8114) MessageBox.Show("Todos los campos son obligatorios", "Error Message");
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


    }
}
