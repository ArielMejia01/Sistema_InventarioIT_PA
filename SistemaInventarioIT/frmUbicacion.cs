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
        int idUbicacion = 0;
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
            dgUbicacion.DataSource = iUbicacion.CopyAnonymusToDataTable();
            dgUbicacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            if (txtUbicacion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre de la ubicación!");
                return;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese la descripción de la ubicación!");
                return;
            }
            if (edit)
            {
                var tUbicacion = entityInventario.Ubicacion.FirstOrDefault(u => u.IdUbicacion == idUbicacion);
                tUbicacion.Nombre_Ubicacion = txtUbicacion.Text;
                tUbicacion.Descripcion = txtDescripcion.Text;
                entityInventario.SaveChanges();
                MessageBox.Show("¡Cambios Guardados!");
            }
            else
            {
                Ubicacion tNombreUbicacion = new Ubicacion();
                tNombreUbicacion.Nombre_Ubicacion = txtUbicacion.Text;
                tNombreUbicacion.Descripcion = txtDescripcion.Text;
                entityInventario.Ubicacion.Add(tNombreUbicacion);
                entityInventario.SaveChanges();
            }
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
