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
    public partial class frmSalidas : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        int vacio;
        bool editar = false;
        int idInventario = 0;
        public frmSalidas()
        {
            InitializeComponent();
        }

        private void frmSalidas_Load(object sender, EventArgs e)
        {
            cargaForm();
            vacio = 1;
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            /*if (txtDestino.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el destino del articulo!");
                return;
            }*/
            if (editar)
            {
                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Salida = chkSalida.Checked;
                tInventario.Destino = txtDestino.Text;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Salida Guardada!");
                cargaForm();
            }
            else
            {
                Inventario inventario = new Inventario();
                inventario.Salida = chkSalida.Checked;
                inventario.Destino = txtDestino.Text;

                entityInventario.Inventario.Add(inventario);
                entityInventario.SaveChanges();
                cargaForm();
                MessageBox.Show("¡Salida Guardada!");
            }
            idInventario = 0;
            editar = false;
            cargaForm();
            cleanText();
        }

        private void dgSalida_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idInventario = Convert.ToInt32(dgSalida.SelectedCells[0].Value);
                var tSalidas = entityInventario.Inventario.FirstOrDefault(x => x.IdInventario == idInventario);
                chkSalida.Checked = (bool)tSalidas.Salida;
                txtDestino.Text = tSalidas.Destino;
                editar = true;
            }
            catch (Exception)
            {
                dgSalida.ClearSelection();
            }            
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }

        private void cargaForm()
        {
            var salida = from s in entityInventario.Inventario
                         join y
                         in entityInventario.Ubicacion on s.Ubicacion equals y.IdUbicacion
                         join p
                         in entityInventario.Plaza on s.Plaza equals p.IdPlaza
                         join c
                         in entityInventario.Categoria on s.Categoria equals c.IdCategoria
                         join e
                         in entityInventario.Estado on s.Estado equals e.IdEstado
                         where s.Salida == false
                         select new
                         {
                             s.IdInventario,
                             s.Nombre,
                             y.Nombre_Ubicacion,
                             p.Nombre_Plaza,
                             s.Serial,
                             s.Cantidad,
                             s.Descripcion,
                             c.Nombre_Categoria,
                             e.Nombre_Estado,
                             s.Modelo,
                             s.Garantia,
                             s.Salida,
                             s.Destino
                         };
            dgSalida.DataSource = salida.CopyAnonymusToDataTable();
            dgSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cleanText()
        {
            //txtNombre.Text = "";
            //txtSerial.Text = "";
            //txtDescripcion.Text = "";
            //txtCantidad.Text = "";
            //txtCategoria.Text = "";
            //chkEstado.Checked = false;
            //txtModelo.Text = "";
            //idInventario = 0;
            //editar = false;
            //txtBuscar.Text = string.Empty;
            //txtBuscar.Text = "";
            //dgInventario.ClearSelection();
            chkSalida.Checked = false;
            txtDestino.Text = "";
            editar = false;
            dgSalida.ClearSelection();
        }

        private void AgreUpdateEventHandler(object sender, frmVerSalidas.UpdateEventArgs args)
        {
            cargaForm();
        }

        private void ibVerSalidas_Click(object sender, EventArgs e)
        {
            frmVerSalidas salidas = new frmVerSalidas(this);
            salidas.UpdateEventHandler += AgreUpdateEventHandler;
            salidas.Show();
            cargaForm();
        }      

        private void dgSalida_MouseMove(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void dgSalida_MouseClick(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void txtBucar_TextChanged(object sender, EventArgs e)
        {
            filtrarSalidas(txtBucar.Text);
        }

        private void filtrarSalidas(string nombre)
        {
            var fInventario = from i in entityInventario.Inventario
                              where i.Nombre.Contains(nombre)
                              join y
                              in entityInventario.Ubicacion on i.Ubicacion equals y.IdUbicacion
                              join p
                              in entityInventario.Plaza on i.Plaza equals p.IdPlaza
                              join c
                              in entityInventario.Categoria on i.Categoria equals c.IdCategoria
                              join e
                              in entityInventario.Estado on i.Estado equals e.IdEstado
                              where i.Salida == false
                              select new
                              {
                                  i.IdInventario,
                                  i.Nombre,
                                  y.Nombre_Ubicacion,
                                  p.Nombre_Plaza,
                                  i.Serial,
                                  i.Cantidad,
                                  i.Descripcion,
                                  c.Nombre_Categoria,
                                  e.Nombre_Estado,
                                  i.Modelo,
                                  i.Garantia,
                                  i.Salida,
                                  i.Destino
                              };
            dgSalida.DataSource = fInventario.CopyAnonymusToDataTable();
            dgSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void txtBucar_Enter(object sender, EventArgs e)
        {
            if (txtBucar.Text == "Buscar...")
            {
                txtBucar.Text = "";
            }
        }

        private void txtBucar_Leave(object sender, EventArgs e)
        {
            if (txtBucar.Text == "")
            {
                txtBucar.Text = "Buscar...";
                cargaForm();
            }
        }       
    }
}
