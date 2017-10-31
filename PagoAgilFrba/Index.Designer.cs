namespace PagoAgilFrba
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ABMClienteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABMClienteBtn
            // 
            this.ABMClienteBtn.Location = new System.Drawing.Point(27, 12);
            this.ABMClienteBtn.Name = "ABMClienteBtn";
            this.ABMClienteBtn.Size = new System.Drawing.Size(218, 47);
            this.ABMClienteBtn.TabIndex = 0;
            this.ABMClienteBtn.Text = "ABM Cliente";
            this.ABMClienteBtn.UseVisualStyleBackColor = true;
            this.ABMClienteBtn.Click += new System.EventHandler(this.ABMClienteBtn_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 317);
            this.Controls.Add(this.ABMClienteBtn);
            this.Name = "Index";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ABMClienteBtn;
    }
}

