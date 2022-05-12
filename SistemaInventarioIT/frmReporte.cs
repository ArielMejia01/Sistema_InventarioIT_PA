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
    public partial class frmReporte : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        public frmReporte()
        {
            InitializeComponent();
        }     

        public void ExportarDatos(DataGridView dataListado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();

            exportarExcel.Application.Workbooks.Add(true);

            int indiceColumna = 0;

            foreach (DataGridViewColumn columna in dataListado.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow fila in dataListado.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in dataListado.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }

        private void ibExportarExcel_Click(object sender, EventArgs e)
        {
            //ExportarDatos(dgReporte);
            ExportarDatos(dgReporte);
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            cargaForm();
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
                         //where s.Salida == false
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
            dgReporte.DataSource = salida.CopyAnonymusToDataTable();
            dgReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
