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
    public partial class frmSalidas : Form
    {
        DBInventarioITPAEntities entityInventario = new DBInventarioITPAEntities();
        int idInventario = 0;
        int vacio;
        bool editar = false;
        public frmSalidas()
        {
            InitializeComponent();
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {

        }

        private void ibVerSalidas_Click(object sender, EventArgs e)
        {
            frmVerSalidas salidas = new frmVerSalidas();
            salidas.Show();
        }

        private void frmSalidas_Load(object sender, EventArgs e)
        {
            carga_form();
            vacio = 1;
        }

        private void carga_form()
        {
            /*var ubicacion = from u in entityInventario.Ubicacion
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
            cmbEstado.ValueMember = dtEstado.Columns[0].ColumnName;*/


            var inventario = from i in entityInventario.Inventario
                             join y
                             in entityInventario.Ubicacion on i.Ubicacion equals y.IdUbicacion
                             join p
                             in entityInventario.Plaza on i.Plaza equals p.IdPlaza
                             join c
                             in entityInventario.Categoria on i.Categoria equals c.IdCategoria
                             join e
                             in entityInventario.Estado on i.Estado equals e.IdEstado
                             where i.Salida == true
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
                                 i.Salida,
                                 i.Destino
                             };

            dgSalida.DataSource = inventario.CopyAnonymusToDataTable();
            dgSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgSalida_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (vacio == 1)
                {
                    cleanText();
                }
                idInventario = Convert.ToInt32(dgSalida.SelectedCells[0].Value);
                var tInventario = entityInventario.Inventario.FirstOrDefault(x => x.IdInventario == idInventario);
                //txtNombre.Text = tInventario.Nombre;
                //cmbUbicacion.SelectedValue = tInventario.Ubicacion;
                //cmbPlaza.SelectedValue = tInventario.Plaza;
                //txtSerial.Text = tInventario.Serial;
                //txtDescripcion.Text = tInventario.Descripcion;
                //txtCantidad.Text = Convert.ToString(tInventario.Cantidad);
                //cmbCategoria.SelectedValue = tInventario.Categoria;
                //cmbEstado.SelectedValue = tInventario.Estado;
                //txtModelo.Text = tInventario.Modelo;
                //dtFecha.Value = (DateTime)tInventario.Garantia;
                chkSalida.Checked = Convert.ToBoolean(tInventario.Salida);
                txtDestino.Text = tInventario.Destino;
                editar = true;
            }
            catch (Exception)
            {
                dgSalida.ClearSelection();
            }
        }

        private void cleanText()
        {
            //txtNombre.Text = "";
            //txtSerial.Text = "";
            //txtDescripcion.Text = "";
            //txtCantidad.Text = "";
            //txtCategoria.Text = "";
            //chkEstado.Checked = false;
            //txtModelo.Text = "";
            //idInventario = 0;
            //editar = false;
            //txtBuscar.Text = string.Empty;
            //txtBuscar.Text = "";
            //dgInventario.ClearSelection();
            chkSalida.Checked = false;
            txtDestino.Text = "";
            editar = false;
            dgSalida.ClearSelection();
        }

        private void ibNuevo_Click(object sender, EventArgs e)
        {
            cleanText();
        }
    }
}