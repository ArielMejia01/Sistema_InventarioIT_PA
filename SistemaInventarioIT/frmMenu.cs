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
            //panelDesign();
        }
       

        //Metodo para mostrar los paneles
        private void mostrarPaneles(Panel panel)
        {
            if (panel.Visible == false) // si el panel estuviese oculto lo mostraremos
            {
                //ocultarPaneles(); // llamar metodo para ocultar pane si hubiese algun otro abierto
                panel.Visible = true; // mostramos el panel
            }
            else
                panel.Visible = false;

        }


        private Form formularioAbierto = null;
        //Metodo para abrir los formularios en el panelInventario
        private void formularioHijoAbiero(Form formularioHijo)
        {
            if (formularioAbierto != null) // condicion para indicar que si existe un formulario abierto lo cerramos
                formularioAbierto.Close();
            formularioAbierto = formularioHijo; // guardamos el formulario que se a abierto en la variable creada
            formularioHijo.TopLevel = false; // Indicar que este formulario abierto no es superior
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // quitar borde del formulario via codigo
            formularioHijo.Dock = DockStyle.Fill;
            panelInventario.Controls.Add(formularioHijo); // agregar el formulario al panel principal
            panelInventario.Tag = formularioHijo; // juntar el formulario al panel
            formularioHijo.BringToFront(); // Nos ayudara a traer al frente al formulario en caso que sea necesario
            formularioHijo.Show(); 
        }        

        //Llamando al formulario que se quiere abrir al presionar el boton.
        private void ibUbicación_Click(object sender, EventArgs e)
        {
            formularioHijoAbiero(new frmUbicacion());
        }

        private void ibEstanteCentro_Click(object sender, EventArgs e)
        {
            //formularioHijoAbiero(new Estante_Izquierdo.frmIzquierdaPlaza1());
            formularioHijoAbiero(new frmSalidas());
        }

        private void ibPlaza_Click(object sender, EventArgs e)
        {
            formularioHijoAbiero(new frmPlaza());
        }

        private void ibInventario_Click(object sender, EventArgs e)
        {
            formularioHijoAbiero(new frmInventario());
        }

        private void ibCategoria_Click(object sender, EventArgs e)
        {
            formularioHijoAbiero(new frmCategoria());
        }

        private void ibEstado_Click(object sender, EventArgs e)
        {
            formularioHijoAbiero(new frmEstado());
        }

        private void ibReporte_Click(object sender, EventArgs e)
        {
            formularioHijoAbiero(new frmReporte());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelInventario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
