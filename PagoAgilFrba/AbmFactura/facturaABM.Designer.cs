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
            this.searchBtnL = new System.Windows.Forms.Button();
            this.facturasDataGridL = new System.Windows.Forms.DataGridView();
            this.numFactLabelL = new System.Windows.Forms.Label();
            this.numFactFilterTextBoxL = new System.Windows.Forms.TextBox();
            this.ABM = new System.Windows.Forms.TabPage();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.numFactLabel2 = new System.Windows.Forms.Label();
            this.itemsFacturaLabel = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.descrTextBox = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
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
            this.limpariBtnL = new System.Windows.Forms.Button();
            this.eliminarBtnL = new System.Windows.Forms.Button();
            this.eliminarItemBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataGridL)).BeginInit();
            this.ABM.SuspendLayout();
            this.itemsGroupBox.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(768, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.eliminarBtnL);
            this.Listado.Controls.Add(this.limpariBtnL);
            this.Listado.Controls.Add(this.searchBtnL);
            this.Listado.Controls.Add(this.facturasDataGridL);
            this.Listado.Controls.Add(this.numFactLabelL);
            this.Listado.Controls.Add(this.numFactFilterTextBoxL);
            this.Listado.Location = new System.Drawing.Point(4, 22);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(3);
            this.Listado.Size = new System.Drawing.Size(760, 455);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listado";
            this.Listado.UseVisualStyleBackColor = true;
            // 
            // searchBtnL
            // 
            this.searchBtnL.Location = new System.Drawing.Point(514, 36);
            this.searchBtnL.Name = "searchBtnL";
            this.searchBtnL.Size = new System.Drawing.Size(125, 35);
            this.searchBtnL.TabIndex = 3;
            this.searchBtnL.Text = "Buscar";
            this.searchBtnL.UseVisualStyleBackColor = true;
            this.searchBtnL.Click += new System.EventHandler(this.searchBtnL_Click);
            // 
            // facturasDataGridL
            // 
            this.facturasDataGridL.AllowUserToAddRows = false;
            this.facturasDataGridL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDataGridL.Location = new System.Drawing.Point(21, 89);
            this.facturasDataGridL.Name = "facturasDataGridL";
            this.facturasDataGridL.Size = new System.Drawing.Size(721, 244);
            this.facturasDataGridL.TabIndex = 2;
            this.facturasDataGridL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturasDataGrid_CellContentClick);
            this.facturasDataGridL.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.facturasDataGridL_MouseDoubleClick);
            // 
            // numFactLabelL
            // 
            this.numFactLabelL.AutoSize = true;
            this.numFactLabelL.Location = new System.Drawing.Point(18, 44);
            this.numFactLabelL.Name = "numFactLabelL";
            this.numFactLabelL.Size = new System.Drawing.Size(98, 13);
            this.numFactLabelL.TabIndex = 1;
            this.numFactLabelL.Text = "Numero de Factura";
            // 
            // numFactFilterTextBoxL
            // 
            this.numFactFilterTextBoxL.Location = new System.Drawing.Point(141, 44);
            this.numFactFilterTextBoxL.Name = "numFactFilterTextBoxL";
            this.numFactFilterTextBoxL.Size = new System.Drawing.Size(122, 20);
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
            this.ABM.Size = new System.Drawing.Size(760, 455);
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
            this.itemsGroupBox.Controls.Add(this.descrTextBox);
            this.itemsGroupBox.Controls.Add(this.descripcionLabel);
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
            // descrTextBox
            // 
            this.descrTextBox.Location = new System.Drawing.Point(120, 33);
            this.descrTextBox.Name = "descrTextBox";
            this.descrTextBox.Size = new System.Drawing.Size(100, 20);
            this.descrTextBox.TabIndex = 20;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(41, 36);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.descripcionLabel.TabIndex = 19;
            this.descripcionLabel.Text = "Descripcion";
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
            this.montoTextBox.Location = new System.Drawing.Point(120, 75);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(100, 20);
            this.montoTextBox.TabIndex = 14;
            // 
            // agregarItemBtn
            // 
            this.agregarItemBtn.Location = new System.Drawing.Point(109, 161);
            this.agregarItemBtn.Name = "agregarItemBtn";
            this.agregarItemBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarItemBtn.TabIndex = 17;
            this.agregarItemBtn.Text = "Agregar Item";
            this.agregarItemBtn.UseVisualStyleBackColor = true;
            this.agregarItemBtn.Click += new System.EventHandler(this.agregarItemBtn_Click_1);
            // 
            // cantTextBox
            // 
            this.cantTextBox.Location = new System.Drawing.Point(120, 116);
            this.cantTextBox.Name = "cantTextBox";
            this.cantTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantTextBox.TabIndex = 13;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(41, 119);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(49, 13);
            this.cantidadLabel.TabIndex = 16;
            this.cantidadLabel.Text = "Cantidad";
            // 
            // cantidadextBox
            // 
            this.cantidadextBox.AutoSize = true;
            this.cantidadextBox.Location = new System.Drawing.Point(41, 75);
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
            // limpariBtnL
            // 
            this.limpariBtnL.Location = new System.Drawing.Point(154, 351);
            this.limpariBtnL.Name = "limpariBtnL";
            this.limpariBtnL.Size = new System.Drawing.Size(109, 31);
            this.limpariBtnL.TabIndex = 4;
            this.limpariBtnL.Text = "Limpiar";
            this.limpariBtnL.UseVisualStyleBackColor = true;
            this.limpariBtnL.Click += new System.EventHandler(this.limpariBtnL_Click);
            // 
            // eliminarBtnL
            // 
            this.eliminarBtnL.Location = new System.Drawing.Point(447, 351);
            this.eliminarBtnL.Name = "eliminarBtnL";
            this.eliminarBtnL.Size = new System.Drawing.Size(116, 31);
            this.eliminarBtnL.TabIndex = 5;
            this.eliminarBtnL.Text = "Eliminar";
            this.eliminarBtnL.UseVisualStyleBackColor = true;
            this.eliminarBtnL.Click += new System.EventHandler(this.eliminarBtnL_Click);
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
            // facturaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 519);
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
        private System.Windows.Forms.TextBox descrTextBox;
        private System.Windows.Forms.Label descripcionLabel;
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
        private System.Windows.Forms.Button limpariBtnL;
        private System.Windows.Forms.Button eliminarBtnL;
        private System.Windows.Forms.Button eliminarItemBtn;


    }
}