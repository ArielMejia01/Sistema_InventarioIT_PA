﻿
namespace SistemaInventarioIT
{
    partial class frmUbicacion
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
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgUbicacion = new System.Windows.Forms.DataGridView();
            this.ibAgregar = new FontAwesome.Sharp.IconButton();
            this.ibNuevo = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUbicacion)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "UBICACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(317, 82);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(197, 20);
            this.txtUbicacion.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(317, 131);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 47);
            this.txtDescripcion.TabIndex = 4;
            // 
            // dgUbicacion
            // 
            this.dgUbicacion.AllowUserToAddRows = false;
            this.dgUbicacion.AllowUserToDeleteRows = false;
            this.dgUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUbicacion.Location = new System.Drawing.Point(113, 252);
            this.dgUbicacion.Name = "dgUbicacion";
            this.dgUbicacion.ReadOnly = true;
            this.dgUbicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUbicacion.Size = new System.Drawing.Size(461, 112);
            this.dgUbicacion.TabIndex = 5;
            this.dgUbicacion.SelectionChanged += new System.EventHandler(this.dgUbicacion_SelectionChanged);
            // 
            // ibAgregar
            // 
            this.ibAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ibAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgregar.IconSize = 30;
            this.ibAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgregar.Location = new System.Drawing.Point(113, 398);
            this.ibAgregar.Name = "ibAgregar";
            this.ibAgregar.Size = new System.Drawing.Size(92, 34);
            this.ibAgregar.TabIndex = 48;
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
            this.ibNuevo.Location = new System.Drawing.Point(234, 398);
            this.ibNuevo.Name = "ibNuevo";
            this.ibNuevo.Size = new System.Drawing.Size(92, 34);
            this.ibNuevo.TabIndex = 51;
            this.ibNuevo.Text = "Nuevo";
            this.ibNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibNuevo.UseVisualStyleBackColor = true;
            this.ibNuevo.Click += new System.EventHandler(this.ibNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Estado";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(317, 205);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(183, 20);
            this.chkEstado.TabIndex = 53;
            this.chkEstado.Text = "Habilitado / Deshabilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // frmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 476);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ibNuevo);
            this.Controls.Add(this.ibAgregar);
            this.Controls.Add(this.dgUbicacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUbicacion";
            this.Text = "frmUbicacion";
            this.Load += new System.EventHandler(this.frmUbicacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUbicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgUbicacion;
        private FontAwesome.Sharp.IconButton ibAgregar;
        private FontAwesome.Sharp.IconButton ibNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkEstado;
    }
}