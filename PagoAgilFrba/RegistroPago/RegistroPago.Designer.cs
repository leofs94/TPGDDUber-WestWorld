namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPago
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
            this.numFacturaTextBox = new System.Windows.Forms.TextBox();
            this.numFacturaLabel = new System.Windows.Forms.Label();
            this.fechaDeCobroLabel = new System.Windows.Forms.Label();
            this.systemFechaComboBox = new System.Windows.Forms.DateTimePicker();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.fechaVencFactLabel = new System.Windows.Forms.Label();
            this.fechaVencFactComboBox = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.importeLabel = new System.Windows.Forms.Label();
            this.sucursalLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numFacturaTextBox
            // 
            this.numFacturaTextBox.Location = new System.Drawing.Point(126, 29);
            this.numFacturaTextBox.Name = "numFacturaTextBox";
            this.numFacturaTextBox.Size = new System.Drawing.Size(127, 20);
            this.numFacturaTextBox.TabIndex = 0;
            this.numFacturaTextBox.TextChanged += new System.EventHandler(this.numFacturaTextBox_TextChanged);
            // 
            // numFacturaLabel
            // 
            this.numFacturaLabel.AutoSize = true;
            this.numFacturaLabel.Location = new System.Drawing.Point(12, 32);
            this.numFacturaLabel.Name = "numFacturaLabel";
            this.numFacturaLabel.Size = new System.Drawing.Size(98, 13);
            this.numFacturaLabel.TabIndex = 1;
            this.numFacturaLabel.Text = "Numero de Factura";
            this.numFacturaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // fechaDeCobroLabel
            // 
            this.fechaDeCobroLabel.AutoSize = true;
            this.fechaDeCobroLabel.Location = new System.Drawing.Point(12, 74);
            this.fechaDeCobroLabel.Name = "fechaDeCobroLabel";
            this.fechaDeCobroLabel.Size = new System.Drawing.Size(83, 13);
            this.fechaDeCobroLabel.TabIndex = 2;
            this.fechaDeCobroLabel.Text = "Fecha de Cobro";
            // 
            // systemFechaComboBox
            // 
            this.systemFechaComboBox.Location = new System.Drawing.Point(126, 71);
            this.systemFechaComboBox.Name = "systemFechaComboBox";
            this.systemFechaComboBox.Size = new System.Drawing.Size(200, 20);
            this.systemFechaComboBox.TabIndex = 17;
            this.systemFechaComboBox.ValueChanged += new System.EventHandler(this.systemFechaComboBox_ValueChanged_1);
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(503, 29);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(137, 21);
            this.empresaComboBox.TabIndex = 18;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(414, 32);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaLabel.TabIndex = 19;
            this.empresaLabel.Text = "Empresa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(503, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(413, 77);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(39, 13);
            this.clienteLabel.TabIndex = 21;
            this.clienteLabel.Text = "Cliente";
            // 
            // fechaVencFactLabel
            // 
            this.fechaVencFactLabel.AutoSize = true;
            this.fechaVencFactLabel.Location = new System.Drawing.Point(12, 124);
            this.fechaVencFactLabel.Name = "fechaVencFactLabel";
            this.fechaVencFactLabel.Size = new System.Drawing.Size(113, 13);
            this.fechaVencFactLabel.TabIndex = 22;
            this.fechaVencFactLabel.Text = "Fecha de Vencimiento";
            this.fechaVencFactLabel.Click += new System.EventHandler(this.fechaVencFactLabel_Click);
            // 
            // fechaVencFactComboBox
            // 
            this.fechaVencFactComboBox.Location = new System.Drawing.Point(128, 124);
            this.fechaVencFactComboBox.Name = "fechaVencFactComboBox";
            this.fechaVencFactComboBox.Size = new System.Drawing.Size(200, 20);
            this.fechaVencFactComboBox.TabIndex = 23;
            this.fechaVencFactComboBox.ValueChanged += new System.EventHandler(this.fechaVencFact_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 24;
            // 
            // importeLabel
            // 
            this.importeLabel.AutoSize = true;
            this.importeLabel.Location = new System.Drawing.Point(12, 171);
            this.importeLabel.Name = "importeLabel";
            this.importeLabel.Size = new System.Drawing.Size(42, 13);
            this.importeLabel.TabIndex = 25;
            this.importeLabel.Text = "Importe";
            // 
            // sucursalLabel
            // 
            this.sucursalLabel.AutoSize = true;
            this.sucursalLabel.Location = new System.Drawing.Point(414, 124);
            this.sucursalLabel.Name = "sucursalLabel";
            this.sucursalLabel.Size = new System.Drawing.Size(48, 13);
            this.sucursalLabel.TabIndex = 26;
            this.sucursalLabel.Text = "Sucursal";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 27;
            // 
            // RegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 224);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sucursalLabel);
            this.Controls.Add(this.importeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fechaVencFactComboBox);
            this.Controls.Add(this.fechaVencFactLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.empresaLabel);
            this.Controls.Add(this.empresaComboBox);
            this.Controls.Add(this.systemFechaComboBox);
            this.Controls.Add(this.fechaDeCobroLabel);
            this.Controls.Add(this.numFacturaLabel);
            this.Controls.Add(this.numFacturaTextBox);
            this.Name = "RegistroPago";
            this.Text = "Registro de Pago";
            this.Load += new System.EventHandler(this.RegistroPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numFacturaTextBox;
        private System.Windows.Forms.Label numFacturaLabel;
        private System.Windows.Forms.Label fechaDeCobroLabel;
        private System.Windows.Forms.DateTimePicker systemFechaComboBox;
        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label fechaVencFactLabel;
        private System.Windows.Forms.DateTimePicker fechaVencFactComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label importeLabel;
        private System.Windows.Forms.Label sucursalLabel;
        private System.Windows.Forms.TextBox textBox2;
    }
}