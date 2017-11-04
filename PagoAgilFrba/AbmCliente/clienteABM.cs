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
using System.Data.Entity.Infrastructure;


namespace PagoAgilFrba.AbmCliente
{
    public partial class clienteABM : Form
    {
        SqlConnection sqlCon = new SqlConnection(@Properties.Settings.Default.SQLSERVER2012);
        public clienteABM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2017DataSet.Cliente' Puede moverla o quitarla según sea necesario.


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.telefonoTxtBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTxtBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoTime = new System.Windows.Forms.DateTimePicker();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nombreFilterTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.apellidoFilterTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dniFilterTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.clienteDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.habilitadoCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(170, 32);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direccion";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(170, 73);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 5;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(170, 149);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(170, 114);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.mailTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "DNI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fec. Nac.";
            // 
            // telefonoTxtBox
            // 
            this.telefonoTxtBox.Location = new System.Drawing.Point(509, 118);
            this.telefonoTxtBox.Name = "telefonoTxtBox";
            this.telefonoTxtBox.Size = new System.Drawing.Size(83, 20);
            this.telefonoTxtBox.TabIndex = 13;
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(509, 73);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(67, 20);
            this.dniTextBox.TabIndex = 14;
            // 
            // codigoPostalTxtBox
            // 
            this.codigoPostalTxtBox.Location = new System.Drawing.Point(509, 32);
            this.codigoPostalTxtBox.Name = "codigoPostalTxtBox";
            this.codigoPostalTxtBox.Size = new System.Drawing.Size(48, 20);
            this.codigoPostalTxtBox.TabIndex = 15;
            // 
            // fechaNacimientoTime
            // 
            this.fechaNacimientoTime.Location = new System.Drawing.Point(509, 150);
            this.fechaNacimientoTime.Name = "fechaNacimientoTime";
            this.fechaNacimientoTime.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoTime.TabIndex = 16;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(95, 468);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 17;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Filtrar";
            // 
            // nombreFilterTxt
            // 
            this.nombreFilterTxt.Location = new System.Drawing.Point(170, 257);
            this.nombreFilterTxt.Name = "nombreFilterTxt";
            this.nombreFilterTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreFilterTxt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nombre";
            // 
            // apellidoFilterTxt
            // 
            this.apellidoFilterTxt.Location = new System.Drawing.Point(372, 258);
            this.apellidoFilterTxt.Name = "apellidoFilterTxt";
            this.apellidoFilterTxt.Size = new System.Drawing.Size(100, 20);
            this.apellidoFilterTxt.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Apellido";
            // 
            // dniFilterTxt
            // 
            this.dniFilterTxt.Location = new System.Drawing.Point(609, 257);
            this.dniFilterTxt.Name = "dniFilterTxt";
            this.dniFilterTxt.Size = new System.Drawing.Size(100, 20);
            this.dniFilterTxt.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(559, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "DNI";
            // 
            // clienteDataGrid
            // 
            this.clienteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGrid.Location = new System.Drawing.Point(86, 295);
            this.clienteDataGrid.Name = "clienteDataGrid";
            this.clienteDataGrid.Size = new System.Drawing.Size(623, 150);
            this.clienteDataGrid.TabIndex = 25;
            this.clienteDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clienteDataGrid_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(748, 254);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 23);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(94, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Habilitado";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // habilitadoCheck
            // 
            this.habilitadoCheck.AutoSize = true;
            this.habilitadoCheck.Location = new System.Drawing.Point(170, 194);
            this.habilitadoCheck.Name = "habilitadoCheck";
            this.habilitadoCheck.Size = new System.Drawing.Size(15, 14);
            this.habilitadoCheck.TabIndex = 29;
            this.habilitadoCheck.UseVisualStyleBackColor = true;
            this.habilitadoCheck.CheckedChanged += new System.EventHandler(this.habilitadoCheck_CheckedChanged);
            // 
            // clienteABM
            // 
            this.ClientSize = new System.Drawing.Size(939, 565);
            this.Controls.Add(this.habilitadoCheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clienteDataGrid);
            this.Controls.Add(this.dniFilterTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.apellidoFilterTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nombreFilterTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.fechaNacimientoTime);
            this.Controls.Add(this.codigoPostalTxtBox);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.telefonoTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "clienteABM";
            this.Text = "ABMCliente";
            this.Load += new System.EventHandler(this.clienteABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    if (guardarBtn.Text == "Guardar"){
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ClienteCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@idCliente", 0);
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@apellido", apellidoTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@mail", mailTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@codigoPostal", codigoPostalTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@dni", dniTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@telefono", telefonoTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@fec_nac", fechaNacimientoTime.Value);
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente creado");
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("GD2C2017.WEST_WORLD.ClienteCreateOrUpdate", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(clienteDataGrid.CurrentRow.Cells[0].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@apellido", apellidoTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@mail", mailTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@codigoPostal", codigoPostalTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@dni", dniTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@telefono", telefonoTxtBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@fec_nac", fechaNacimientoTime.Value);
                        sqlCmd.Parameters.AddWithValue("@habilitado", habilitadoCheck.Checked);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente modificado correctamente");

                    }
                    

                }

            }
            catch (Exception ex)
            { 
                if(ex is SqlException)
                {
                    SqlException sqlException = ex as SqlException;

                    if (sqlException.Number == 2627) MessageBox.Show("No pueden existir 2 clientes con el mismo mail", "Error Message");
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

        void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GD2C2017.WEST_WORLD.ClienteViewOrSearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@nombre", nombreFilterTxt.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@apellido", apellidoFilterTxt.Text.Trim());
                String dniFiltertxt = dniFilterTxt.Text.Trim();
                if(dniFiltertxt == "" ){
                    sqlDa.SelectCommand.Parameters.AddWithValue("@dni", DBNull.Value);

                }
                else sqlDa.SelectCommand.Parameters.AddWithValue("@dni", dniFiltertxt);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                clienteDataGrid.DataSource = dtbl;
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

        private void clienteDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(clienteDataGrid.CurrentRow.Index != -1)
            {
                nombreTextBox.Text = clienteDataGrid.CurrentRow.Cells[1].Value.ToString();
                apellidoTextBox.Text = clienteDataGrid.CurrentRow.Cells[2].Value.ToString();
                mailTextBox.Text = clienteDataGrid.CurrentRow.Cells[3].Value.ToString();
                direccionTextBox.Text = clienteDataGrid.CurrentRow.Cells[4].Value.ToString();
                codigoPostalTxtBox.Text = clienteDataGrid.CurrentRow.Cells[5].Value.ToString();
                dniTextBox.Text = clienteDataGrid.CurrentRow.Cells[6].Value.ToString();
                telefonoTxtBox.Text = clienteDataGrid.CurrentRow.Cells[7].Value.ToString();
                fechaNacimientoTime.Text = clienteDataGrid.CurrentRow.Cells[8].Value.ToString();
                habilitadoCheck.Checked = (bool) clienteDataGrid.CurrentRow.Cells[9].Value;
                guardarBtn.Text = "Update";
            }
        }

        void reset()
        {
            nombreTextBox.Text = apellidoTextBox.Text = mailTextBox.Text = direccionTextBox.Text =
                codigoPostalTxtBox.Text = dniTextBox.Text = telefonoTxtBox.Text = fechaNacimientoTime.Text = "";
            guardarBtn.Text = "Guardar";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void clienteABM_Load(object sender, EventArgs e)
        {

        }

        private void habilitadoCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
