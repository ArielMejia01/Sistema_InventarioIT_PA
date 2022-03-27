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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //En el constructor llamaremos el metodo creado.
            panelDesign();
        }

        //Metodo para ocultar los paneles subEstanteIzquierdo y subEstanteCentro.
        private void panelDesign()
        {
            panelSubEstanteCentro.Visible = false;
            panelSubEstanteIzquierdo.Visible = false;
        }

        //Metodo para ocultar los paneles que se han mostrado anteriormente.
        private void ocultarPaneles()
        {
            if (panelSubEstanteIzquierdo.Visible == true)
                panelSubEstanteIzquierdo.Visible = false;
            if (panelSubEstanteCentro.Visible == true)
                panelSubEstanteCentro.Visible = false;
        }

        //Metodo para mostrar los paneles
        private void mostrarPaneles(Panel panel)
        {
            if (panel.Visible == false)
            {
                ocultarPaneles();
                panel.Visible = true;
            }
            else
                panel.Visible = false;

        }
        private void btnEstanteIzquierdo_Click(object sender, EventArgs e)
        {
            mostrarPaneles(panelSubEstanteIzquierdo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnPlaza2_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnPlaza3_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnPlaza4_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnEstanteCentro_Click(object sender, EventArgs e)
        {
            mostrarPaneles(panelSubEstanteCentro);
        }

        private void btnCentro1_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnCentro2_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnCentro3_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnCentro4_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnCentro5_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnCentro6_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
        }
    }
}
