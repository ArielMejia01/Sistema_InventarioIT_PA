
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnEstanteIzquierdo = new System.Windows.Forms.Button();
            this.panelSubEstanteIzquierdo = new System.Windows.Forms.Panel();
            this.btnPlaza1 = new System.Windows.Forms.Button();
            this.btnPlaza2 = new System.Windows.Forms.Button();
            this.btnPlaza3 = new System.Windows.Forms.Button();
            this.btnPlaza4 = new System.Windows.Forms.Button();
            this.btnEstanteCentro = new System.Windows.Forms.Button();
            this.panelSubEstanteCentro = new System.Windows.Forms.Panel();
            this.btnCentro4 = new System.Windows.Forms.Button();
            this.btnCentro3 = new System.Windows.Forms.Button();
            this.btnCentro2 = new System.Windows.Forms.Button();
            this.btnCentro1 = new System.Windows.Forms.Button();
            this.btnCentro5 = new System.Windows.Forms.Button();
            this.btnCentro6 = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.panelSubEstanteIzquierdo.SuspendLayout();
            this.panelSubEstanteCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.panelLateral.Controls.Add(this.btnUbicacion);
            this.panelLateral.Controls.Add(this.panelSubEstanteCentro);
            this.panelLateral.Controls.Add(this.btnEstanteCentro);
            this.panelLateral.Controls.Add(this.panelSubEstanteIzquierdo);
            this.panelLateral.Controls.Add(this.btnEstanteIzquierdo);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(180, 439);
            this.panelLateral.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 76);
            this.panelLogo.TabIndex = 1;
            // 
            // btnEstanteIzquierdo
            // 
            this.btnEstanteIzquierdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstanteIzquierdo.FlatAppearance.BorderSize = 0;
            this.btnEstanteIzquierdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstanteIzquierdo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstanteIzquierdo.Location = new System.Drawing.Point(0, 76);
            this.btnEstanteIzquierdo.Name = "btnEstanteIzquierdo";
            this.btnEstanteIzquierdo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstanteIzquierdo.Size = new System.Drawing.Size(180, 30);
            this.btnEstanteIzquierdo.TabIndex = 2;
            this.btnEstanteIzquierdo.Text = "Estante Izquierdo";
            this.btnEstanteIzquierdo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstanteIzquierdo.UseVisualStyleBackColor = true;
            this.btnEstanteIzquierdo.Click += new System.EventHandler(this.btnEstanteIzquierdo_Click);
            // 
            // panelSubEstanteIzquierdo
            // 
            this.panelSubEstanteIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.panelSubEstanteIzquierdo.Controls.Add(this.btnPlaza4);
            this.panelSubEstanteIzquierdo.Controls.Add(this.btnPlaza3);
            this.panelSubEstanteIzquierdo.Controls.Add(this.btnPlaza2);
            this.panelSubEstanteIzquierdo.Controls.Add(this.btnPlaza1);
            this.panelSubEstanteIzquierdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubEstanteIzquierdo.Location = new System.Drawing.Point(0, 106);
            this.panelSubEstanteIzquierdo.Name = "panelSubEstanteIzquierdo";
            this.panelSubEstanteIzquierdo.Size = new System.Drawing.Size(180, 93);
            this.panelSubEstanteIzquierdo.TabIndex = 3;
            // 
            // btnPlaza1
            // 
            this.btnPlaza1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaza1.FlatAppearance.BorderSize = 0;
            this.btnPlaza1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaza1.ForeColor = System.Drawing.Color.White;
            this.btnPlaza1.Location = new System.Drawing.Point(0, 0);
            this.btnPlaza1.Name = "btnPlaza1";
            this.btnPlaza1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPlaza1.Size = new System.Drawing.Size(180, 23);
            this.btnPlaza1.TabIndex = 0;
            this.btnPlaza1.Text = "Plaza 1";
            this.btnPlaza1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaza1.UseVisualStyleBackColor = true;
            this.btnPlaza1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlaza2
            // 
            this.btnPlaza2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaza2.FlatAppearance.BorderSize = 0;
            this.btnPlaza2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaza2.ForeColor = System.Drawing.Color.White;
            this.btnPlaza2.Location = new System.Drawing.Point(0, 23);
            this.btnPlaza2.Name = "btnPlaza2";
            this.btnPlaza2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPlaza2.Size = new System.Drawing.Size(180, 23);
            this.btnPlaza2.TabIndex = 1;
            this.btnPlaza2.Text = "Plaza 2";
            this.btnPlaza2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaza2.UseVisualStyleBackColor = true;
            this.btnPlaza2.Click += new System.EventHandler(this.btnPlaza2_Click);
            // 
            // btnPlaza3
            // 
            this.btnPlaza3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaza3.FlatAppearance.BorderSize = 0;
            this.btnPlaza3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaza3.ForeColor = System.Drawing.Color.White;
            this.btnPlaza3.Location = new System.Drawing.Point(0, 46);
            this.btnPlaza3.Name = "btnPlaza3";
            this.btnPlaza3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPlaza3.Size = new System.Drawing.Size(180, 23);
            this.btnPlaza3.TabIndex = 2;
            this.btnPlaza3.Text = "Plaza 3";
            this.btnPlaza3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaza3.UseVisualStyleBackColor = true;
            this.btnPlaza3.Click += new System.EventHandler(this.btnPlaza3_Click);
            // 
            // btnPlaza4
            // 
            this.btnPlaza4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaza4.FlatAppearance.BorderSize = 0;
            this.btnPlaza4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaza4.ForeColor = System.Drawing.Color.White;
            this.btnPlaza4.Location = new System.Drawing.Point(0, 69);
            this.btnPlaza4.Name = "btnPlaza4";
            this.btnPlaza4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPlaza4.Size = new System.Drawing.Size(180, 23);
            this.btnPlaza4.TabIndex = 3;
            this.btnPlaza4.Text = "Plaza 4";
            this.btnPlaza4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaza4.UseVisualStyleBackColor = true;
            this.btnPlaza4.Click += new System.EventHandler(this.btnPlaza4_Click);
            // 
            // btnEstanteCentro
            // 
            this.btnEstanteCentro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstanteCentro.FlatAppearance.BorderSize = 0;
            this.btnEstanteCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstanteCentro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstanteCentro.Location = new System.Drawing.Point(0, 199);
            this.btnEstanteCentro.Name = "btnEstanteCentro";
            this.btnEstanteCentro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstanteCentro.Size = new System.Drawing.Size(180, 30);
            this.btnEstanteCentro.TabIndex = 4;
            this.btnEstanteCentro.Text = "Estante Centro";
            this.btnEstanteCentro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstanteCentro.UseVisualStyleBackColor = true;
            this.btnEstanteCentro.Click += new System.EventHandler(this.btnEstanteCentro_Click);
            // 
            // panelSubEstanteCentro
            // 
            this.panelSubEstanteCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.panelSubEstanteCentro.Controls.Add(this.btnCentro6);
            this.panelSubEstanteCentro.Controls.Add(this.btnCentro5);
            this.panelSubEstanteCentro.Controls.Add(this.btnCentro4);
            this.panelSubEstanteCentro.Controls.Add(this.btnCentro3);
            this.panelSubEstanteCentro.Controls.Add(this.btnCentro2);
            this.panelSubEstanteCentro.Controls.Add(this.btnCentro1);
            this.panelSubEstanteCentro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubEstanteCentro.Location = new System.Drawing.Point(0, 229);
            this.panelSubEstanteCentro.Name = "panelSubEstanteCentro";
            this.panelSubEstanteCentro.Size = new System.Drawing.Size(180, 143);
            this.panelSubEstanteCentro.TabIndex = 5;
            // 
            // btnCentro4
            // 
            this.btnCentro4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentro4.FlatAppearance.BorderSize = 0;
            this.btnCentro4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro4.ForeColor = System.Drawing.Color.White;
            this.btnCentro4.Location = new System.Drawing.Point(0, 69);
            this.btnCentro4.Name = "btnCentro4";
            this.btnCentro4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCentro4.Size = new System.Drawing.Size(180, 23);
            this.btnCentro4.TabIndex = 3;
            this.btnCentro4.Text = "Plaza 4";
            this.btnCentro4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro4.UseVisualStyleBackColor = true;
            this.btnCentro4.Click += new System.EventHandler(this.btnCentro4_Click);
            // 
            // btnCentro3
            // 
            this.btnCentro3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentro3.FlatAppearance.BorderSize = 0;
            this.btnCentro3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro3.ForeColor = System.Drawing.Color.White;
            this.btnCentro3.Location = new System.Drawing.Point(0, 46);
            this.btnCentro3.Name = "btnCentro3";
            this.btnCentro3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCentro3.Size = new System.Drawing.Size(180, 23);
            this.btnCentro3.TabIndex = 2;
            this.btnCentro3.Text = "Plaza 3";
            this.btnCentro3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro3.UseVisualStyleBackColor = true;
            this.btnCentro3.Click += new System.EventHandler(this.btnCentro3_Click);
            // 
            // btnCentro2
            // 
            this.btnCentro2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentro2.FlatAppearance.BorderSize = 0;
            this.btnCentro2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro2.ForeColor = System.Drawing.Color.White;
            this.btnCentro2.Location = new System.Drawing.Point(0, 23);
            this.btnCentro2.Name = "btnCentro2";
            this.btnCentro2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCentro2.Size = new System.Drawing.Size(180, 23);
            this.btnCentro2.TabIndex = 1;
            this.btnCentro2.Text = "Plaza 2";
            this.btnCentro2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro2.UseVisualStyleBackColor = true;
            this.btnCentro2.Click += new System.EventHandler(this.btnCentro2_Click);
            // 
            // btnCentro1
            // 
            this.btnCentro1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentro1.FlatAppearance.BorderSize = 0;
            this.btnCentro1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro1.ForeColor = System.Drawing.Color.White;
            this.btnCentro1.Location = new System.Drawing.Point(0, 0);
            this.btnCentro1.Name = "btnCentro1";
            this.btnCentro1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCentro1.Size = new System.Drawing.Size(180, 23);
            this.btnCentro1.TabIndex = 0;
            this.btnCentro1.Text = "Plaza 1";
            this.btnCentro1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro1.UseVisualStyleBackColor = true;
            this.btnCentro1.Click += new System.EventHandler(this.btnCentro1_Click);
            // 
            // btnCentro5
            // 
            this.btnCentro5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentro5.FlatAppearance.BorderSize = 0;
            this.btnCentro5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro5.ForeColor = System.Drawing.Color.White;
            this.btnCentro5.Location = new System.Drawing.Point(0, 92);
            this.btnCentro5.Name = "btnCentro5";
            this.btnCentro5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCentro5.Size = new System.Drawing.Size(180, 23);
            this.btnCentro5.TabIndex = 4;
            this.btnCentro5.Text = "Plaza 5";
            this.btnCentro5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro5.UseVisualStyleBackColor = true;
            this.btnCentro5.Click += new System.EventHandler(this.btnCentro5_Click);
            // 
            // btnCentro6
            // 
            this.btnCentro6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentro6.FlatAppearance.BorderSize = 0;
            this.btnCentro6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro6.ForeColor = System.Drawing.Color.White;
            this.btnCentro6.Location = new System.Drawing.Point(0, 115);
            this.btnCentro6.Name = "btnCentro6";
            this.btnCentro6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCentro6.Size = new System.Drawing.Size(180, 23);
            this.btnCentro6.TabIndex = 5;
            this.btnCentro6.Text = "Plaza 6";
            this.btnCentro6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro6.UseVisualStyleBackColor = true;
            this.btnCentro6.Click += new System.EventHandler(this.btnCentro6_Click);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUbicacion.FlatAppearance.BorderSize = 0;
            this.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUbicacion.Location = new System.Drawing.Point(0, 372);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUbicacion.Size = new System.Drawing.Size(180, 30);
            this.btnUbicacion.TabIndex = 6;
            this.btnUbicacion.Text = "Ubicación";
            this.btnUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 439);
            this.Controls.Add(this.panelLateral);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLateral.ResumeLayout(false);
            this.panelSubEstanteIzquierdo.ResumeLayout(false);
            this.panelSubEstanteCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelSubEstanteIzquierdo;
        private System.Windows.Forms.Button btnPlaza4;
        private System.Windows.Forms.Button btnPlaza3;
        private System.Windows.Forms.Button btnPlaza2;
        private System.Windows.Forms.Button btnPlaza1;
        private System.Windows.Forms.Button btnEstanteIzquierdo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Panel panelSubEstanteCentro;
        private System.Windows.Forms.Button btnCentro6;
        private System.Windows.Forms.Button btnCentro5;
        private System.Windows.Forms.Button btnCentro4;
        private System.Windows.Forms.Button btnCentro3;
        private System.Windows.Forms.Button btnCentro2;
        private System.Windows.Forms.Button btnCentro1;
        private System.Windows.Forms.Button btnEstanteCentro;
    }
}

