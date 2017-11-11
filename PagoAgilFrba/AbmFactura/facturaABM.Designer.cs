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
            this.clienteLabel = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.numFactTextBox = new System.Windows.Forms.TextBox();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.numFactLabel = new System.Windows.Forms.Label();
            this.fechaAltaFactDT = new System.Windows.Forms.DateTimePicker();
            this.fechaAltaFactLabel = new System.Windows.Forms.Label();
            this.fechaVencDT = new System.Windows.Forms.DateTimePicker();
            this.fechaVencLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.guardarFactButton = new System.Windows.Forms.Button();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.descrTextBox = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.itemsDataGrid = new System.Windows.Forms.DataGridView();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.agregarItemBtn = new System.Windows.Forms.Button();
            this.cantTextBox = new System.Windows.Forms.TextBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.Label();
            this.itemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(71, 26);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(39, 13);
            this.clienteLabel.TabIndex = 0;
            this.clienteLabel.Text = "Cliente";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(135, 23);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.clienteTextBox.TabIndex = 1;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(62, 65);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaLabel.TabIndex = 2;
            this.empresaLabel.Text = "Empresa";
            // 
            // numFactTextBox
            // 
            this.numFactTextBox.Location = new System.Drawing.Point(135, 115);
            this.numFactTextBox.Name = "numFactTextBox";
            this.numFactTextBox.Size = new System.Drawing.Size(121, 20);
            this.numFactTextBox.TabIndex = 3;
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(135, 65);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(121, 21);
            this.empresaComboBox.TabIndex = 4;
            // 
            // numFactLabel
            // 
            this.numFactLabel.AutoSize = true;
            this.numFactLabel.Location = new System.Drawing.Point(12, 118);
            this.numFactLabel.Name = "numFactLabel";
            this.numFactLabel.Size = new System.Drawing.Size(98, 13);
            this.numFactLabel.TabIndex = 5;
            this.numFactLabel.Text = "Numero de Factura";
            // 
            // fechaAltaFactDT
            // 
            this.fechaAltaFactDT.Location = new System.Drawing.Point(491, 23);
            this.fechaAltaFactDT.Name = "fechaAltaFactDT";
            this.fechaAltaFactDT.Size = new System.Drawing.Size(200, 20);
            this.fechaAltaFactDT.TabIndex = 6;
            // 
            // fechaAltaFactLabel
            // 
            this.fechaAltaFactLabel.AutoSize = true;
            this.fechaAltaFactLabel.Location = new System.Drawing.Point(379, 23);
            this.fechaAltaFactLabel.Name = "fechaAltaFactLabel";
            this.fechaAltaFactLabel.Size = new System.Drawing.Size(97, 13);
            this.fechaAltaFactLabel.TabIndex = 7;
            this.fechaAltaFactLabel.Text = "Fecha Alta Factura";
            // 
            // fechaVencDT
            // 
            this.fechaVencDT.Location = new System.Drawing.Point(491, 68);
            this.fechaVencDT.Name = "fechaVencDT";
            this.fechaVencDT.Size = new System.Drawing.Size(200, 20);
            this.fechaVencDT.TabIndex = 8;
            // 
            // fechaVencLabel
            // 
            this.fechaVencLabel.AutoSize = true;
            this.fechaVencLabel.Location = new System.Drawing.Point(363, 68);
            this.fechaVencLabel.Name = "fechaVencLabel";
            this.fechaVencLabel.Size = new System.Drawing.Size(113, 13);
            this.fechaVencLabel.TabIndex = 9;
            this.fechaVencLabel.Text = "Fecha de Vencimiento";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(438, 118);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(491, 115);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(103, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // guardarFactButton
            // 
            this.guardarFactButton.Location = new System.Drawing.Point(287, 154);
            this.guardarFactButton.Name = "guardarFactButton";
            this.guardarFactButton.Size = new System.Drawing.Size(105, 29);
            this.guardarFactButton.TabIndex = 18;
            this.guardarFactButton.Text = "Guardar Factura";
            this.guardarFactButton.UseVisualStyleBackColor = true;
            this.guardarFactButton.Click += new System.EventHandler(this.guardarFactButton_Click);
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.descrTextBox);
            this.itemsGroupBox.Controls.Add(this.descripcionLabel);
            this.itemsGroupBox.Controls.Add(this.itemsDataGrid);
            this.itemsGroupBox.Controls.Add(this.montoTextBox);
            this.itemsGroupBox.Controls.Add(this.agregarItemBtn);
            this.itemsGroupBox.Controls.Add(this.cantTextBox);
            this.itemsGroupBox.Controls.Add(this.cantidadLabel);
            this.itemsGroupBox.Controls.Add(this.cantidadTextBox);
            this.itemsGroupBox.Location = new System.Drawing.Point(15, 204);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(676, 206);
            this.itemsGroupBox.TabIndex = 19;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Items";
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
            this.itemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGrid.Location = new System.Drawing.Point(313, 19);
            this.itemsDataGrid.Name = "itemsDataGrid";
            this.itemsDataGrid.Size = new System.Drawing.Size(346, 181);
            this.itemsDataGrid.TabIndex = 18;
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(120, 112);
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
            this.agregarItemBtn.Click += new System.EventHandler(this.agregarItemBtn_Click);
            // 
            // cantTextBox
            // 
            this.cantTextBox.Location = new System.Drawing.Point(120, 72);
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
            // cantidadTextBox
            // 
            this.cantidadTextBox.AutoSize = true;
            this.cantidadTextBox.Location = new System.Drawing.Point(41, 75);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(37, 13);
            this.cantidadTextBox.TabIndex = 15;
            this.cantidadTextBox.Text = "Monto";
            // 
            // facturaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 422);
            this.Controls.Add(this.itemsGroupBox);
            this.Controls.Add(this.guardarFactButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.fechaVencLabel);
            this.Controls.Add(this.fechaVencDT);
            this.Controls.Add(this.fechaAltaFactLabel);
            this.Controls.Add(this.fechaAltaFactDT);
            this.Controls.Add(this.numFactLabel);
            this.Controls.Add(this.empresaComboBox);
            this.Controls.Add(this.numFactTextBox);
            this.Controls.Add(this.empresaLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.clienteLabel);
            this.Name = "facturaABM";
            this.Text = "ABM  Factura";
            this.Load += new System.EventHandler(this.facturaABM_Load_1);
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.TextBox numFactTextBox;
        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.Label numFactLabel;
        private System.Windows.Forms.DateTimePicker fechaAltaFactDT;
        private System.Windows.Forms.Label fechaAltaFactLabel;
        private System.Windows.Forms.DateTimePicker fechaVencDT;
        private System.Windows.Forms.Label fechaVencLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button guardarFactButton;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.DataGridView itemsDataGrid;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.Button agregarItemBtn;
        private System.Windows.Forms.TextBox cantTextBox;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label cantidadTextBox;
        private System.Windows.Forms.TextBox descrTextBox;
        private System.Windows.Forms.Label descripcionLabel;

    }
}