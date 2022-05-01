
namespace SistemaInventarioIT
{
    partial class frmEstado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.dgEstado = new System.Windows.Forms.DataGridView();
            this.ibAgregar = new FontAwesome.Sharp.IconButton();
            this.ibNuevo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(291, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(291, 141);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(294, 194);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(148, 17);
            this.chkEstado.TabIndex = 6;
            this.chkEstado.Text = "Habilitado / Deshabilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // dgEstado
            // 
            this.dgEstado.AllowUserToAddRows = false;
            this.dgEstado.AllowUserToDeleteRows = false;
            this.dgEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstado.Location = new System.Drawing.Point(112, 249);
            this.dgEstado.Name = "dgEstado";
            this.dgEstado.ReadOnly = true;
            this.dgEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstado.Size = new System.Drawing.Size(461, 112);
            this.dgEstado.TabIndex = 7;
            this.dgEstado.SelectionChanged += new System.EventHandler(this.dgEstado_SelectionChanged);
            // 
            // ibAgregar
            // 
            this.ibAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ibAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgregar.IconSize = 30;
            this.ibAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgregar.Location = new System.Drawing.Point(130, 391);
            this.ibAgregar.Name = "ibAgregar";
            this.ibAgregar.Size = new System.Drawing.Size(92, 34);
            this.ibAgregar.TabIndex = 50;
            this.ibAgregar.Text = "Agregar";
            this.ibAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAgregar.UseVisualStyleBackColor = true;
            this.ibAgregar.Click += new System.EventHandler(this.ibAgregar_Click);
            // 
            // ibNuevo
            // 
            this.ibNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibNuevo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.ibNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ibNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibNuevo.IconSize = 25;
            this.ibNuevo.Location = new System.Drawing.Point(242, 391);
            this.ibNuevo.Name = "ibNuevo";
            this.ibNuevo.Size = new System.Drawing.Size(92, 34);
            this.ibNuevo.TabIndex = 53;
            this.ibNuevo.Text = "Nuevo";
            this.ibNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibNuevo.UseVisualStyleBackColor = true;
            // 
            // frmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 476);
            this.Controls.Add(this.ibNuevo);
            this.Controls.Add(this.ibAgregar);
            this.Controls.Add(this.dgEstado);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEstado";
            this.Text = "frmEstado";
            this.Load += new System.EventHandler(this.frmEstado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.DataGridView dgEstado;
        private FontAwesome.Sharp.IconButton ibAgregar;
        private FontAwesome.Sharp.IconButton ibNuevo;
    }
}