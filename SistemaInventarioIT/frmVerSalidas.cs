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
    public partial class frmVerSalidas : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        int idInventario = 0;
        bool editar = false;
        int vacio;        
        
        public frmVerSalidas(frmSalidas SalidasArt)
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void frmVerSalidas_Load(object sender, EventArgs e)
        {
            carga_form();
            vacio = 1;
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (chkCancelar.Checked == true)
            {
                MessageBox.Show("!Desmarcar salida del artículo para realizar la operación¡", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Cantidad = 1;
            }
            if (editar)
            {
                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Salida = chkCancelar.Checked;
                //tInventario.Destino = txtDestino.Text;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Salida Cancelada Correctamente!");
                carga_form();
                Agregar();
            }
            else
            {
                Inventario inventario = new Inventario();
                inventario.Salida = chkCancelar.Checked;
                //inventario.Destino = txtDestino.Text;

                entityInventario.Inventario.Add(inventario);
                entityInventario.SaveChanges();
                MessageBox.Show("¡Salida Cancelada Correctamente!");
                carga_form();
                Agregar();
            }
            idInventario = 0;
            editar = false;
            carga_form();
            cleanText();
        }
        

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }

        private void carga_form()
        {
            var inventario = from i in entityInventario.Inventario
                             join y
                             in entityInventario.Ubicacion on i.Ubicacion equals y.IdUbicacion
                             join p
                             in entityInventario.Plaza on i.Plaza equals p.IdPlaza
                             join c
                             in entityInventario.Categoria on i.Categoria equals c.IdCategoria
                             join e
                             in entityInventario.Estado on i.Estado equals e.IdEstado
                             where i.Salida == true
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

            dgVerSalidas.DataSource = inventario.CopyAnonymusToDataTable();
            dgVerSalidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        
        //Metodo para limpiar el grid y otros componentes del form
        private void cleanText()
        {            
            chkCancelar.Checked = false;            
            editar = false;
            dgVerSalidas.ClearSelection();
        }

        //Regresar al formulario anterior "el de Salidas"
        private void ibRegresar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }               
        
        //Funcionamiento para realizar la busqueda de una salida en el text box
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarSalidas(txtBuscar.Text);
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
                              where i.Salida == true
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
            dgVerSalidas.DataSource = fInventario.CopyAnonymusToDataTable();
            dgVerSalidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

        //Realizar una cancelación de salida con un doble click en el campo que se requiera.
        private void dgVerSalidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (chkCancelar.Checked == true)
            {
                MessageBox.Show("!Desmarcar salida del artículo para realizar la operación¡", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Cantidad = 1;
            }
            if (editar)
            {

                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Salida = false;

                entityInventario.SaveChanges();
                MessageBox.Show("¡Salida Cancelada Correctamente!");                
                carga_form();
                Agregar();
            }
            else
            {
                Inventario inventario = new Inventario();
                inventario.Salida = false;

                entityInventario.Inventario.Add(inventario);
                entityInventario.SaveChanges();                
                MessageBox.Show("¡Salida Cancelada Correctamente!");                
                carga_form();
                Agregar();
            }
        }

        private void dgVerSalidas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idInventario = Convert.ToInt32(dgVerSalidas.SelectedCells[0].Value);
                var tSalidas = entityInventario.Inventario.FirstOrDefault(x => x.IdInventario == idInventario);
                chkCancelar.Checked = (bool)tSalidas.Salida;
                editar = true;
            }
            catch (Exception)
            {
                dgVerSalidas.ClearSelection();
            }
        }

        private void dgVerSalidas_MouseMove(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void dgVerSalidas_MouseClick(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }
    }
}
