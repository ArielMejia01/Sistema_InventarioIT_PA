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
        int vacio;
        int contador = 0;        
        public frmInventario()
        {
            InitializeComponent();
        }

        //Carga del formulario con los datos
        private void frmInventario_Load(object sender, EventArgs e)
        {
            carga_form();
            vacio = 1;            
        }

        //Metodo para agregar un registro en el sistema
        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre del articulo!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese una cantidad!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(txtCantidad.Text) <= 0)
            {
                MessageBox.Show("¡Ingrese una cantidad valida!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                       
            if (editar)
            {

                var tInventario = entityInventario.Inventario.FirstOrDefault(i => i.IdInventario == idInventario);
                tInventario.Nombre = txtNombre.Text;
                tInventario.Ubicacion = Convert.ToInt32(cmbUbicacion.SelectedValue);
                tInventario.Plaza = Convert.ToInt32(cmbPlaza.SelectedValue);
                tInventario.Serial = txtSerial.Text;
                tInventario.Descripcion = txtDescripcion.Text;
                tInventario.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tInventario.Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                tInventario.Estado = Convert.ToInt32(cmbEstado.SelectedValue);                           
                tInventario.Modelo = txtModelo.Text;
                tInventario.Garantia = dtFecha.Value;
                tInventario.Salida = false;
                tInventario.Destino = "";

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
                inventario.Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                inventario.Estado = Convert.ToInt32(cmbEstado.SelectedValue);               
                inventario.Modelo = txtModelo.Text;
                inventario.Garantia = dtFecha.Value;
                inventario.Salida = false;
                inventario.Destino = "";



                entityInventario.Inventario.Add(inventario);
                entityInventario.SaveChanges();                
                MessageBox.Show("¡Datos Guardados!");
                carga_form();
            }
            idInventario = 0;
            editar = false;
            carga_form();
            cleanText();
        }

        //Metodo para seleccionar un campo dentro del datagrid
        private void dgInventario_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idInventario = Convert.ToInt32(dgInventario.SelectedCells[0].Value);
                var tInventario = entityInventario.Inventario.FirstOrDefault(x => x.IdInventario == idInventario);
                txtNombre.Text = tInventario.Nombre;
                cmbUbicacion.SelectedValue = tInventario.Ubicacion;
                cmbPlaza.SelectedValue = tInventario.Plaza;
                txtSerial.Text = tInventario.Serial;
                txtDescripcion.Text = tInventario.Descripcion;
                txtCantidad.Text = Convert.ToString(tInventario.Cantidad);
                cmbCategoria.SelectedValue = tInventario.Categoria;
                cmbEstado.SelectedValue = tInventario.Estado;
                txtModelo.Text = tInventario.Modelo;
                dtFecha.Value = (DateTime)tInventario.Garantia;
                editar = true;
            }
            catch (Exception)
            {
                dgInventario.ClearSelection();
            }            
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }

        /*Metodo para cargar todos los datos en el formulario, este metodo sera llamado en el
        form del sistema, carga de los combobox de ubicacion, plaza, estado y categoria*/
        private void carga_form()
        {
            var ubicacion = from u in entityInventario.Ubicacion
                            where u.Estado_Ubicacion == true
                            select u;
            DataTable dtUbicacion = new DataTable();
            dtUbicacion = ubicacion.CopyAnonymusToDataTable();

            cmbUbicacion.DataSource = dtUbicacion;
            cmbUbicacion.DisplayMember = dtUbicacion.Columns[1].ColumnName;
            cmbUbicacion.ValueMember = dtUbicacion.Columns[0].ColumnName;

            var plaza = from p in entityInventario.Plaza
                        where p.Estado_Plaza == true
                        select p;
            DataTable dtPlaza = new DataTable();
            dtPlaza = plaza.CopyAnonymusToDataTable();
            cmbPlaza.DataSource = dtPlaza;
            cmbPlaza.DisplayMember = dtPlaza.Columns[1].ColumnName;
            cmbPlaza.ValueMember = dtPlaza.Columns[0].ColumnName;

            var categoria = from c in entityInventario.Categoria
                            where c.Estado_Categoria == true
                            select c;
            DataTable dtCategoria = new DataTable();
            dtCategoria = categoria.CopyAnonymusToDataTable();
            cmbCategoria.DataSource = dtCategoria;
            cmbCategoria.DisplayMember = dtCategoria.Columns[1].ColumnName;
            cmbCategoria.ValueMember = dtCategoria.Columns[0].ColumnName;

            var estado = from e in entityInventario.Estado
                         where e.Estado_Estado == true
                         select e;
            DataTable dtEstado = new DataTable();
            dtEstado = estado.CopyAnonymusToDataTable();
            cmbEstado.DataSource = dtEstado;
            cmbEstado.DisplayMember = dtEstado.Columns[1].ColumnName;
            cmbEstado.ValueMember = dtEstado.Columns[0].ColumnName;

           
            var inventario = from i in entityInventario.Inventario
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
                                   i.Salida
                               };

            dgInventario.DataSource = inventario.CopyAnonymusToDataTable();
            dgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cleanText()
        {
            txtNombre.Text = "";
            txtSerial.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";           
            txtModelo.Text = "";
            idInventario = 0;
            editar = false;          
            dgInventario.ClearSelection();
        }
        
        //Busqueda de un articulo dentro del inventario por su nombre
        private void FiltrarInventario(string nombre)
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
                                  i.Salida
                              };
            dgInventario.DataSource = fInventario.CopyAnonymusToDataTable();
            dgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarInventario(txtBuscar.Text);            
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "Buscar...")
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

        private void dgInventario_MouseClick(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void dgInventario_MouseMove(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }
        /*Metodo para filtrar la plaza por medio de la ubicacion.
         a forma de que el usuario solo pueda seleccionar las plazas disponibles por 
         ubicacion*/
        private void cmbUbicacion_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cmbUbicacion.SelectedIndex==0)
            {                
                if (contador > 2)
                {
                    int r = Convert.ToInt32(cmbUbicacion.SelectedValue);
                    //MessageBox.Show(Convert.ToString(cmbUbicacion.SelectedValue));

                    var plaza = from p in entityInventario.Plaza
                                where p.Ubicacion == r
                                select p;
                    DataTable dtPlaza = new DataTable();
                    dtPlaza = plaza.CopyAnonymusToDataTable();
                    cmbPlaza.DataSource = dtPlaza;
                    cmbPlaza.DisplayMember = dtPlaza.Columns[1].ColumnName;
                    cmbPlaza.ValueMember = dtPlaza.Columns[0].ColumnName;
                }
                else
                {
                    contador = contador + 1;
                }
                
                //MessageBox.Show(Convert.ToString(cmbUbicacion.SelectedValue));               
            }
            else
            {
                int r = Convert.ToInt32(cmbUbicacion.SelectedValue);                                
                var plaza = from p in entityInventario.Plaza
                            where p.Ubicacion == r
                            select p;
                DataTable dtPlaza = new DataTable();
                dtPlaza = plaza.CopyAnonymusToDataTable();
                cmbPlaza.DataSource = dtPlaza;
                cmbPlaza.DisplayMember = dtPlaza.Columns[1].ColumnName;
                cmbPlaza.ValueMember = dtPlaza.Columns[0].ColumnName;
            }                       
        }

        /*Metodo que ayuda a solo validar numeros dentro del textBox de cantidad, para seguridad
        y restriccion al usuario de que una cantidad solo es numero y no texto*/
        public static void validarSoloNumeros(KeyPressEventArgs n)
        {
            if (char.IsDigit(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (char.IsSeparator(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (char.IsControl(n.KeyChar) || n.KeyChar.ToString().Equals("."))
            {
                n.Handled = false;
            }
            else
            {
                n.Handled = true;
                MessageBox.Show("Solo se permite ingresar numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }
    }
}
