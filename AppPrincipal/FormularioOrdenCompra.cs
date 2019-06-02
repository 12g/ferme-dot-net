﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using ServiciosConexionFerme;

namespace AppPrincipal
{
    public partial class FormularioOrdenCompra : Form
    {
        public FormularioOrdenCompra()
        {
            InitializeComponent();
            ListarOrdenCompra();
        }


        //carga lista orden de compra en datagridview
        public void ListarOrdenCompra()
        {
            try
            {
                ServicioOrdenCompra seroc = new ServicioOrdenCompra();
                DGlistadoOrdenCompra.DataSource = seroc.ListarOrdenCompra();
                this.DGlistadoOrdenCompra.Columns[5].Visible = false;


                //DA NOMBRE A LAS COLUMNAS
                this.DGlistadoOrdenCompra.Columns[0].HeaderText = "N° ORDEN COMPRA               ";
                this.DGlistadoOrdenCompra.Columns[1].HeaderText = "EMPLEADO                                    ";
                this.DGlistadoOrdenCompra.Columns[2].HeaderText = "ESTADO";
                this.DGlistadoOrdenCompra.Columns[3].HeaderText = "FECHA CREACION                ";
                this.DGlistadoOrdenCompra.Columns[4].HeaderText = "FECHA RECEPCION               ";
                //this.DGlistadoOrdenCompra.Columns[5].HeaderText = "DETALLE";
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY DATOS EN ORDEN DE COMPRA");
            }
        }

        //BOTON CERRAR EL FORMULARIO DE ORDEN DE COMPRA
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BOTON CREAR ORDEN DE COMPRA
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorOrdenCompra fmoc = new FormularioMantenedorOrdenCompra();
            fmoc.ShowDialog();
        }


        //TIEMPO DE ACTUALIZACION DE LA LISTA DE ORDEN DE COMPRA
        private void FormularioOrdenCompra_Load(object sender, EventArgs e)
        {
            Timer actualizar_automatico = new Timer();
            actualizar_automatico.Interval = 3500;
            actualizar_automatico.Tick += actualizar_automatico_Tick;
            actualizar_automatico.Enabled = true;
        }
        private void recargar()
        {
            ServicioOrdenCompra ser = new ServicioOrdenCompra();
            DGlistadoOrdenCompra.DataSource = ser.ListarOrdenCompra();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
            recargar();
        }


        //BUSCAR
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DGlistadoOrdenCompra.CurrentCell = null;
                foreach (DataGridViewRow r in DGlistadoOrdenCompra.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DGlistadoOrdenCompra.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(TxtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }

                }
            }
            else
            {
                ServicioOrdenCompra ser = new ServicioOrdenCompra();
                DGlistadoOrdenCompra.DataSource = ser.ListarOrdenCompra();
            }
        }
    }
}
