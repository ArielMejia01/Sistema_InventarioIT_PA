using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioIT.Estante_Izquierdo
{
    //DBInventarioITPAEntities InventarioEntities = new DBInventarioITPAEntities();
    public partial class frmIzquierdaPlaza1 : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        bool editar = false;
        long idInventario = 0;
        public frmIzquierdaPlaza1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(idInventario));
            //MessageBox.Show(Convert.ToString(editar));
                if (editar)
                {

                    var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                    tInventario.Nombre = txtNombre.Text;
                    tInventario.Ubicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);
                    tInventario.Plaza = Convert.ToInt32(cmbPlaza.SelectedValue);
                    tInventario.Serial = txtSerial.Text;
                    tInventario.Descripcion = txtDescripcion.Text;
                    tInventario.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    //tInventario.Categoria = txtCategoria.Text;
                    //tInventario.Estado = chkEstado.Checked;
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
                    //inventario.Categoria = txtCategoria.Text;         
                    //inventario.Estado = chkEstado.Checked;        
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

        private void frmIzquierdaPlaza1_Load(object sender, EventArgs e)
        {

            carga_form();
            
        }

        private void carga_form()
        {
            //Cargar la ubicacion al comboBox desde la tabla Ubicacion
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

            var categoria = from c in entityInventario.Categoria
                            select c;

            //Cargar la informacion al "cargar" el formulario
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

            dgvIzquierda1.DataSource = izquierdaUno.CopyAnonymusToDataTable();
            dgvIzquierda1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvIzquierda1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIzquierda1.RowCount > 0)
            {
                try
                {
                    idInventario = Convert.ToInt64(dgvIzquierda1.SelectedCells[0].Value);
                    var tEstanteIzquierdo = entityInventario.Inventario.FirstOrDefault(x => x.IdInventario == idInventario);
                    txtNombre.Text = tEstanteIzquierdo.Nombre;
                    cmbUbicacion.SelectedValue = tEstanteIzquierdo.Ubicacion;
                    cmbPlaza.SelectedValue = tEstanteIzquierdo.Plaza;
                    txtSerial.Text = tEstanteIzquierdo.Serial;
                    txtDescripcion.Text = tEstanteIzquierdo.Descripcion;
                    txtCantidad.Text = Convert.ToString(tEstanteIzquierdo.Cantidad);
                    //txtCategoria.Text = tEstanteIzquierdo.Categoria;
                    //chkEstado.Checked = tEstanteIzquierdo.Estado;
                    txtModelo.Text = tEstanteIzquierdo.Modelo;
                    dtFecha.Value = (DateTime)tEstanteIzquierdo.Garantia;
                    editar = true;
                }
                catch (Exception)
                {
                    //editar = false;
                }
            }
            //MessageBox.Show(Convert.ToString(editar));
        }
    }
}
