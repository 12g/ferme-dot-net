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

namespace AppPrincipal
{
    public partial class FormularioProveedor : Form
    {
        public FormularioProveedor()
        {
            InitializeComponent();
        }

        //BOTON PARA CERRAR EL FORMULARIO PRINCIAL DE PROVEEDORES
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON QUE LLAMA AL FORMULARIO MANTENEDOR DE PROVEEDOR PARA CREAR
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorProveedor fmp = new FormularioMantenedorProveedor();
            fmp.ShowDialog();
        }

        //BOTON EDITAR/METODO PARA SELECCIONAR UN PRODUCTO DE LA LISTA Y EDITARLO
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioMantenedorProveedor fmp = new FormularioMantenedorProveedor();
                if (DgMostrarListaProveedor.SelectedRows.Count > 0)
                {
                    fmp.TxtRut.Text = DgMostrarListaProveedor.CurrentRow.Cells[0].Value.ToString();
                    fmp.TxtRazonSocial.Text = DgMostrarListaProveedor.CurrentRow.Cells[1].Value.ToString();
                    fmp.TxtTelefono.Text = DgMostrarListaProveedor.CurrentRow.Cells[3].Value.ToString();
                    fmp.CbRubro.SelectedText = DgMostrarListaProveedor.CurrentRow.Cells[4].Value.ToString();

                    fmp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL EDITAR LA FILA");
            }
        }

        private void BtnRubro_Click(object sender, EventArgs e)
        {
            FormularioMantenedorRubro fmr = new FormularioMantenedorRubro();
            fmr.ShowDialog();
        }
    }
}
