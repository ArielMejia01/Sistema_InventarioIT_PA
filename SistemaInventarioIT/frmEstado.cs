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
    public partial class frmEstado : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        bool edit = false;
        long idEstado = 0;
        int vacio;
        public frmEstado()
        {
            InitializeComponent();
        }

        private void frmEstado_Load(object sender, EventArgs e)
        {
            cargaForm();
            vacio = 1;
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre del estado!");
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese la descipción del estado!");
                return;
            }
            if (edit)
            {
                var tEstado = entityInventario.Estado.FirstOrDefault(x => x.IdEstado == idEstado);
                tEstado.Nombre_Estado = txtNombre.Text;
                tEstado.Descripcion = txtDescripcion.Text;
                tEstado.Estado_Estado = chkEstado.Checked;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados Correctamente!");
            }
            else
            {
                Estado tNombreEstado = new Estado();
                tNombreEstado.Nombre_Estado = txtNombre.Text;
                tNombreEstado.Descripcion = txtDescripcion.Text;
                tNombreEstado.Estado_Estado = chkEstado.Checked;
                entityInventario.Estado.Add(tNombreEstado);
                entityInventario.SaveChanges();
                MessageBox.Show("¡Datos Guardados Correctamente!");
            }
            idEstado = 0;
            edit = false;
            cargaForm();
            cleanText();
        }

        private void dgEstado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idEstado = Convert.ToInt64(dgEstado.SelectedCells[0].Value);
                var tEstado = entityInventario.Estado.FirstOrDefault(x => x.IdEstado == idEstado);
                txtNombre.Text = tEstado.Nombre_Estado;
                txtDescripcion.Text = tEstado.Descripcion;
                chkEstado.Checked = tEstado.Estado_Estado;
                edit = true;
            }
            catch (Exception)
            {
                dgEstado.ClearSelection();
            }
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }

        private void cargaForm()
        {
            var iEstado = from i in entityInventario.Estado
                          select new
                          {
                              i.IdEstado,
                              i.Nombre_Estado,
                              i.Descripcion,
                              i.Estado_Estado
                          };
            dgEstado.DataSource = iEstado.CopyAnonymusToDataTable();
            dgEstado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        
        private void cleanText()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            edit = false;
            dgEstado.ClearSelection();
        }        

        private void dgEstado_MouseClick(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        
    }
}
