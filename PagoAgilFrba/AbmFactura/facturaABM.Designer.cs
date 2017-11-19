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
            this.clienteFilterLabel = new System.Windows.Forms.Label();
            this.clienteFilterComboBox = new System.Windows.Forms.ComboBox();
            this.limpiarBtnL = new System.Windows.Forms.Button();
            this.empresaFilterLabel = new System.Windows.Forms.Label();
            this.empresaFilterComboBox = new System.Windows.Forms.ComboBox();
            this.facturasLabel = new System.Windows.Forms.Label();
            this.eliminarBtnL = new System.Windows.Forms.Button();
            this.searchBtnL = new System.Windows.Forms.Button();
            this.facturasDataGridL = new System.Windows.Forms.DataGridView();
            this.numFactLabelL = new System.Windows.Forms.Label();
            this.numFactFilterTextBoxL = new System.Windows.Forms.TextBox();
            this.ABM = new System.Windows.Forms.TabPage();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.eliminarItemBtn = new System.Windows.Forms.Button();
            this.numFactLabel2 = new System.Windows.Forms.Label();
            this.itemsFacturaLabel = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.itemsDataGrid = new System.Windows.Forms.DataGridView();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.agregarItemBtn = new System.Windows.Forms.Button();
            this.cantTextBox = new System.Windows.Forms.TextBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadextBox = new System.Windows.Forms.Label();
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
            this.clienteLabel = new System.Windows.Forms.Label();
            this.importeCobroTextBox = new System.Windows.Forms.TextBox();
            this.cobrarBtn = new System.Windows.Forms.Button();
            this.importeFilterLabel = new System.Windows.Forms.Label();
            this.sucursalLabel = new System.Windows.Forms.Label();
            this.clienteLabel2 = new System.Windows.Forms.Label();
            this.sucursalCobroTextBox = new System.Windows.Forms.TextBox();
            this.clienteCobroTextBox = new System.Windows.Forms.TextBox();
            this.formaDePagoTextBox = new System.Windows.Forms.TextBox();
            this.formaDePagoLabel = new System.Windows.Forms.Label();
            this.fechaCobroDT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cobrarGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGridL)).BeginInit();
            this.ABM.SuspendLayout();
            this.itemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGrid)).BeginInit();
            this.cobrarGroupBox.SuspendLayout();
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
            this.Listado.Controls.Add(this.clienteFilterLabel);
            this.Listado.Controls.Add(this.clienteFilterComboBox);
            this.Listado.Controls.Add(this.limpiarBtnL);
            this.Listado.Controls.Add(this.empresaFilterLabel);
            this.Listado.Controls.Add(this.empresaFilterComboBox);
            this.Listado.Controls.Add(this.facturasLabel);
            this.Listado.Controls.Add(this.eliminarBtnL);
            this.Listado.Controls.Add(this.searchBtnL);
            this.Listado.Controls.Add(this.facturasDataGridL);
            this.Listado.Controls.Add(this.numFactLabelL);
            this.Listado.Controls.Add(this.numFactFilterTextBoxL);
            this.Listado.Controls.Add(this.cobrarGroupBox);
            this.Listado.Location = new System.Drawing.Point(4, 22);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(3);
            this.Listado.Size = new System.Drawing.Size(761, 455);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listado";
            this.Listado.UseVisualStyleBackColor = true;
            this.Listado.Click += new System.EventHandler(this.Listado_Click);
            // 
            // clienteFilterLabel
            // 
            this.clienteFilterLabel.AutoSize = true;
            this.clienteFilterLabel.Location = new System.Drawing.Point(369, 23);
            this.clienteFilterLabel.Name = "clienteFilterLabel";
            this.clienteFilterLabel.Size = new System.Drawing.Size(39, 13);
            this.clienteFilterLabel.TabIndex = 15;
            this.clienteFilterLabel.Text = "Cliente";
            // 
            // clienteFilterComboBox
            // 
            this.clienteFilterComboBox.FormattingEnabled = true;
            this.clienteFilterComboBox.Location = new System.Drawing.Point(414, 21);
            this.clienteFilterComboBox.Name = "clienteFilterComboBox";
            this.clienteFilterComboBox.Size = new System.Drawing.Size(142, 21);
            this.clienteFilterComboBox.TabIndex = 14;
            this.clienteFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.clienteFilterComboBox_SelectedIndexChanged);
            // 
            // limpiarBtnL
            // 
            this.limpiarBtnL.Location = new System.Drawing.Point(299, 400);
            this.limpiarBtnL.Name = "limpiarBtnL";
            this.limpiarBtnL.Size = new System.Drawing.Size(109, 31);
            this.limpiarBtnL.TabIndex = 4;
            this.limpiarBtnL.Text = "Limpiar";
            this.limpiarBtnL.UseVisualStyleBackColor = true;
            this.limpiarBtnL.Click += new System.EventHandler(this.limpiarBtnL_Click);
            // 
            // empresaFilterLabel
            // 
            this.empresaFilterLabel.AutoSize = true;
            this.empresaFilterLabel.Location = new System.Drawing.Point(109, 59);
            this.empresaFilterLabel.Name = "empresaFilterLabel";
            this.empresaFilterLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaFilterLabel.TabIndex = 12;
            this.empresaFilterLabel.Text = "Empresa";
            // 
            // empresaFilterComboBox
            // 
            this.empresaFilterComboBox.FormattingEnabled = true;
            this.empresaFilterComboBox.Location = new System.Drawing.Point(166, 56);
            this.empresaFilterComboBox.Name = "empresaFilterComboBox";
            this.empresaFilterComboBox.Size = new System.Drawing.Size(142, 21);
            this.empresaFilterComboBox.TabIndex = 11;
            // 
            // facturasLabel
            // 
            this.facturasLabel.AutoSize = true;
            this.facturasLabel.Location = new System.Drawing.Point(22, 92);
            this.facturasLabel.Name = "facturasLabel";
            this.facturasLabel.Size = new System.Drawing.Size(48, 13);
            this.facturasLabel.TabIndex = 6;
            this.facturasLabel.Text = "Facturas";
            // 
            // eliminarBtnL
            // 
            this.eliminarBtnL.Location = new System.Drawing.Point(626, 83);
            this.eliminarBtnL.Name = "eliminarBtnL";
            this.eliminarBtnL.Size = new System.Drawing.Size(116, 22);
            this.eliminarBtnL.TabIndex = 5;
            this.eliminarBtnL.Text = "Eliminar";
            this.eliminarBtnL.UseVisualStyleBackColor = true;
            this.eliminarBtnL.Click += new System.EventHandler(this.eliminarBtnL_Click);
            // 
            // searchBtnL
            // 
            this.searchBtnL.Location = new System.Drawing.Point(372, 48);
            this.searchBtnL.Name = "searchBtnL";
            this.searchBtnL.Size = new System.Drawing.Size(184, 29);
            this.searchBtnL.TabIndex = 3;
            this.searchBtnL.Text = "Buscar";
            this.searchBtnL.UseVisualStyleBackColor = true;
            this.searchBtnL.Click += new System.EventHandler(this.searchBtnL_Click);
            // 
            // facturasDataGridL
            // 
            this.facturasDataGridL.AllowUserToAddRows = false;
            this.facturasDataGridL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDataGridL.Location = new System.Drawing.Point(21, 108);
            this.facturasDataGridL.Name = "facturasDataGridL";
            this.facturasDataGridL.Size = new System.Drawing.Size(721, 148);
            this.facturasDataGridL.TabIndex = 2;
            this.facturasDataGridL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturasDataGrid_CellContentClick);
            this.facturasDataGridL.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.facturasDataGridL_MouseDoubleClick);
            // 
            // numFactLabelL
            // 
            this.numFactLabelL.AutoSize = true;
            this.numFactLabelL.Location = new System.Drawing.Point(61, 25);
            this.numFactLabelL.Name = "numFactLabelL";
            this.numFactLabelL.Size = new System.Drawing.Size(98, 13);
            this.numFactLabelL.TabIndex = 1;
            this.numFactLabelL.Text = "Numero de Factura";
            // 
            // numFactFilterTextBoxL
            // 
            this.numFactFilterTextBoxL.Location = new System.Drawing.Point(165, 22);
            this.numFactFilterTextBoxL.Name = "numFactFilterTextBoxL";
            this.numFactFilterTextBoxL.Size = new System.Drawing.Size(143, 20);
            this.numFactFilterTextBoxL.TabIndex = 0;
            // 
            // ABM
            // 
            this.ABM.Controls.Add(this.limpiarBtn);
            this.ABM.Controls.Add(this.clienteComboBox);
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
            this.ABM.Controls.Add(this.clienteLabel);
            this.ABM.Location = new System.Drawing.Point(4, 22);
            this.ABM.Name = "ABM";
            this.ABM.Padding = new System.Windows.Forms.Padding(3);
            this.ABM.Size = new System.Drawing.Size(761, 455);
            this.ABM.TabIndex = 1;
            this.ABM.Text = "ABM";
            this.ABM.UseVisualStyleBackColor = true;
            this.ABM.Click += new System.EventHandler(this.ABM_Click);
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
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(164, 10);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(121, 21);
            this.clienteComboBox.TabIndex = 35;
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.eliminarItemBtn);
            this.itemsGroupBox.Controls.Add(this.numFactLabel2);
            this.itemsGroupBox.Controls.Add(this.itemsFacturaLabel);
            this.itemsGroupBox.Controls.Add(this.refreshBtn);
            this.itemsGroupBox.Controls.Add(this.itemsDataGrid);
            this.itemsGroupBox.Controls.Add(this.montoTextBox);
            this.itemsGroupBox.Controls.Add(this.agregarItemBtn);
            this.itemsGroupBox.Controls.Add(this.cantTextBox);
            this.itemsGroupBox.Controls.Add(this.cantidadLabel);
            this.itemsGroupBox.Controls.Add(this.cantidadextBox);
            this.itemsGroupBox.Location = new System.Drawing.Point(44, 194);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(676, 206);
            this.itemsGroupBox.TabIndex = 34;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Items";
            // 
            // eliminarItemBtn
            // 
            this.eliminarItemBtn.Location = new System.Drawing.Point(556, 177);
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
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(337, 177);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 21;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click_1);
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
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(120, 53);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(100, 20);
            this.montoTextBox.TabIndex = 14;
            // 
            // agregarItemBtn
            // 
            this.agregarItemBtn.Location = new System.Drawing.Point(109, 139);
            this.agregarItemBtn.Name = "agregarItemBtn";
            this.agregarItemBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarItemBtn.TabIndex = 17;
            this.agregarItemBtn.Text = "Agregar Item";
            this.agregarItemBtn.UseVisualStyleBackColor = true;
            this.agregarItemBtn.Click += new System.EventHandler(this.agregarItemBtn_Click_1);
            // 
            // cantTextBox
            // 
            this.cantTextBox.Location = new System.Drawing.Point(120, 94);
            this.cantTextBox.Name = "cantTextBox";
            this.cantTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantTextBox.TabIndex = 13;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(41, 97);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(49, 13);
            this.cantidadLabel.TabIndex = 16;
            this.cantidadLabel.Text = "Cantidad";
            // 
            // cantidadextBox
            // 
            this.cantidadextBox.AutoSize = true;
            this.cantidadextBox.Location = new System.Drawing.Point(41, 53);
            this.cantidadextBox.Name = "cantidadextBox";
            this.cantidadextBox.Size = new System.Drawing.Size(37, 13);
            this.cantidadextBox.TabIndex = 15;
            this.cantidadextBox.Text = "Monto";
            // 
            // guardarFactButton
            // 
            this.guardarFactButton.Location = new System.Drawing.Point(316, 151);
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
            this.fechaVencLabel.Location = new System.Drawing.Point(392, 58);
            this.fechaVencLabel.Name = "fechaVencLabel";
            this.fechaVencLabel.Size = new System.Drawing.Size(113, 13);
            this.fechaVencLabel.TabIndex = 30;
            this.fechaVencLabel.Text = "Fecha de Vencimiento";
            // 
            // fechaVencDT
            // 
            this.fechaVencDT.Location = new System.Drawing.Point(520, 58);
            this.fechaVencDT.Name = "fechaVencDT";
            this.fechaVencDT.Size = new System.Drawing.Size(200, 20);
            this.fechaVencDT.TabIndex = 29;
            // 
            // fechaAltaFactLabel
            // 
            this.fechaAltaFactLabel.AutoSize = true;
            this.fechaAltaFactLabel.Location = new System.Drawing.Point(408, 13);
            this.fechaAltaFactLabel.Name = "fechaAltaFactLabel";
            this.fechaAltaFactLabel.Size = new System.Drawing.Size(97, 13);
            this.fechaAltaFactLabel.TabIndex = 28;
            this.fechaAltaFactLabel.Text = "Fecha Alta Factura";
            // 
            // fechaAltaFactDT
            // 
            this.fechaAltaFactDT.Location = new System.Drawing.Point(520, 13);
            this.fechaAltaFactDT.Name = "fechaAltaFactDT";
            this.fechaAltaFactDT.Size = new System.Drawing.Size(200, 20);
            this.fechaAltaFactDT.TabIndex = 27;
            // 
            // numFactLabel
            // 
            this.numFactLabel.AutoSize = true;
            this.numFactLabel.Location = new System.Drawing.Point(41, 108);
            this.numFactLabel.Name = "numFactLabel";
            this.numFactLabel.Size = new System.Drawing.Size(98, 13);
            this.numFactLabel.TabIndex = 26;
            this.numFactLabel.Text = "Numero de Factura";
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(164, 55);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(121, 21);
            this.empresaComboBox.TabIndex = 25;
            // 
            // numFactTextBox
            // 
            this.numFactTextBox.Location = new System.Drawing.Point(164, 105);
            this.numFactTextBox.Name = "numFactTextBox";
            this.numFactTextBox.Size = new System.Drawing.Size(121, 20);
            this.numFactTextBox.TabIndex = 24;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(91, 55);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaLabel.TabIndex = 23;
            this.empresaLabel.Text = "Empresa";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(100, 16);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(39, 13);
            this.clienteLabel.TabIndex = 22;
            this.clienteLabel.Text = "Cliente";
            // 
            // importeCobroTextBox
            // 
            this.importeCobroTextBox.Enabled = false;
            this.importeCobroTextBox.Location = new System.Drawing.Point(596, 26);
            this.importeCobroTextBox.Name = "importeCobroTextBox";
            this.importeCobroTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeCobroTextBox.TabIndex = 0;
            // 
            // cobrarBtn
            // 
            this.cobrarBtn.Location = new System.Drawing.Point(594, 60);
            this.cobrarBtn.Name = "cobrarBtn";
            this.cobrarBtn.Size = new System.Drawing.Size(102, 32);
            this.cobrarBtn.TabIndex = 10;
            this.cobrarBtn.Text = "Cobrar";
            this.cobrarBtn.UseVisualStyleBackColor = true;
            this.cobrarBtn.Click += new System.EventHandler(this.registrarPagoBtn_Click);
            // 
            // importeFilterLabel
            // 
            this.importeFilterLabel.AutoSize = true;
            this.importeFilterLabel.Location = new System.Drawing.Point(548, 29);
            this.importeFilterLabel.Name = "importeFilterLabel";
            this.importeFilterLabel.Size = new System.Drawing.Size(42, 13);
            this.importeFilterLabel.TabIndex = 1;
            this.importeFilterLabel.Text = "Importe";
            // 
            // sucursalLabel
            // 
            this.sucursalLabel.AutoSize = true;
            this.sucursalLabel.Location = new System.Drawing.Point(302, 29);
            this.sucursalLabel.Name = "sucursalLabel";
            this.sucursalLabel.Size = new System.Drawing.Size(51, 13);
            this.sucursalLabel.TabIndex = 14;
            this.sucursalLabel.Text = "Sucursal:";
            // 
            // clienteLabel2
            // 
            this.clienteLabel2.AutoSize = true;
            this.clienteLabel2.Location = new System.Drawing.Point(65, 70);
            this.clienteLabel2.Name = "clienteLabel2";
            this.clienteLabel2.Size = new System.Drawing.Size(42, 13);
            this.clienteLabel2.TabIndex = 18;
            this.clienteLabel2.Text = "Cliente:";
            // 
            // sucursalCobroTextBox
            // 
            this.sucursalCobroTextBox.Enabled = false;
            this.sucursalCobroTextBox.Location = new System.Drawing.Point(359, 26);
            this.sucursalCobroTextBox.Name = "sucursalCobroTextBox";
            this.sucursalCobroTextBox.Size = new System.Drawing.Size(118, 20);
            this.sucursalCobroTextBox.TabIndex = 19;
            // 
            // clienteCobroTextBox
            // 
            this.clienteCobroTextBox.Enabled = false;
            this.clienteCobroTextBox.Location = new System.Drawing.Point(132, 67);
            this.clienteCobroTextBox.Name = "clienteCobroTextBox";
            this.clienteCobroTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteCobroTextBox.TabIndex = 20;
            // 
            // formaDePagoTextBox
            // 
            this.formaDePagoTextBox.Location = new System.Drawing.Point(133, 26);
            this.formaDePagoTextBox.Name = "formaDePagoTextBox";
            this.formaDePagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.formaDePagoTextBox.TabIndex = 21;
            // 
            // formaDePagoLabel
            // 
            this.formaDePagoLabel.AutoSize = true;
            this.formaDePagoLabel.Location = new System.Drawing.Point(28, 29);
            this.formaDePagoLabel.Name = "formaDePagoLabel";
            this.formaDePagoLabel.Size = new System.Drawing.Size(79, 13);
            this.formaDePagoLabel.TabIndex = 22;
            this.formaDePagoLabel.Text = "Forma de Pago";
            // 
            // fechaCobroDT
            // 
            this.fechaCobroDT.Enabled = false;
            this.fechaCobroDT.Location = new System.Drawing.Point(359, 67);
            this.fechaCobroDT.Name = "fechaCobroDT";
            this.fechaCobroDT.Size = new System.Drawing.Size(200, 20);
            this.fechaCobroDT.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha de Cobro";
            // 
            // cobrarGroupBox
            // 
            this.cobrarGroupBox.Controls.Add(this.label1);
            this.cobrarGroupBox.Controls.Add(this.fechaCobroDT);
            this.cobrarGroupBox.Controls.Add(this.formaDePagoLabel);
            this.cobrarGroupBox.Controls.Add(this.formaDePagoTextBox);
            this.cobrarGroupBox.Controls.Add(this.clienteCobroTextBox);
            this.cobrarGroupBox.Controls.Add(this.sucursalCobroTextBox);
            this.cobrarGroupBox.Controls.Add(this.clienteLabel2);
            this.cobrarGroupBox.Controls.Add(this.sucursalLabel);
            this.cobrarGroupBox.Controls.Add(this.importeFilterLabel);
            this.cobrarGroupBox.Controls.Add(this.cobrarBtn);
            this.cobrarGroupBox.Controls.Add(this.importeCobroTextBox);
            this.cobrarGroupBox.Location = new System.Drawing.Point(21, 275);
            this.cobrarGroupBox.Name = "cobrarGroupBox";
            this.cobrarGroupBox.Size = new System.Drawing.Size(721, 101);
            this.cobrarGroupBox.TabIndex = 13;
            this.cobrarGroupBox.TabStop = false;
            this.cobrarGroupBox.Text = "Cobrar Facturas";
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
            this.ABM.ResumeLayout(false);
            this.ABM.PerformLayout();
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGrid)).EndInit();
            this.cobrarGroupBox.ResumeLayout(false);
            this.cobrarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Listado;
        private System.Windows.Forms.Button searchBtnL;
        private System.Windows.Forms.DataGridView facturasDataGridL;
        private System.Windows.Forms.Label numFactLabelL;
        private System.Windows.Forms.TextBox numFactFilterTextBoxL;
        private System.Windows.Forms.TabPage ABM;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.Label numFactLabel2;
        private System.Windows.Forms.Label itemsFacturaLabel;
        private System.Windows.Forms.Button refreshBtn;
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
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Button limpiarBtnL;
        private System.Windows.Forms.Button eliminarBtnL;
        private System.Windows.Forms.Button eliminarItemBtn;
        private System.Windows.Forms.Label facturasLabel;
        private System.Windows.Forms.Label empresaFilterLabel;
        private System.Windows.Forms.ComboBox empresaFilterComboBox;
        private System.Windows.Forms.Label clienteFilterLabel;
        private System.Windows.Forms.ComboBox clienteFilterComboBox;
        private System.Windows.Forms.GroupBox cobrarGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaCobroDT;
        private System.Windows.Forms.Label formaDePagoLabel;
        private System.Windows.Forms.TextBox formaDePagoTextBox;
        private System.Windows.Forms.TextBox clienteCobroTextBox;
        private System.Windows.Forms.TextBox sucursalCobroTextBox;
        private System.Windows.Forms.Label clienteLabel2;
        private System.Windows.Forms.Label sucursalLabel;
        private System.Windows.Forms.Label importeFilterLabel;
        private System.Windows.Forms.Button cobrarBtn;
        private System.Windows.Forms.TextBox importeCobroTextBox;


    }
}