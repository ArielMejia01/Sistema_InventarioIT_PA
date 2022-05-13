
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerSalidas));
            this.label1 = new System.Windows.Forms.Label();
            this.ibRegresar = new FontAwesome.Sharp.IconButton();
            this.dgVerSalidas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.ibAgregar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCancelar = new System.Windows.Forms.CheckBox();
            this.ibNuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerSalidas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE SALIDAS";
            // 
            // ibRegresar
            // 
            this.ibRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibRegresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.ibRegresar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ibRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibRegresar.IconSize = 25;
            this.ibRegresar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibRegresar.Location = new System.Drawing.Point(12, 46);
            this.ibRegresar.Name = "ibRegresar";
            this.ibRegresar.Size = new System.Drawing.Size(33, 36);
            this.ibRegresar.TabIndex = 1;
            this.ibRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibRegresar.UseVisualStyleBackColor = true;
            this.ibRegresar.Click += new System.EventHandler(this.ibRegresar_Click);
            // 
            // dgVerSalidas
            // 
            this.dgVerSalidas.AllowUserToAddRows = false;
            this.dgVerSalidas.AllowUserToDeleteRows = false;
            this.dgVerSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgVerSalidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgVerSalidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgVerSalidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVerSalidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVerSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVerSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgVerSalidas.EnableHeadersVisualStyles = false;
            this.dgVerSalidas.Location = new System.Drawing.Point(48, 193);
            this.dgVerSalidas.Name = "dgVerSalidas";
            this.dgVerSalidas.ReadOnly = true;
            this.dgVerSalidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVerSalidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgVerSalidas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVerSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVerSalidas.Size = new System.Drawing.Size(775, 238);
            this.dgVerSalidas.TabIndex = 2;
            this.dgVerSalidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVerSalidas_CellDoubleClick);
            this.dgVerSalidas.SelectionChanged += new System.EventHandler(this.dgVerSalidas_SelectionChanged);
            this.dgVerSalidas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgVerSalidas_MouseClick);
            this.dgVerSalidas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgVerSalidas_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 40);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Artículo";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(95, 90);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(193, 21);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.Text = "Buscar...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // ibAgregar
            // 
            this.ibAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAgregar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.ibAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ibAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgregar.IconSize = 30;
            this.ibAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgregar.Location = new System.Drawing.Point(150, 446);
            this.ibAgregar.Name = "ibAgregar";
            this.ibAgregar.Size = new System.Drawing.Size(138, 34);
            this.ibAgregar.TabIndex = 13;
            this.ibAgregar.Text = "Cancelar Salida";
            this.ibAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAgregar.UseVisualStyleBackColor = true;
            this.ibAgregar.Click += new System.EventHandler(this.ibAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Salida";
            // 
            // chkCancelar
            // 
            this.chkCancelar.AutoSize = true;
            this.chkCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelar.Location = new System.Drawing.Point(176, 145);
            this.chkCancelar.Name = "chkCancelar";
            this.chkCancelar.Size = new System.Drawing.Size(81, 20);
            this.chkCancelar.TabIndex = 15;
            this.chkCancelar.Text = "Cancelar";
            this.chkCancelar.UseVisualStyleBackColor = true;
            // 
            // ibNuevo
            // 
            this.ibNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibNuevo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.ibNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ibNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibNuevo.IconSize = 25;
            this.ibNuevo.Location = new System.Drawing.Point(335, 445);
            this.ibNuevo.Name = "ibNuevo";
            this.ibNuevo.Size = new System.Drawing.Size(92, 34);
            this.ibNuevo.TabIndex = 16;
            this.ibNuevo.Text = "Nuevo";
            this.ibNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibNuevo.UseVisualStyleBackColor = true;
            this.ibNuevo.Click += new System.EventHandler(this.ibNuevo_Click);
            // 
            // frmVerSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 515);
            this.Controls.Add(this.ibNuevo);
            this.Controls.Add(this.chkCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ibAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgVerSalidas);
            this.Controls.Add(this.ibRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.frmVerSalidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVerSalidas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibRegresar;
        private System.Windows.Forms.DataGridView dgVerSalidas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton ibAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCancelar;
        private FontAwesome.Sharp.IconButton ibNuevo;
    }
}