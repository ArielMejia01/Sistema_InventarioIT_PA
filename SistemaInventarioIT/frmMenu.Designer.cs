
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
            this.ibReporte = new FontAwesome.Sharp.IconButton();
            this.ibEstado = new FontAwesome.Sharp.IconButton();
            this.ibCategoria = new FontAwesome.Sharp.IconButton();
            this.ibPlaza = new FontAwesome.Sharp.IconButton();
            this.ibUbicación = new FontAwesome.Sharp.IconButton();
            this.ibSalida = new FontAwesome.Sharp.IconButton();
            this.ibInventario = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panelLateral.Controls.Add(this.ibReporte);
            this.panelLateral.Controls.Add(this.ibEstado);
            this.panelLateral.Controls.Add(this.ibCategoria);
            this.panelLateral.Controls.Add(this.ibPlaza);
            this.panelLateral.Controls.Add(this.ibUbicación);
            this.panelLateral.Controls.Add(this.ibSalida);
            this.panelLateral.Controls.Add(this.ibInventario);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(180, 476);
            this.panelLateral.TabIndex = 0;
            // 
            // ibReporte
            // 
            this.ibReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibReporte.FlatAppearance.BorderSize = 0;
            this.ibReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibReporte.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibReporte.IconColor = System.Drawing.Color.White;
            this.ibReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibReporte.IconSize = 25;
            this.ibReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibReporte.Location = new System.Drawing.Point(0, 357);
            this.ibReporte.Name = "ibReporte";
            this.ibReporte.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibReporte.Size = new System.Drawing.Size(180, 45);
            this.ibReporte.TabIndex = 13;
            this.ibReporte.Text = "Reporte";
            this.ibReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibReporte.UseVisualStyleBackColor = false;
            this.ibReporte.Click += new System.EventHandler(this.ibReporte_Click);
            // 
            // ibEstado
            // 
            this.ibEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibEstado.FlatAppearance.BorderSize = 0;
            this.ibEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibEstado.IconChar = FontAwesome.Sharp.IconChar.WaveSquare;
            this.ibEstado.IconColor = System.Drawing.Color.White;
            this.ibEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEstado.IconSize = 25;
            this.ibEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEstado.Location = new System.Drawing.Point(0, 312);
            this.ibEstado.Name = "ibEstado";
            this.ibEstado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibEstado.Size = new System.Drawing.Size(180, 45);
            this.ibEstado.TabIndex = 12;
            this.ibEstado.Text = "Estado";
            this.ibEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibEstado.UseVisualStyleBackColor = false;
            this.ibEstado.Click += new System.EventHandler(this.ibEstado_Click);
            // 
            // ibCategoria
            // 
            this.ibCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibCategoria.FlatAppearance.BorderSize = 0;
            this.ibCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibCategoria.IconChar = FontAwesome.Sharp.IconChar.Shapes;
            this.ibCategoria.IconColor = System.Drawing.Color.White;
            this.ibCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCategoria.IconSize = 25;
            this.ibCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibCategoria.Location = new System.Drawing.Point(0, 267);
            this.ibCategoria.Name = "ibCategoria";
            this.ibCategoria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibCategoria.Size = new System.Drawing.Size(180, 45);
            this.ibCategoria.TabIndex = 11;
            this.ibCategoria.Text = "Categoria";
            this.ibCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibCategoria.UseVisualStyleBackColor = false;
            this.ibCategoria.Click += new System.EventHandler(this.ibCategoria_Click);
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
            this.ibPlaza.Text = "Plaza";
            this.ibPlaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibPlaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibPlaza.UseVisualStyleBackColor = false;
            this.ibPlaza.Click += new System.EventHandler(this.ibPlaza_Click);
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
            this.ibUbicación.IconSize = 24;
            this.ibUbicación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibUbicación.Location = new System.Drawing.Point(0, 177);
            this.ibUbicación.Name = "ibUbicación";
            this.ibUbicación.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibUbicación.Size = new System.Drawing.Size(180, 45);
            this.ibUbicación.TabIndex = 9;
            this.ibUbicación.Text = "Ubicación";
            this.ibUbicación.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibUbicación.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibUbicación.UseVisualStyleBackColor = false;
            this.ibUbicación.Click += new System.EventHandler(this.ibUbicación_Click);
            // 
            // ibSalida
            // 
            this.ibSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibSalida.FlatAppearance.BorderSize = 0;
            this.ibSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSalida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibSalida.IconChar = FontAwesome.Sharp.IconChar.Directions;
            this.ibSalida.IconColor = System.Drawing.Color.White;
            this.ibSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSalida.IconSize = 26;
            this.ibSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSalida.Location = new System.Drawing.Point(0, 132);
            this.ibSalida.Name = "ibSalida";
            this.ibSalida.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibSalida.Size = new System.Drawing.Size(180, 45);
            this.ibSalida.TabIndex = 8;
            this.ibSalida.Text = "Salidas";
            this.ibSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSalida.UseVisualStyleBackColor = false;
            this.ibSalida.Click += new System.EventHandler(this.ibEstanteCentro_Click);
            // 
            // ibInventario
            // 
            this.ibInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.ibInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibInventario.FlatAppearance.BorderSize = 0;
            this.ibInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibInventario.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.ibInventario.IconColor = System.Drawing.Color.White;
            this.ibInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibInventario.IconSize = 26;
            this.ibInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibInventario.Location = new System.Drawing.Point(0, 87);
            this.ibInventario.Name = "ibInventario";
            this.ibInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibInventario.Size = new System.Drawing.Size(180, 45);
            this.ibInventario.TabIndex = 1;
            this.ibInventario.Text = "Inventario";
            this.ibInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibInventario.UseVisualStyleBackColor = false;
            this.ibInventario.Click += new System.EventHandler(this.ibInventario_Click);
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
            this.panelInventario.Size = new System.Drawing.Size(688, 476);
            this.panelInventario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(140, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 476);
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
        private FontAwesome.Sharp.IconButton ibInventario;
        private FontAwesome.Sharp.IconButton ibPlaza;
        private FontAwesome.Sharp.IconButton ibUbicación;
        private FontAwesome.Sharp.IconButton ibSalida;
        private FontAwesome.Sharp.IconButton ibCategoria;
        private FontAwesome.Sharp.IconButton ibEstado;
        private FontAwesome.Sharp.IconButton ibReporte;
    }
}

