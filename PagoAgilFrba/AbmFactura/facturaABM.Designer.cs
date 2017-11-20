namespace PagoAgilFrba.AbmFactura
{
    partial class facturaABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Listado = new System.Windows.Forms.TabPage();
            this.limpiarBtnL = new System.Windows.Forms.Button();
            this.facturasLabel = new System.Windows.Forms.Label();
            this.eliminarBtnL = new System.Windows.Forms.Button();
            this.facturasDataGridL = new System.Windows.Forms.DataGridView();
            this.filtrarGroupBox = new System.Windows.Forms.GroupBox();
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.seleccionarClienteBtn = new System.Windows.Forms.Button();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.numFactLabelL = new System.Windows.Forms.Label();
            this.numFactFilterTextBoxL = new System.Windows.Forms.TextBox();
            this.empresaFilterComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtnL = new System.Windows.Forms.Button();
            this.empresaFilterLabel = new System.Windows.Forms.Label();
            this.ABM = new System.Windows.Forms.TabPage();
            this.clienteGroupBox2 = new System.Windows.Forms.GroupBox();
            this.idClienteTextBox2 = new System.Windows.Forms.TextBox();
            this.seleccionarBtn2 = new System.Windows.Forms.Button();
            this.clienteTextBox2 = new System.Windows.Forms.TextBox();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limpiarItemBtn = new System.Windows.Forms.Button();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.agregarItemBtn = new System.Windows.Forms.Button();
            this.cantTextBox = new System.Windows.Forms.TextBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadextBox = new System.Windows.Forms.Label();
            this.eliminarItemBtn = new System.Windows.Forms.Button();
            this.numFactLabel2 = new System.Windows.Forms.Label();
            this.itemsFacturaLabel = new System.Windows.Forms.Label();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.itemsDataGrid = new System.Windows.Forms.DataGridView();
            this.guardarFactButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.fechaVencLabel = new System.Windows.Forms.Label();
            this.fechaVencDT = new System.Windows.Forms.DateTimePicker();
            this.fechaAltaFactLabel = new System.Windows.Forms.Label();
            this.fechaAltaFactDT = new System.Windows.Forms.DateTimePicker();
            this.numFactLabel = new System.Windows.Forms.Label();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.numFactTextBox = new System.Windows.Forms.TextBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGridL)).BeginInit();
            this.filtrarGroupBox.SuspendLayout();
            this.clienteGroupBox.SuspendLayout();
            this.ABM.SuspendLayout();
            this.clienteGroupBox2.SuspendLayout();
            this.itemsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Listado);
            this.tabControl1.Controls.Add(this.ABM);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.limpiarBtnL);
            this.Listado.Controls.Add(this.facturasLabel);
            this.Listado.Controls.Add(this.eliminarBtnL);
            this.Listado.Controls.Add(this.facturasDataGridL);
            this.Listado.Controls.Add(this.filtrarGroupBox);
            this.Listado.Location = new System.Drawing.Point(4, 22);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(3);
            this.Listado.Size = new System.Drawing.Size(761, 455);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listado";
            this.Listado.UseVisualStyleBackColor = true;
            this.Listado.Click += new System.EventHandler(this.Listado_Click);
            // 
            // limpiarBtnL
            // 
            this.limpiarBtnL.Location = new System.Drawing.Point(303, 390);
            this.limpiarBtnL.Name = "limpiarBtnL";
            this.limpiarBtnL.Size = new System.Drawing.Size(109, 31);
            this.limpiarBtnL.TabIndex = 4;
            this.limpiarBtnL.Text = "Limpiar";
            this.limpiarBtnL.UseVisualStyleBackColor = true;
            this.limpiarBtnL.Click += new System.EventHandler(this.limpiarBtnL_Click);
            // 
            // facturasLabel
            // 
            this.facturasLabel.AutoSize = true;
            this.facturasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.facturasLabel.Location = new System.Drawing.Point(22, 159);
            this.facturasLabel.Name = "facturasLabel";
            this.facturasLabel.Size = new System.Drawing.Size(63, 17);
            this.facturasLabel.TabIndex = 6;
            this.facturasLabel.Text = "Facturas";
            // 
            // eliminarBtnL
            // 
            this.eliminarBtnL.Location = new System.Drawing.Point(630, 154);
            this.eliminarBtnL.Name = "eliminarBtnL";
            this.eliminarBtnL.Size = new System.Drawing.Size(116, 22);
            this.eliminarBtnL.TabIndex = 5;
            this.eliminarBtnL.Text = "Eliminar";
            this.eliminarBtnL.UseVisualStyleBackColor = true;
            this.eliminarBtnL.Click += new System.EventHandler(this.eliminarBtnL_Click);
            // 
            // facturasDataGridL
            // 
            this.facturasDataGridL.AllowUserToAddRows = false;
            this.facturasDataGridL.AllowUserToDeleteRows = false;
            this.facturasDataGridL.AllowUserToResizeRows = false;
            this.facturasDataGridL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDataGridL.Location = new System.Drawing.Point(25, 179);
            this.facturasDataGridL.Name = "facturasDataGridL";
            this.facturasDataGridL.ReadOnly = true;
            this.facturasDataGridL.Size = new System.Drawing.Size(721, 205);
            this.facturasDataGridL.TabIndex = 2;
            this.facturasDataGridL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturasDataGrid_CellContentClick);
            this.facturasDataGridL.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.facturasDataGridL_MouseDoubleClick);
            // 
            // filtrarGroupBox
            // 
            this.filtrarGroupBox.Controls.Add(this.clienteGroupBox);
            this.filtrarGroupBox.Controls.Add(this.numFactLabelL);
            this.filtrarGroupBox.Controls.Add(this.numFactFilterTextBoxL);
            this.filtrarGroupBox.Controls.Add(this.empresaFilterComboBox);
            this.filtrarGroupBox.Controls.Add(this.searchBtnL);
            this.filtrarGroupBox.Controls.Add(this.empresaFilterLabel);
            this.filtrarGroupBox.Location = new System.Drawing.Point(25, 9);
            this.filtrarGroupBox.Name = "filtrarGroupBox";
            this.filtrarGroupBox.Size = new System.Drawing.Size(717, 136);
            this.filtrarGroupBox.TabIndex = 16;
            this.filtrarGroupBox.TabStop = false;
            this.filtrarGroupBox.Text = "Criterio de Búsqueda";
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Controls.Add(this.idClienteTextBox);
            this.clienteGroupBox.Controls.Add(this.seleccionarClienteBtn);
            this.clienteGroupBox.Controls.Add(this.clienteTextBox);
            this.clienteGroupBox.Location = new System.Drawing.Point(26, 65);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(291, 54);
            this.clienteGroupBox.TabIndex = 26;
            this.clienteGroupBox.TabStop = false;
            this.clienteGroupBox.Text = "Cliente";
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Location = new System.Drawing.Point(6, 18);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(37, 20);
            this.idClienteTextBox.TabIndex = 27;
            // 
            // seleccionarClienteBtn
            // 
            this.seleccionarClienteBtn.Location = new System.Drawing.Point(204, 18);
            this.seleccionarClienteBtn.Name = "seleccionarClienteBtn";
            this.seleccionarClienteBtn.Size = new System.Drawing.Size(76, 20);
            this.seleccionarClienteBtn.TabIndex = 24;
            this.seleccionarClienteBtn.Text = "Seleccionar";
            this.seleccionarClienteBtn.UseVisualStyleBackColor = true;
            this.seleccionarClienteBtn.Click += new System.EventHandler(this.seleccionarClienteBtn_Click);
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Enabled = false;
            this.clienteTextBox.Location = new System.Drawing.Point(45, 18);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(158, 20);
            this.clienteTextBox.TabIndex = 23;
            // 
            // numFactLabelL
            // 
            this.numFactLabelL.AutoSize = true;
            this.numFactLabelL.Location = new System.Drawing.Point(68, 32);
            this.numFactLabelL.Name = "numFactLabelL";
            this.numFactLabelL.Size = new System.Drawing.Size(98, 13);
            this.numFactLabelL.TabIndex = 17;
            this.numFactLabelL.Text = "Número de Factura";
            // 
            // numFactFilterTextBoxL
            // 
            this.numFactFilterTextBoxL.Location = new System.Drawing.Point(179, 29);
            this.numFactFilterTextBoxL.Name = "numFactFilterTextBoxL";
            this.numFactFilterTextBoxL.Size = new System.Drawing.Size(121, 20);
            this.numFactFilterTextBoxL.TabIndex = 16;
            // 
            // empresaFilterComboBox
            // 
            this.empresaFilterComboBox.FormattingEnabled = true;
            this.empresaFilterComboBox.Location = new System.Drawing.Point(494, 29);
            this.empresaFilterComboBox.Name = "empresaFilterComboBox";
            this.empresaFilterComboBox.Size = new System.Drawing.Size(142, 21);
            this.empresaFilterComboBox.TabIndex = 19;
            // 
            // searchBtnL
            // 
            this.searchBtnL.Location = new System.Drawing.Point(452, 78);
            this.searchBtnL.Name = "searchBtnL";
            this.searchBtnL.Size = new System.Drawing.Size(184, 30);
            this.searchBtnL.TabIndex = 18;
            this.searchBtnL.Text = "Buscar";
            this.searchBtnL.UseVisualStyleBackColor = true;
            this.searchBtnL.Click += new System.EventHandler(this.searchBtnL_Click);
            // 
            // empresaFilterLabel
            // 
            this.empresaFilterLabel.AutoSize = true;
            this.empresaFilterLabel.Location = new System.Drawing.Point(431, 32);
            this.empresaFilterLabel.Name = "empresaFilterLabel";
            this.empresaFilterLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaFilterLabel.TabIndex = 20;
            this.empresaFilterLabel.Text = "Empresa";
            // 
            // ABM
            // 
            this.ABM.Controls.Add(this.clienteGroupBox2);
            this.ABM.Controls.Add(this.limpiarBtn);
            this.ABM.Controls.Add(this.itemsGroupBox);
            this.ABM.Controls.Add(this.guardarFactButton);
            this.ABM.Controls.Add(this.totalTextBox);
            this.ABM.Controls.Add(this.totalLabel);
            this.ABM.Controls.Add(this.fechaVencLabel);
            this.ABM.Controls.Add(this.fechaVencDT);
            this.ABM.Controls.Add(this.fechaAltaFactLabel);
            this.ABM.Controls.Add(this.fechaAltaFactDT);
            this.ABM.Controls.Add(this.numFactLabel);
            this.ABM.Controls.Add(this.empresaComboBox);
            this.ABM.Controls.Add(this.numFactTextBox);
            this.ABM.Controls.Add(this.empresaLabel);
            this.ABM.Location = new System.Drawing.Point(4, 22);
            this.ABM.Name = "ABM";
            this.ABM.Padding = new System.Windows.Forms.Padding(3);
            this.ABM.Size = new System.Drawing.Size(761, 455);
            this.ABM.TabIndex = 1;
            this.ABM.Text = "ABM";
            this.ABM.UseVisualStyleBackColor = true;
            this.ABM.Click += new System.EventHandler(this.ABM_Click);
            // 
            // clienteGroupBox2
            // 
            this.clienteGroupBox2.Controls.Add(this.idClienteTextBox2);
            this.clienteGroupBox2.Controls.Add(this.seleccionarBtn2);
            this.clienteGroupBox2.Controls.Add(this.clienteTextBox2);
            this.clienteGroupBox2.Location = new System.Drawing.Point(45, 87);
            this.clienteGroupBox2.Name = "clienteGroupBox2";
            this.clienteGroupBox2.Size = new System.Drawing.Size(291, 54);
            this.clienteGroupBox2.TabIndex = 37;
            this.clienteGroupBox2.TabStop = false;
            this.clienteGroupBox2.Text = "Cliente";
            // 
            // idClienteTextBox2
            // 
            this.idClienteTextBox2.Enabled = false;
            this.idClienteTextBox2.Location = new System.Drawing.Point(6, 18);
            this.idClienteTextBox2.Name = "idClienteTextBox2";
            this.idClienteTextBox2.Size = new System.Drawing.Size(37, 20);
            this.idClienteTextBox2.TabIndex = 27;
            // 
            // seleccionarBtn2
            // 
            this.seleccionarBtn2.Location = new System.Drawing.Point(204, 18);
            this.seleccionarBtn2.Name = "seleccionarBtn2";
            this.seleccionarBtn2.Size = new System.Drawing.Size(76, 20);
            this.seleccionarBtn2.TabIndex = 24;
            this.seleccionarBtn2.Text = "Seleccionar";
            this.seleccionarBtn2.UseVisualStyleBackColor = true;
            this.seleccionarBtn2.Click += new System.EventHandler(this.seleccionarClienteBtn_Click_2);
            // 
            // clienteTextBox2
            // 
            this.clienteTextBox2.Enabled = false;
            this.clienteTextBox2.Location = new System.Drawing.Point(45, 18);
            this.clienteTextBox2.Name = "clienteTextBox2";
            this.clienteTextBox2.Size = new System.Drawing.Size(158, 20);
            this.clienteTextBox2.TabIndex = 23;
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(330, 415);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(83, 29);
            this.limpiarBtn.TabIndex = 36;
            this.limpiarBtn.Text = "Limpiar todo";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click_1);
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.groupBox1);
            this.itemsGroupBox.Controls.Add(this.eliminarItemBtn);
            this.itemsGroupBox.Controls.Add(this.numFactLabel2);
            this.itemsGroupBox.Controls.Add(this.itemsFacturaLabel);
            this.itemsGroupBox.Controls.Add(this.actualizarBtn);
            this.itemsGroupBox.Controls.Add(this.itemsDataGrid);
            this.itemsGroupBox.Location = new System.Drawing.Point(44, 194);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(676, 206);
            this.itemsGroupBox.TabIndex = 34;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiarItemBtn);
            this.groupBox1.Controls.Add(this.montoTextBox);
            this.groupBox1.Controls.Add(this.agregarItemBtn);
            this.groupBox1.Controls.Add(this.cantTextBox);
            this.groupBox1.Controls.Add(this.cantidadLabel);
            this.groupBox1.Controls.Add(this.cantidadextBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 140);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // limpiarItemBtn
            // 
            this.limpiarItemBtn.Location = new System.Drawing.Point(0, 117);
            this.limpiarItemBtn.Name = "limpiarItemBtn";
            this.limpiarItemBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarItemBtn.TabIndex = 18;
            this.limpiarItemBtn.Text = "Limpiar";
            this.limpiarItemBtn.UseVisualStyleBackColor = true;
            this.limpiarItemBtn.Click += new System.EventHandler(this.limpiarItemBtn_Click);
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(99, 28);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(100, 20);
            this.montoTextBox.TabIndex = 14;
            // 
            // agregarItemBtn
            // 
            this.agregarItemBtn.Location = new System.Drawing.Point(99, 80);
            this.agregarItemBtn.Name = "agregarItemBtn";
            this.agregarItemBtn.Size = new System.Drawing.Size(100, 23);
            this.agregarItemBtn.TabIndex = 17;
            this.agregarItemBtn.Text = "Agregar Item";
            this.agregarItemBtn.UseVisualStyleBackColor = true;
            this.agregarItemBtn.Click += new System.EventHandler(this.agregarItemBtn_Click_1);
            // 
            // cantTextBox
            // 
            this.cantTextBox.Location = new System.Drawing.Point(99, 54);
            this.cantTextBox.Name = "cantTextBox";
            this.cantTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantTextBox.TabIndex = 13;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(44, 57);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(49, 13);
            this.cantidadLabel.TabIndex = 16;
            this.cantidadLabel.Text = "Cantidad";
            // 
            // cantidadextBox
            // 
            this.cantidadextBox.AutoSize = true;
            this.cantidadextBox.Location = new System.Drawing.Point(56, 31);
            this.cantidadextBox.Name = "cantidadextBox";
            this.cantidadextBox.Size = new System.Drawing.Size(37, 13);
            this.cantidadextBox.TabIndex = 15;
            this.cantidadextBox.Text = "Monto";
            // 
            // eliminarItemBtn
            // 
            this.eliminarItemBtn.Location = new System.Drawing.Point(568, 177);
            this.eliminarItemBtn.Name = "eliminarItemBtn";
            this.eliminarItemBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarItemBtn.TabIndex = 24;
            this.eliminarItemBtn.Text = "Eliminar";
            this.eliminarItemBtn.UseVisualStyleBackColor = true;
            this.eliminarItemBtn.Click += new System.EventHandler(this.eliminarItemBtn_Click);
            // 
            // numFactLabel2
            // 
            this.numFactLabel2.AutoSize = true;
            this.numFactLabel2.Location = new System.Drawing.Point(426, 16);
            this.numFactLabel2.Name = "numFactLabel2";
            this.numFactLabel2.Size = new System.Drawing.Size(0, 13);
            this.numFactLabel2.TabIndex = 23;
            // 
            // itemsFacturaLabel
            // 
            this.itemsFacturaLabel.AutoSize = true;
            this.itemsFacturaLabel.Location = new System.Drawing.Point(310, 16);
            this.itemsFacturaLabel.Name = "itemsFacturaLabel";
            this.itemsFacturaLabel.Size = new System.Drawing.Size(89, 13);
            this.itemsFacturaLabel.TabIndex = 22;
            this.itemsFacturaLabel.Text = "Items de Factura:";
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Location = new System.Drawing.Point(326, 177);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(100, 23);
            this.actualizarBtn.TabIndex = 21;
            this.actualizarBtn.Text = "Actualizar Tabla";
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarTablaItemsBtn_Click);
            // 
            // itemsDataGrid
            // 
            this.itemsDataGrid.AllowUserToAddRows = false;
            this.itemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGrid.Location = new System.Drawing.Point(313, 36);
            this.itemsDataGrid.Name = "itemsDataGrid";
            this.itemsDataGrid.Size = new System.Drawing.Size(346, 140);
            this.itemsDataGrid.TabIndex = 18;
            this.itemsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGrid_CellContentClick);
            this.itemsDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemsDataGrid_MouseDoubleClick_1);
            // 
            // guardarFactButton
            // 
            this.guardarFactButton.Location = new System.Drawing.Point(310, 147);
            this.guardarFactButton.Name = "guardarFactButton";
            this.guardarFactButton.Size = new System.Drawing.Size(121, 37);
            this.guardarFactButton.TabIndex = 33;
            this.guardarFactButton.Text = "Guardar Factura";
            this.guardarFactButton.UseVisualStyleBackColor = true;
            this.guardarFactButton.Click += new System.EventHandler(this.guardarFactButton_Click_1);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(600, 168);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(103, 20);
            this.totalTextBox.TabIndex = 32;
            this.totalTextBox.TextChanged += new System.EventHandler(this.totalTextBox_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(547, 171);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 31;
            this.totalLabel.Text = "Total";
            // 
            // fechaVencLabel
            // 
            this.fechaVencLabel.AutoSize = true;
            this.fechaVencLabel.Location = new System.Drawing.Point(393, 76);
            this.fechaVencLabel.Name = "fechaVencLabel";
            this.fechaVencLabel.Size = new System.Drawing.Size(113, 13);
            this.fechaVencLabel.TabIndex = 30;
            this.fechaVencLabel.Text = "Fecha de Vencimiento";
            // 
            // fechaVencDT
            // 
            this.fechaVencDT.Location = new System.Drawing.Point(521, 76);
            this.fechaVencDT.Name = "fechaVencDT";
            this.fechaVencDT.Size = new System.Drawing.Size(200, 20);
            this.fechaVencDT.TabIndex = 29;
            this.fechaVencDT.ValueChanged += new System.EventHandler(this.fechaVencDT_ValueChanged);
            // 
            // fechaAltaFactLabel
            // 
            this.fechaAltaFactLabel.AutoSize = true;
            this.fechaAltaFactLabel.Location = new System.Drawing.Point(409, 31);
            this.fechaAltaFactLabel.Name = "fechaAltaFactLabel";
            this.fechaAltaFactLabel.Size = new System.Drawing.Size(97, 13);
            this.fechaAltaFactLabel.TabIndex = 28;
            this.fechaAltaFactLabel.Text = "Fecha Alta Factura";
            // 
            // fechaAltaFactDT
            // 
            this.fechaAltaFactDT.Enabled = false;
            this.fechaAltaFactDT.Location = new System.Drawing.Point(521, 31);
            this.fechaAltaFactDT.Name = "fechaAltaFactDT";
            this.fechaAltaFactDT.Size = new System.Drawing.Size(200, 20);
            this.fechaAltaFactDT.TabIndex = 27;
            // 
            // numFactLabel
            // 
            this.numFactLabel.AutoSize = true;
            this.numFactLabel.Location = new System.Drawing.Point(63, 34);
            this.numFactLabel.Name = "numFactLabel";
            this.numFactLabel.Size = new System.Drawing.Size(98, 13);
            this.numFactLabel.TabIndex = 26;
            this.numFactLabel.Text = "Número de Factura";
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(175, 60);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(121, 21);
            this.empresaComboBox.TabIndex = 25;
            // 
            // numFactTextBox
            // 
            this.numFactTextBox.Location = new System.Drawing.Point(175, 34);
            this.numFactTextBox.Name = "numFactTextBox";
            this.numFactTextBox.Size = new System.Drawing.Size(121, 20);
            this.numFactTextBox.TabIndex = 24;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(102, 60);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaLabel.TabIndex = 23;
            this.empresaLabel.Text = "Empresa";
            // 
            // facturaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "facturaABM";
            this.Text = "ABM  Factura";
            this.Load += new System.EventHandler(this.facturaABM_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.Listado.ResumeLayout(false);
            this.Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGridL)).EndInit();
            this.filtrarGroupBox.ResumeLayout(false);
            this.filtrarGroupBox.PerformLayout();
            this.clienteGroupBox.ResumeLayout(false);
            this.clienteGroupBox.PerformLayout();
            this.ABM.ResumeLayout(false);
            this.ABM.PerformLayout();
            this.clienteGroupBox2.ResumeLayout(false);
            this.clienteGroupBox2.PerformLayout();
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Listado;
        private System.Windows.Forms.DataGridView facturasDataGridL;
        private System.Windows.Forms.TabPage ABM;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.Label numFactLabel2;
        private System.Windows.Forms.Label itemsFacturaLabel;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.DataGridView itemsDataGrid;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.Button agregarItemBtn;
        private System.Windows.Forms.TextBox cantTextBox;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label cantidadextBox;
        private System.Windows.Forms.Button guardarFactButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label fechaVencLabel;
        private System.Windows.Forms.DateTimePicker fechaVencDT;
        private System.Windows.Forms.Label fechaAltaFactLabel;
        private System.Windows.Forms.DateTimePicker fechaAltaFactDT;
        private System.Windows.Forms.Label numFactLabel;
        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.TextBox numFactTextBox;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Button limpiarBtnL;
        private System.Windows.Forms.Button eliminarBtnL;
        private System.Windows.Forms.Button eliminarItemBtn;
        private System.Windows.Forms.Label facturasLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button limpiarItemBtn;
        private System.Windows.Forms.GroupBox filtrarGroupBox;
        private System.Windows.Forms.Label numFactLabelL;
        private System.Windows.Forms.TextBox numFactFilterTextBoxL;
        private System.Windows.Forms.ComboBox empresaFilterComboBox;
        private System.Windows.Forms.Button searchBtnL;
        private System.Windows.Forms.Label empresaFilterLabel;
        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.Button seleccionarClienteBtn;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.GroupBox clienteGroupBox2;
        private System.Windows.Forms.TextBox idClienteTextBox2;
        private System.Windows.Forms.Button seleccionarBtn2;
        private System.Windows.Forms.TextBox clienteTextBox2;


    }
}