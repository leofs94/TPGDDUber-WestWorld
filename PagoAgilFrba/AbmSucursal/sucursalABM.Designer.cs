namespace PagoAgilFrba.AbmSucursal
{
    partial class sucursalABM
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
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoPostalTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sucursalDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.apellidoFilterTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreFilterTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.habilitadoCheck = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.codigoPostalFilterTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(421, 30);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(121, 20);
            this.direccionTextBox.TabIndex = 11;
            this.direccionTextBox.TextChanged += new System.EventHandler(this.direccionTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(125, 33);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 10;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // codigoPostalTxtBox
            // 
            this.codigoPostalTxtBox.Location = new System.Drawing.Point(125, 87);
            this.codigoPostalTxtBox.Name = "codigoPostalTxtBox";
            this.codigoPostalTxtBox.Size = new System.Drawing.Size(48, 20);
            this.codigoPostalTxtBox.TabIndex = 17;
            this.codigoPostalTxtBox.TextChanged += new System.EventHandler(this.codigoPostalTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Codigo Postal";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(702, 213);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 23);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sucursalDataGrid
            // 
            this.sucursalDataGrid.AllowUserToAddRows = false;
            this.sucursalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalDataGrid.Location = new System.Drawing.Point(76, 253);
            this.sucursalDataGrid.Name = "sucursalDataGrid";
            this.sucursalDataGrid.Size = new System.Drawing.Size(623, 150);
            this.sucursalDataGrid.TabIndex = 36;
            this.sucursalDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sucursalDataGrid_CellContentClick);
            this.sucursalDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sucursalDataGrid_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Codigo Postal";
            // 
            // apellidoFilterTxt
            // 
            this.apellidoFilterTxt.Location = new System.Drawing.Point(311, 215);
            this.apellidoFilterTxt.Name = "apellidoFilterTxt";
            this.apellidoFilterTxt.Size = new System.Drawing.Size(100, 20);
            this.apellidoFilterTxt.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Direccion";
            // 
            // nombreFilterTxt
            // 
            this.nombreFilterTxt.Location = new System.Drawing.Point(123, 216);
            this.nombreFilterTxt.Name = "nombreFilterTxt";
            this.nombreFilterTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreFilterTxt.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Filtrar";
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(137, 426);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 28;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // habilitadoCheck
            // 
            this.habilitadoCheck.AutoSize = true;
            this.habilitadoCheck.Location = new System.Drawing.Point(123, 138);
            this.habilitadoCheck.Name = "habilitadoCheck";
            this.habilitadoCheck.Size = new System.Drawing.Size(15, 14);
            this.habilitadoCheck.TabIndex = 40;
            this.habilitadoCheck.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Habilitado";
            // 
            // codigoPostalFilterTxtBox
            // 
            this.codigoPostalFilterTxtBox.Location = new System.Drawing.Point(544, 215);
            this.codigoPostalFilterTxtBox.Name = "codigoPostalFilterTxtBox";
            this.codigoPostalFilterTxtBox.Size = new System.Drawing.Size(122, 20);
            this.codigoPostalFilterTxtBox.TabIndex = 41;
            this.codigoPostalFilterTxtBox.TextChanged += new System.EventHandler(this.codigoPostalFilterTextBox_TextChanged);
            // 
            // sucursalABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 474);
            this.Controls.Add(this.codigoPostalFilterTxtBox);
            this.Controls.Add(this.habilitadoCheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sucursalDataGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.apellidoFilterTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombreFilterTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.codigoPostalTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "sucursalABM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sucursalABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoPostalTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView sucursalDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox apellidoFilterTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombreFilterTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.CheckBox habilitadoCheck;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox codigoPostalFilterTxtBox;
    }
}