﻿using System;
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
        bool edit = false;
        long idUbicacion = 0;
        int vacio;
        public frmUbicacion()
        {
            InitializeComponent();
        }
        //Cargando los datos al formulario de ubicacion
        private void frmUbicacion_Load(object sender, EventArgs e)
        {
            carga_form();
            vacio = 1;
        }


        //metodo para agregar un registro, editar un campo y asi mismo alertas de seguridad en los textBox
        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (txtUbicacion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre de la ubicación!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese la descripción de la ubicación!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (edit)
            {
                var tUbicacion = entityInventario.Ubicacion.FirstOrDefault(u => u.IdUbicacion == idUbicacion);
                tUbicacion.Nombre_Ubicacion = txtUbicacion.Text;
                tUbicacion.Descripcion = txtDescripcion.Text;
                tUbicacion.Estado_Ubicacion = chkEstado.Checked;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados Correctamente!");
            }
            else
            {
                Ubicacion tNombreUbicacion = new Ubicacion();
                tNombreUbicacion.Nombre_Ubicacion = txtUbicacion.Text;
                tNombreUbicacion.Descripcion = txtDescripcion.Text;
                tNombreUbicacion.Estado_Ubicacion = chkEstado.Checked;
                entityInventario.Ubicacion.Add(tNombreUbicacion);
                entityInventario.SaveChanges();
                MessageBox.Show("¡Datos Guardados Correctamente!");
            }
            idUbicacion = 0;
            edit = false;
            carga_form();
            cleanText();          
        }

        //seleccionar un registro dentro del datagrid
        private void dgUbicacion_SelectionChanged(object sender, EventArgs e)
        {       
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idUbicacion = (int)Convert.ToInt64(dgUbicacion.SelectedCells[0].Value);
                //idUbicacion = Convert.ToInt64(dgUbicacion.SelectedCells[0].Value);
                var tUbicacion = entityInventario.Ubicacion.FirstOrDefault(x => x.IdUbicacion == idUbicacion);
                txtUbicacion.Text = tUbicacion.Nombre_Ubicacion;
                txtDescripcion.Text = tUbicacion.Descripcion;
                chkEstado.Checked = tUbicacion.Estado_Ubicacion;
                edit = true;
            }
            catch (Exception)
            {
                dgUbicacion.ClearSelection();
            }

        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }

        //metodo que sera llamado en el load del formulario para cargar todos los datos dentro del formulario
        private void carga_form()
        {
            var iUbicacion = from i in entityInventario.Ubicacion
                             select new
                             {
                                 i.IdUbicacion,
                                 i.Nombre_Ubicacion,
                                 i.Descripcion,
                                 i.Estado_Ubicacion
                             };
            dgUbicacion.DataSource = iUbicacion.CopyAnonymusToDataTable();
            dgUbicacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cleanText()
        {
            txtUbicacion.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            edit = false;
            dgUbicacion.ClearSelection();
        }                   
       
        private void dgUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void dgUbicacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (vacio == 1)
            {
                vacio = 2;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarUbicacion(txtBuscar.Text);
        }

        //Metodo para buscar una ubicacion por medio del nombre de la misma
        private void FiltrarUbicacion(string nombre)
        {
            var fUbicacion = from i in entityInventario.Ubicacion
                             where i.Nombre_Ubicacion.Contains(nombre)
                             select new
                             {
                                 i.IdUbicacion,
                                 i.Nombre_Ubicacion,
                                 i.Descripcion,
                                 i.Estado_Ubicacion
                             };
            dgUbicacion.DataSource = fUbicacion.CopyAnonymusToDataTable();
            dgUbicacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
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
    }
}
