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
      SqlConnection sqlCon =  new SqlConnection(ConnectionString.sqlCon);
        public empresaABM()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (btnGuardar.Text == "Guardar")
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.EmpresaCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@idEmpresa", 0);
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@cuit", cuitTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@rubro", rubroComboBox.TabIndex);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente creado");
                    }
                    else
                    {
                        //SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ClienteCreateOrUpdate", sqlCon);
                        //sqlCmd.CommandType = CommandType.StoredProcedure;
                        //sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        //sqlCmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(clienteDataGrid.CurrentRow.Cells[0].Value.ToString()));
                        //sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        //sqlCmd.Parameters.AddWithValue("@apellido", apellidoTextBox.Text.Trim());
                        //sqlCmd.Parameters.AddWithValue("@mail", mailTextBox.Text.Trim());
                        //sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        //sqlCmd.Parameters.AddWithValue("@codigoPostal", codigoPostalTxtBox.Text.Trim());
                        //sqlCmd.Parameters.AddWithValue("@dni", dniTextBox.Text.Trim());
                        //sqlCmd.Parameters.AddWithValue("@telefono", telefonoTxtBox.Text.Trim());
                        //sqlCmd.Parameters.AddWithValue("@fec_nac", fechaNacimientoTime.Value);
                        //sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);
                        //sqlCmd.ExecuteNonQuery();
                        //MessageBox.Show("Cliente modificado correctamente");

                    }


                }
            }catch(Exception ex)
            {

            }
        }
    }
}
