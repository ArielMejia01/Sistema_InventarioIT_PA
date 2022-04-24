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
    public partial class frmEstanteIzquierdo : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        int idInventario = 0;
        bool editar = false;
        public frmEstanteIzquierdo()
        {
            InitializeComponent();
        }

        private void frmEstanteIzquierdo_Load(object sender, EventArgs e)
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

            /*var tCompras = from Detalle in Variables.DetalleDeCompra
                           join Compras
                           in Variables.Compra on Detalle.IdCompra equals Compras.IdCompra
                           join Proveedor in Variables.Proveedor on Detalle.IdProveedor
                           equals Proveedor.IdProveedor
                           select new*/

        var tEstanteIzquierdo = from t in entityInventario.Inventario

                                    select new
                                    {
                                        t.IdInventario,
                                        t.Nombre,
                                        //t.Ubicacion,
                                        t.Plaza,
                                        t.Serial,
                                        t.Cantidad,
                                        t.Descripcion,
                                        t.Categoria,
                                        t.Estado,
                                        t.Modelo,
                                        t.Garantia
                                    };
            dgEstanteIzquierdo.DataSource = tEstanteIzquierdo.CopyAnonymusToDataTable();
            dgEstanteIzquierdo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cmbUbicacion.Text = "Seleccionar...";
            cmbPlaza.Text = "Seleccionar...";
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
            try{
                if (editar)
                {
                    var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                    tInventario.Nombre = txtNombre.Text;
                    tInventario.Ubicacion = cmbUbicacion.SelectedIndex;
                    tInventario.Plaza = cmbPlaza.SelectedIndex;
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
                    inventario.Ubicacion = cmbUbicacion.SelectedIndex;
                    inventario.Plaza = cmbPlaza.SelectedIndex;
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
            }
            catch(Exception)
            {

            }
        }

        private void dgEstanteIzquierdo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgEstanteIzquierdo.RowCount > 0)
            {
                try
                {
                    idInventario = (int)Convert.ToInt64(dgEstanteIzquierdo.SelectedCells[0].Value);
                    var tEstanteIzquierdo = entityInventario.Inventario.FirstOrDefault(x => x.IdInventario == idInventario);
                    txtNombre.Text = tEstanteIzquierdo.Nombre;
                    txtSerial.Text = tEstanteIzquierdo.Serial;
                    txtDescripcion.Text = tEstanteIzquierdo.Descripcion;
                    txtCantidad.Text = Convert.ToString(tEstanteIzquierdo.Cantidad);
                    txtCategoria.Text = tEstanteIzquierdo.Categoria;
                    chkEstado.Checked = tEstanteIzquierdo.Estado;
                    txtModelo.Text = tEstanteIzquierdo.Modelo;
                    dtFecha.Value = (DateTime)tEstanteIzquierdo.Garantia;
                }
                catch (Exception)
                {

                }
            }
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

            var tEstanteIzquierdo = from t in entityInventario.Inventario
                                    select new
                                    {
                                        t.IdInventario,
                                        t.Nombre,
                                        //t.Ubicacion,
                                        //t.Plaza,
                                        t.Serial,
                                        t.Cantidad,
                                        t.Descripcion,
                                        t.Categoria,
                                        t.Estado,
                                        t.Modelo,
                                        t.Garantia
                                    };
            dgEstanteIzquierdo.DataSource = tEstanteIzquierdo.CopyAnonymusToDataTable();
            dgEstanteIzquierdo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cmbUbicacion.Text = "Seleccionar...";
            cmbPlaza.Text = "Seleccionar...";
        }
    }
}
