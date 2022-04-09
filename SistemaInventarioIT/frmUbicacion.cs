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
    public partial class frmUbicacion : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        public frmUbicacion()
        {
            InitializeComponent();
        }

        private void frmUbicacion_Load(object sender, EventArgs e)
        {
            var iUbicacion = from i in entityInventario.Ubicacion
                             select new
                             {
                                 i.IdUbicacion,
                                 i.Nombre_Ubicacion,
                                 i.Descripcion
                             };
        }
    }
}
