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
        public frmIzquierdaPlaza1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void frmIzquierdaPlaza1_Load(object sender, EventArgs e)
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

            //Cargar la informacion al "cargar" el formulario
            var izquierdaUno = from i in entityInventario.Inventario
                               select new
                               {
                                   i.IdInventario,
                                   i.Nombre,
                                   i.Ubicacion,
                                   i.Plaza,
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
    }
}
