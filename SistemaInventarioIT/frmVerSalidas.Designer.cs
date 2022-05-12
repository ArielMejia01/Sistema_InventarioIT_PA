
namespace SistemaInventarioIT
{
    partial class frmVerSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerSalidas));
            this.label1 = new System.Windows.Forms.Label();
            this.ibRegresar = new FontAwesome.Sharp.IconButton();
            this.dgVerSalidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE SALIDAS";
            // 
            // ibRegresar
            // 
            this.ibRegresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibRegresar.IconColor = System.Drawing.Color.Black;
            this.ibRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibRegresar.Location = new System.Drawing.Point(55, 382);
            this.ibRegresar.Name = "ibRegresar";
            this.ibRegresar.Size = new System.Drawing.Size(102, 40);
            this.ibRegresar.TabIndex = 1;
            this.ibRegresar.Text = "Regresar";
            this.ibRegresar.UseVisualStyleBackColor = true;
            this.ibRegresar.Click += new System.EventHandler(this.ibRegresar_Click);
            // 
            // dgVerSalidas
            // 
            this.dgVerSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVerSalidas.Location = new System.Drawing.Point(70, 118);
            this.dgVerSalidas.Name = "dgVerSalidas";
            this.dgVerSalidas.Size = new System.Drawing.Size(517, 142);
            this.dgVerSalidas.TabIndex = 2;
            // 
            // frmVerSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 466);
            this.Controls.Add(this.dgVerSalidas);
            this.Controls.Add(this.ibRegresar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.frmVerSalidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVerSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibRegresar;
        private System.Windows.Forms.DataGridView dgVerSalidas;
    }
}