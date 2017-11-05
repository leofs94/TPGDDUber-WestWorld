using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class sucursalABM : Form
    {
        SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);

        public sucursalABM()
        {
            InitializeComponent();
        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        void reset()
        {
            nombreTextBox.Text = direccionTextBox.Text = codigoPostalTxtBox.Text = "";
            guardarBtn.Text = "Guardar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.SucursalViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@nombre", nombreFilterTxt.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@direccion", apellidoFilterTxt.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@codigoPostal", Convert.ToInt32(codigoPostalTxtBox.Text.Trim()));
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                sucursalDataGrid.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
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

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (guardarBtn.Text == "Guardar")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.SucursalCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@idSucursal", 0);
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@codigoPostal", Convert.ToInt32(codigoPostalTxtBox.Text.Trim()));
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);
                        sqlCmd.Parameters.AddWithValue("@operador", 0);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Sucursal creada");
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.SucursalCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@idSucursal", Convert.ToInt32(sucursalDataGrid.CurrentRow.Cells[0].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@codigoPostal", Convert.ToInt32(codigoPostalTxtBox.Text.Trim()));
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);
                        sqlCmd.Parameters.AddWithValue("@operador", 0);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Sucursal modificada correctamente");

                    }

                }

            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;

                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 sucursales con el mismo codigo postal", "Error Message");
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

        private void sucursalDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
