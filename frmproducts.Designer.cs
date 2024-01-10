namespace ConsumoApi
{
    partial class frmproducts
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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dgproducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgproducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(9, 20);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(183, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(214, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(295, 20);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // dgproducts
            // 
            this.dgproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgproducts.Location = new System.Drawing.Point(0, 0);
            this.dgproducts.Name = "dgproducts";
            this.dgproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgproducts.Size = new System.Drawing.Size(436, 455);
            this.dgproducts.TabIndex = 4;
            this.dgproducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgproducts_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 56);
            this.panel1.TabIndex = 5;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(376, 20);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Editar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgproducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 455);
            this.panel2.TabIndex = 6;
            // 
            // frmproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmproducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmproducs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmproducs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgproducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dgproducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
    }
}