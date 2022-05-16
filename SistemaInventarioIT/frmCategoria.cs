using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioIT
{
    public partial class frmCategoria : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        bool edit = false;
        long idCategoria = 0;
        int vacio;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            carga_form();            
            vacio = 1;
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre de la categoria!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese la descripción de la categoria!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (edit)
            {
                var tCategoria = entityInventario.Categoria.FirstOrDefault(x => x.IdCategoria == idCategoria);
                tCategoria.Nombre_Categoria = txtNombre.Text;
                tCategoria.Descripcion = txtDescripcion.Text;
                tCategoria.Estado_Categoria = chkEstado.Checked;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados Correctamente!");
            }
            else
            {
                Categoria tNombreCategoria = new Categoria();
                tNombreCategoria.Nombre_Categoria = txtNombre.Text;
                tNombreCategoria.Descripcion = txtDescripcion.Text;
                tNombreCategoria.Estado_Categoria = chkEstado.Checked;
                entityInventario.Categoria.Add(tNombreCategoria);
                entityInventario.SaveChanges();
                MessageBox.Show("¡Datos Guardados Correctamente!");
            }
            idCategoria = 0;
            edit = false;
            carga_form();
            cleanText();
        }

        private void dgCategoria_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idCategoria = Convert.ToInt64(dgCategoria.SelectedCells[0].Value);
                var tCategoria = entityInventario.Categoria.FirstOrDefault(x => x.IdCategoria == idCategoria);
                txtNombre.Text = tCategoria.Nombre_Categoria;
                txtDescripcion.Text = tCategoria.Descripcion;
                chkEstado.Checked = tCategoria.Estado_Categoria;
                edit = true;
            }
            catch (Exception)
            {
                dgCategoria.ClearSelection();
            }

        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }

        private void carga_form()
        {
            var iCategoria = from i in entityInventario.Categoria
                             select new
                             {
                                 i.IdCategoria,
                                 i.Nombre_Categoria,
                                 i.Descripcion,
                                 i.Estado_Categoria
                             };
            dgCategoria.DataSource = iCategoria.CopyAnonymusToDataTable();
            dgCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cleanText()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            edit = false;
            dgCategoria.ClearSelection();
        }
            
        private void dgCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void dgCategoria_MouseMove(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarCategoria(txtBuscar.Text);
        }

        private void FiltrarCategoria(string nombre)
        {
            var fCategoria = from c in entityInventario.Categoria
                             where c.Nombre_Categoria.Contains(nombre)
                             select new
                             {
                                 c.IdCategoria,
                                 c.Nombre_Categoria,
                                 c.Descripcion,
                                 c.Estado_Categoria
                             };
            dgCategoria.DataSource = fCategoria.CopyAnonymusToDataTable();
            dgCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                carga_form();
            }
        }
    }
}
