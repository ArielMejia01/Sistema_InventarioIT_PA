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
    public partial class frmPlaza : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        bool edit = false;
        int idPlaza = 0;
        int vacio;
        public frmPlaza()
        {
            InitializeComponent();
        }

        private void frmPlaza_Load(object sender, EventArgs e)
        {
            carga_form();
            vacio = 1;
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (txtPlaza.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre de la plaza!");
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese la descripción de la plaza!");
                return;
            }
            if (edit)
            {
                var tPlaza = entityInventario.Plaza.FirstOrDefault(p => p.IdPlaza == idPlaza);
                tPlaza.Nombre_Plaza = txtPlaza.Text;
                tPlaza.Descripcion = txtDescripcion.Text;
                tPlaza.Estado_Plaza = chkEstado.Checked;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados Correctamente!");
            }
            else
            {
                Plaza tPlaza = new Plaza();
                tPlaza.Nombre_Plaza = txtPlaza.Text;
                tPlaza.Descripcion = txtDescripcion.Text;
                tPlaza.Estado_Plaza = chkEstado.Checked;
                entityInventario.Plaza.Add(tPlaza);
                entityInventario.SaveChanges();
                MessageBox.Show("¡Datos Guardados Correctamente!");
            }
            idPlaza = 0;
            edit = false;
            carga_form();
            cleanText();
        }

        private void dgPlaza_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idPlaza = (int)Convert.ToInt64(dgPlaza.SelectedCells[0].Value);
                var iPlaza = entityInventario.Plaza.FirstOrDefault(x => x.IdPlaza == idPlaza);
                txtPlaza.Text = iPlaza.Nombre_Plaza;
                txtDescripcion.Text = iPlaza.Descripcion;
                chkEstado.Checked = iPlaza.Estado_Plaza;
                edit = true;
            }
            catch (Exception)
            {
                dgPlaza.ClearSelection();
            }
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }

        private void carga_form()
        {
            var iPlaza = from i in entityInventario.Plaza
                         select new
                         {
                             i.IdPlaza,
                             i.Nombre_Plaza,
                             i.Descripcion,
                             i.Estado_Plaza
                         };
            dgPlaza.DataSource = iPlaza.CopyAnonymusToDataTable();
            dgPlaza.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cleanText()
        {
            txtPlaza.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            edit = false;
            dgPlaza.ClearSelection();
        }
                                
        private void dgPlaza_MouseClick(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void dgPlaza_MouseMove(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }
    }
}
