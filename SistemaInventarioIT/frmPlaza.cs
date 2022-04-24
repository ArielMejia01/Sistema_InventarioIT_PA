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
        public frmPlaza()
        {
            InitializeComponent();
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (txtPlaza.Text.Equals(""))
            {
                MessageBox.Show("!Ingrese el nombre de la plaza¡");
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("!Ingrese la descripción¡");
                return;
            }
            if (edit)
            {
                var tPlaza = entityInventario.Plaza.FirstOrDefault(p => p.IdPlaza == idPlaza);
                tPlaza.Nombre_Plaza = txtPlaza.Text;
                tPlaza.Descripcion = txtDescripcion.Text;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados!");
            }
            else
            {
                Plaza tPlaza = new Plaza();
                tPlaza.Nombre_Plaza = txtPlaza.Text;
                tPlaza.Descripcion = txtDescripcion.Text;
                entityInventario.Plaza.Add(tPlaza);
                entityInventario.SaveChanges();
                MessageBox.Show("¡Datos Guardados!");
            }
            idPlaza = 0;
            edit = false;
            carga_form();
        }

        private void carga_form()
        {
            var iPlaza = from i in entityInventario.Plaza
                         select new
                         {
                             i.IdPlaza,
                             i.Nombre_Plaza,
                             i.Descripcion
                         };
            dgPlaza.DataSource = iPlaza.CopyAnonymusToDataTable();
            dgPlaza.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmPlaza_Load(object sender, EventArgs e)
        {
            carga_form();
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            txtPlaza.Text = "";
            txtDescripcion.Text = "";
            idPlaza = 0;
            edit = false;
        }

        private void dgPlaza_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPlaza.SelectedRows.Count > 0)
            {
                try
                {
                    idPlaza = (int)Convert.ToInt64(dgPlaza.SelectedCells[0].Value);
                    var iPlaza = entityInventario.Plaza.FirstOrDefault(x => x.IdPlaza == idPlaza);
                    txtPlaza.Text = iPlaza.Nombre_Plaza;
                    txtDescripcion.Text = iPlaza.Descripcion;
                    edit = true;
                }
                catch (Exception)
                {
                    dgPlaza.ClearSelection();
                }
            }
        }
    }
}
