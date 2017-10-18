using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class clienteABM : Form
    {
        public clienteABM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2017DataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gD2C2017DataSet.Cliente);
            BindingSource customersBindingSource = new BindingSource();


            this.bindingNavigator1.BindingSource = customersBindingSource;


            customersBindingSource.DataSource = this.gD2C2017DataSet.Cliente;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            this.gD2C2017DataSet.Cliente.AcceptChanges();
        }
    }
}
