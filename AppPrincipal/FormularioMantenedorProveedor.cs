﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class FormularioMantenedorProveedor : Form
    {
        public FormularioMantenedorProveedor()
        {
            InitializeComponent();
        }


        //BOTON CANCELAR EL CUAL ENVIA UN MENSAJE PARA CONFIRMAR EL CIERRE DE LA APLICACION
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("DESEA CERRAR LA APLICACION ? ","",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);

                MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
                DialogResult dr = MessageBox.Show("¿Está seguro que desea salir?", "", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Error al cerrar Aplicacion");
            }
        }

        //PRUEBA
        /*private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            Prueba sp = new Prueba();
            sp.GetResource();
        }*/
    }
}
