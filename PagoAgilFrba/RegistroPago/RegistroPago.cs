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
    public class RegistroPago : Form  
    {
        static SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        private Utils utils = new Utils();

        public RegistroPago()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numFacturaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroPago_Load(object sender, EventArgs e)
        {

        }

         private void systemFechaComboBox_ValueChanged_1(object sender, EventArgs e)
        {

        }

         private void fechaVencFactLabel_Click(object sender, EventArgs e)
         {

         }

         private void fechaVencFact_ValueChanged(object sender, EventArgs e)
         {

         }

         public int cobrar(ComboBox cliente, int sucursal, TextBox importe, TextBox formaDePago)
         {
             try
             {
                 if (sqlCon.State == ConnectionState.Closed)
                 {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.PagoCreate", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@idCliente", cliente.SelectedIndex + 1); //+1 Porque arranca de 0

                    utils.validarImporte(sqlCmd, "@importe", importe);
                    sqlCmd.Parameters.AddWithValue("@idSucursal", sucursal);
                    sqlCmd.Parameters.AddWithValue("@fechaCobro", DateTime.Now);
                    utils.validarYAgregarParam(sqlCmd, "@formaDePago", formaDePago);
                         
                    int idPago = sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Se registró el pago " + idPago.ToString() + " correctamente");

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
             return -2;
         }

    }
}
