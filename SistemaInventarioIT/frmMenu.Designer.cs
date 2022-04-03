
namespace SistemaInventarioIT
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnEstanteCentro = new System.Windows.Forms.Button();
            this.btnEstanteIzquierdo = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlaza = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.panelLateral.Controls.Add(this.btnPlaza);
            this.panelLateral.Controls.Add(this.btnUbicacion);
            this.panelLateral.Controls.Add(this.btnEstanteCentro);
            this.panelLateral.Controls.Add(this.btnEstanteIzquierdo);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(180, 439);
            this.panelLateral.TabIndex = 0;
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUbicacion.FlatAppearance.BorderSize = 0;
            this.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUbicacion.Location = new System.Drawing.Point(0, 160);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUbicacion.Size = new System.Drawing.Size(180, 30);
            this.btnUbicacion.TabIndex = 6;
            this.btnUbicacion.Text = "Ubicación";
            this.btnUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnEstanteCentro
            // 
            this.btnEstanteCentro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstanteCentro.FlatAppearance.BorderSize = 0;
            this.btnEstanteCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstanteCentro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstanteCentro.Location = new System.Drawing.Point(0, 130);
            this.btnEstanteCentro.Name = "btnEstanteCentro";
            this.btnEstanteCentro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstanteCentro.Size = new System.Drawing.Size(180, 30);
            this.btnEstanteCentro.TabIndex = 4;
            this.btnEstanteCentro.Text = "Estante Centro";
            this.btnEstanteCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstanteCentro.UseVisualStyleBackColor = true;
            this.btnEstanteCentro.Click += new System.EventHandler(this.btnEstanteCentro_Click);
            // 
            // btnEstanteIzquierdo
            // 
            this.btnEstanteIzquierdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstanteIzquierdo.FlatAppearance.BorderSize = 0;
            this.btnEstanteIzquierdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstanteIzquierdo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstanteIzquierdo.Location = new System.Drawing.Point(0, 100);
            this.btnEstanteIzquierdo.Name = "btnEstanteIzquierdo";
            this.btnEstanteIzquierdo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstanteIzquierdo.Size = new System.Drawing.Size(180, 30);
            this.btnEstanteIzquierdo.TabIndex = 2;
            this.btnEstanteIzquierdo.Text = "Estante Izquierdo";
            this.btnEstanteIzquierdo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstanteIzquierdo.UseVisualStyleBackColor = true;
            this.btnEstanteIzquierdo.Click += new System.EventHandler(this.btnEstanteIzquierdo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelInventario
            // 
            this.panelInventario.Controls.Add(this.pictureBox1);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventario.Location = new System.Drawing.Point(180, 0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(688, 439);
            this.panelInventario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlaza
            // 
            this.btnPlaza.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaza.FlatAppearance.BorderSize = 0;
            this.btnPlaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlaza.Location = new System.Drawing.Point(0, 190);
            this.btnPlaza.Name = "btnPlaza";
            this.btnPlaza.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlaza.Size = new System.Drawing.Size(180, 30);
            this.btnPlaza.TabIndex = 7;
            this.btnPlaza.Text = "Plaza";
            this.btnPlaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaza.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 439);
            this.Controls.Add(this.panelInventario);
            this.Controls.Add(this.panelLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnEstanteIzquierdo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnEstanteCentro;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPlaza;
    }
}

