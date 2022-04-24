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
    public partial class frmInventario : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        int idInventario = 0;
        bool editar = false;
        public frmInventario()
        {
            InitializeComponent();
        }

        

        /*Consultar que campos seran obligatorios y que no*/
        /*en la bd yo tengo que: el serial, la cantidad, la descripcion, la categoria, el modelo y la garantia
         allow nulls(que permiten nulos)*/
        private void ibAgregar_Click(object sender, EventArgs e)
        {
            /*if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre del articulo!");
                return;
            }
            if (cmbUbicacion.SelectedIndex==-1)
            {
                MessageBox.Show("¡Seleccione la ubicación!");
                return;
            }
            if (cmbPlaza.SelectedIndex==-1)
            {
                MessageBox.Show("¡Seleccione una plaza!");
                return;
            }
            if (txtSerial.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el serial!");
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese la descripción!");
                return;
            }
            if (Convert.ToDecimal(txtCantidad.Text) <= 0)
            {
                MessageBox.Show("¡Ingrese una cantidad valida!");
                return;
            }
            if (txtCategoria.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese la categoria!");
                return;
            }
            if (chkEstado.Checked.Equals(""))
            {
                MessageBox.Show("¡Seleccione el estado!");
                return;
            }
            if (txtModelo.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el modelo!");
                return;
            }*/
            if (editar)
            {

                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Nombre = txtNombre.Text;
                tInventario.Ubicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);
                tInventario.Plaza = Convert.ToInt32(cmbPlaza.SelectedValue);
                tInventario.Serial = txtSerial.Text;
                tInventario.Descripcion = txtDescripcion.Text;
                tInventario.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tInventario.Categoria = txtCategoria.Text;
                tInventario.Estado = chkEstado.Checked;
                tInventario.Modelo = txtModelo.Text;
                tInventario.Garantia = dtFecha.Value;

                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados!");
                carga_form();
            }
            else
            {

                Inventario inventario = new Inventario();
                inventario.Nombre = txtNombre.Text;
                inventario.Ubicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);
                inventario.Plaza = Convert.ToInt32(cmbPlaza.SelectedValue);
                inventario.Serial = txtSerial.Text;
                inventario.Descripcion = txtDescripcion.Text;
                inventario.Cantidad = Convert.ToInt32(txtCantidad.Text);
                inventario.Categoria = txtCategoria.Text;
                inventario.Estado = chkEstado.Checked;
                inventario.Modelo = txtModelo.Text;
                inventario.Garantia = dtFecha.Value;

                entityInventario.Inventario.Add(inventario);
                entityInventario.SaveChanges();
                carga_form();
                MessageBox.Show("¡Datos Guardados!");
            }
            idInventario = 0;
            editar = false;
            carga_form();
        }

        
        private void carga_form()
        {
            
            var ubicacion = from u in entityInventario.Ubicacion
                            select u;
            DataTable dtUbicacion = new DataTable();
            dtUbicacion = ubicacion.CopyAnonymusToDataTable();

            cmbUbicacion.DataSource = dtUbicacion;
            cmbUbicacion.DisplayMember = dtUbicacion.Columns[1].ColumnName;
            cmbUbicacion.ValueMember = dtUbicacion.Columns[0].ColumnName;

            var plaza = from p in entityInventario.Plaza
                        select p;
            DataTable dtPlaza = new DataTable();
            dtPlaza = plaza.CopyAnonymusToDataTable();
            cmbPlaza.DataSource = dtPlaza;
            cmbPlaza.DisplayMember = dtPlaza.Columns[1].ColumnName;
            cmbPlaza.ValueMember = dtPlaza.Columns[0].ColumnName;

           
            var izquierdaUno = from i in entityInventario.Inventario
                               join y
                               in entityInventario.Ubicacion on i.Ubicacion equals y.IdUbicacion
                               join p
                               in entityInventario.Plaza on i.Plaza equals p.IdPlaza
                               select new
                               {
                                   i.IdInventario,
                                   i.Nombre,
                                   y.Nombre_Ubicacion,
                                   p.Nombre_Plaza,
                                   i.Serial,
                                   i.Cantidad,
                                   i.Descripcion,
                                   i.Categoria,
                                   i.Estado,
                                   i.Modelo,
                                   i.Garantia
                               };

            dgInventario.DataSource = izquierdaUno.CopyAnonymusToDataTable();
            dgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            carga_form();

            cmbUbicacion.Text = "Seleccionar...";
            cmbPlaza.Text = "Seleccionar...";

        }

        private void dgInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgInventario.RowCount > 0)
            {
                try
                {
                    idInventario = Convert.ToInt32(dgInventario.SelectedCells[0].Value);
                    var tInventario = entityInventario.Inventario.FirstOrDefault(x => x.IdInventario == idInventario);
                    txtNombre.Text = tInventario.Nombre;
                    cmbUbicacion.SelectedValue = tInventario.Ubicacion;
                    cmbPlaza.SelectedValue = tInventario.Plaza;
                    txtSerial.Text = tInventario.Serial;
                    txtDescripcion.Text = tInventario.Descripcion;
                    txtCantidad.Text = Convert.ToString(tInventario.Cantidad);
                    txtCategoria.Text = tInventario.Categoria;
                    chkEstado.Checked = tInventario.Estado;
                    txtModelo.Text = tInventario.Modelo;
                    dtFecha.Value = (DateTime)tInventario.Garantia;
                    editar = true;
                }
                catch (Exception)
                {

                }
            }
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtSerial.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtCategoria.Text = "";
            chkEstado.Checked = false;
            txtModelo.Text = "";
            idInventario = 0;
            editar = false;
            dgInventario.ClearSelection();
        }
    }
}
