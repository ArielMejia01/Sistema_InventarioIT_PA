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

            var tEstanteIzquierdo = from t in entityInventario.Inventario
                                    select new
                                    {
                                        t.IdInventario,
                                        t.Nombre,
                                        t.Ubicacion,
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
    }
}
