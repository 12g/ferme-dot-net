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
    public partial class FormularioUsuario : Form
    {
        public FormularioUsuario()
        {
            InitializeComponent();
            
            try
            {
                ServicioEmpleado sere = new ServicioEmpleado();
                DGlistadoUsuario.DataSource = sere.ListaEmpleados();
                this.DGlistadoUsuario.Columns[0].Visible = false;
                this.DGlistadoUsuario.Columns[8].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LOS DATOS EN MODULO DE USUARIO");
            }
        }

        //BOTON QUE CIERRA EL FORMULARIO DE USUARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CREAR USUARIO EL CUAL LLAMA AL FORMULARIO MANTENEDOR DE USUARIO
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorUsuario fmu = new FormularioMantenedorUsuario();
            fmu.ShowDialog();
        }

        //CREAR CARGO
        private void BtnCargo_Click(object sender, EventArgs e)
        {
            FormularioMantenedorCargo car = new FormularioMantenedorCargo();
            car.ShowDialog();
        }

        //CREAR EMPLEADO
        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            FormularioMantenedorEmpleado fme = new FormularioMantenedorEmpleado();
            fme.ShowDialog();
        }

        //ACTUALIZA EL DATAGRIDVIEW
        /*private void FormularioUsuario_Load(object sender, EventArgs e)
        {
           Timer actualizar_automatico = new Timer();
           actualizar_automatico.Interval = 30000;
           actualizar_automatico.Tick += actualizar_automatico_Tick;
           actualizar_automatico.Enabled = true;
        }

        private void recargar()
        {
           ServicioEmpleado ser = new ServicioEmpleado();
           DGlistadoUsuario.DataSource = ser.ListaEmpleados();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
          recargar();
        }
        */
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioEmpleado ser = new ServicioEmpleado();
                FormularioMantenedorEmpleado fmp = new FormularioMantenedorEmpleado();
                if (DGlistadoUsuario.SelectedRows.Count > 0)
                {
                    fmp.TxtRutCliente.Text = DGlistadoUsuario.CurrentRow.Cells[2].Value.ToString();
                    fmp.CbxCargo.Text = DGlistadoUsuario.CurrentRow.Cells[9].Value.ToString();
                    fmp.TxtNombre.Text = DGlistadoUsuario.CurrentRow.Cells[1].Value.ToString();

                    fmp.TxtDireccion.Text = DGlistadoUsuario.CurrentRow.Cells[3].Value.ToString();
                    fmp.TxtEmail.Text = DGlistadoUsuario.CurrentRow.Cells[4].Value.ToString();
                    fmp.TxtTelefeno1.Text = DGlistadoUsuario.CurrentRow.Cells[5].Value.ToString();
                    fmp.TxtTelefono2.Text = DGlistadoUsuario.CurrentRow.Cells[6].Value.ToString();
                    fmp.TxtTelefono3.Text = DGlistadoUsuario.CurrentRow.Cells[7].Value.ToString();

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
    }
}
