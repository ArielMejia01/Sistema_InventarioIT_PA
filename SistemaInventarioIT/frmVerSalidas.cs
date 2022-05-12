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
        int vacio;
        int idInventario = 0;
        bool editar = false;
        public frmVerSalidas()
        {
            InitializeComponent();
        }

        private void ibRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerSalidas_Load(object sender, EventArgs e)
        {
            carga_form();
            vacio = 1;
            
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
                
            }
        }     

        private void dgVerSalidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (editar)
            {

                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Salida = false;

                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados!");
                //carga_form();
            }
            else
            {
                Inventario inventario = new Inventario();
                inventario.Salida = false;

                entityInventario.Inventario.Add(inventario);
                entityInventario.SaveChanges();
                //carga_form();
                MessageBox.Show("¡Reversion!");
            }
        }

        
    }
}
