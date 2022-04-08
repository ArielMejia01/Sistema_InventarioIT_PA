
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ibEstanteIzquierdo = new FontAwesome.Sharp.IconButton();
            this.ibEstanteCentro = new FontAwesome.Sharp.IconButton();
            this.ibUbicación = new FontAwesome.Sharp.IconButton();
            this.ibPlaza = new FontAwesome.Sharp.IconButton();
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
            this.panelLateral.Controls.Add(this.ibPlaza);
            this.panelLateral.Controls.Add(this.ibUbicación);
            this.panelLateral.Controls.Add(this.ibEstanteCentro);
            this.panelLateral.Controls.Add(this.ibEstanteIzquierdo);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(180, 439);
            this.panelLateral.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 87);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 25);
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
            // ibEstanteIzquierdo
            // 
            this.ibEstanteIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibEstanteIzquierdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibEstanteIzquierdo.FlatAppearance.BorderSize = 0;
            this.ibEstanteIzquierdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEstanteIzquierdo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibEstanteIzquierdo.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.ibEstanteIzquierdo.IconColor = System.Drawing.Color.White;
            this.ibEstanteIzquierdo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEstanteIzquierdo.IconSize = 26;
            this.ibEstanteIzquierdo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEstanteIzquierdo.Location = new System.Drawing.Point(0, 87);
            this.ibEstanteIzquierdo.Name = "ibEstanteIzquierdo";
            this.ibEstanteIzquierdo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibEstanteIzquierdo.Size = new System.Drawing.Size(180, 45);
            this.ibEstanteIzquierdo.TabIndex = 1;
            this.ibEstanteIzquierdo.Text = "Icono Estante Izquierdo";
            this.ibEstanteIzquierdo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEstanteIzquierdo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibEstanteIzquierdo.UseVisualStyleBackColor = false;
            this.ibEstanteIzquierdo.Click += new System.EventHandler(this.ibEstanteIzquierdo_Click);
            // 
            // ibEstanteCentro
            // 
            this.ibEstanteCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibEstanteCentro.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibEstanteCentro.FlatAppearance.BorderSize = 0;
            this.ibEstanteCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEstanteCentro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibEstanteCentro.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.ibEstanteCentro.IconColor = System.Drawing.Color.White;
            this.ibEstanteCentro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEstanteCentro.IconSize = 26;
            this.ibEstanteCentro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEstanteCentro.Location = new System.Drawing.Point(0, 132);
            this.ibEstanteCentro.Name = "ibEstanteCentro";
            this.ibEstanteCentro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibEstanteCentro.Size = new System.Drawing.Size(180, 45);
            this.ibEstanteCentro.TabIndex = 8;
            this.ibEstanteCentro.Text = "Icono Estante Centro";
            this.ibEstanteCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEstanteCentro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibEstanteCentro.UseVisualStyleBackColor = false;
            // 
            // ibUbicación
            // 
            this.ibUbicación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibUbicación.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibUbicación.FlatAppearance.BorderSize = 0;
            this.ibUbicación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibUbicación.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibUbicación.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.ibUbicación.IconColor = System.Drawing.Color.White;
            this.ibUbicación.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibUbicación.IconSize = 26;
            this.ibUbicación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibUbicación.Location = new System.Drawing.Point(0, 177);
            this.ibUbicación.Name = "ibUbicación";
            this.ibUbicación.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibUbicación.Size = new System.Drawing.Size(180, 45);
            this.ibUbicación.TabIndex = 9;
            this.ibUbicación.Text = "Icono Ubicación";
            this.ibUbicación.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibUbicación.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibUbicación.UseVisualStyleBackColor = false;
            this.ibUbicación.Click += new System.EventHandler(this.ibUbicación_Click);
            // 
            // ibPlaza
            // 
            this.ibPlaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibPlaza.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibPlaza.FlatAppearance.BorderSize = 0;
            this.ibPlaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibPlaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibPlaza.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.ibPlaza.IconColor = System.Drawing.Color.White;
            this.ibPlaza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibPlaza.IconSize = 25;
            this.ibPlaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibPlaza.Location = new System.Drawing.Point(0, 222);
            this.ibPlaza.Name = "ibPlaza";
            this.ibPlaza.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibPlaza.Size = new System.Drawing.Size(180, 45);
            this.ibPlaza.TabIndex = 10;
            this.ibPlaza.Text = "Icono Plaza";
            this.ibPlaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibPlaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibPlaza.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 439);
            this.Controls.Add(this.panelInventario);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton ibEstanteIzquierdo;
        private FontAwesome.Sharp.IconButton ibPlaza;
        private FontAwesome.Sharp.IconButton ibUbicación;
        private FontAwesome.Sharp.IconButton ibEstanteCentro;
    }
}

