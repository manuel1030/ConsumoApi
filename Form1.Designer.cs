namespace ConsumoApi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusurs = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusurs
            // 
            this.txtusurs.Location = new System.Drawing.Point(12, 12);
            this.txtusurs.Name = "txtusurs";
            this.txtusurs.Size = new System.Drawing.Size(177, 20);
            this.txtusurs.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(12, 54);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(177, 20);
            this.txtpass.TabIndex = 1;
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(114, 137);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 23);
            this.btniniciar.TabIndex = 2;
            this.btniniciar.Text = "iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 53);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusurs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusurs;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Label label1;
    }
}

