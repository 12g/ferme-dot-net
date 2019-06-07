using System;
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
    public partial class FromularioVentas : Form
    {
        public FromularioVentas()
        {
            InitializeComponent();
            CargarCbEmpleado();
            TxtSubtotal.Text = "0";
            TxtIva.Text = "0";
            TxtTotal.Text = "0";
         
        }

        private void FromularioVentas_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FormularioBuscarProducto fbp = new FormularioBuscarProducto(this);
            fbp.ShowDialog();
        }

        //limpias el campo de codigo , nombre y cantidad de producto
        private void Limpiar()
        {
            TxtCodigo.Text = "";
            TxtCantidad.Text = "";
            TxtNombreProducto.Text = "";
            TxtPrecio.Text = "";
        }

        //AGREGAR PRODUCTO AL DATAGRIDVIEW
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            try
            {
                if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
                {
                    LblCantidadObligatoria.Visible = true;
                    MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
                }
                else if (TxtCodigo.Text == "" || TxtNombreProducto.Text == "" || TxtPrecio.Text == "")
                {
                    MessageBox.Show("INGRESE UN PRODUCTO");
                }
                else
                {
                    try
                    {
                        DgVentaProducto.Rows.Add(TxtCodigo.Text, TxtNombreProducto.Text, TxtCantidad.Text,TxtPrecio.Text);

                        cantidadprecio();

                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL AGREGAR PRODUCTOS A LA LISTA");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL AGREGAR PRODUCTOS A LA LISTA");
            }
          
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();

                if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
                {
                    LblCantidadObligatoria.Visible = true;
                    MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
                }
                else if (TxtCodigo.Text == "" || TxtNombreProducto.Text == "")
                {
                    MessageBox.Show("INGRESE UN PRODUCTO");
                }
                else
                {
                    try
                    {
                        int poc = DgVentaProducto.CurrentRow.Index;
                        DgVentaProducto[0, poc].Value = TxtCodigo.Text;
                        DgVentaProducto[1, poc].Value = TxtNombreProducto.Text;
                        DgVentaProducto[2, poc].Value = TxtCantidad.Text;

                        cantidadprecio();

                        Limpiar();
                        BtnAgregar.Enabled = true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("NO SE PUEDE AGREGAR PRODUCTOS A LA LISTA");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL AGREGAR PRODUCTO");
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int poc = DgVentaProducto.CurrentRow.Index;
                DgVentaProducto.Rows.RemoveAt(poc);
                cantidadprecio();

                Limpiar();
                BtnAgregar.Enabled = true;
                MessageBox.Show("PRODUCTO BORRADO");
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL ELIMINAR PRODUCTO");
            }
        }

        private void DgVentaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poc = DgVentaProducto.CurrentRow.Index;
            TxtCodigo.Text = DgVentaProducto[0, poc].Value.ToString();
            TxtNombreProducto.Text = DgVentaProducto[1, poc].Value.ToString();
            TxtCantidad.Text = DgVentaProducto[2, poc].Value.ToString();

            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnBorrar.Enabled = true;
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FormularioBuscarCliente frm = new FormularioBuscarCliente(this);
            frm.ShowDialog();
        }



        //CALCULA EL SUBTOTAL Y EL TOTAL AL AGREGAR UN PRODUCTO 
        private void cantidadprecio()
        {
            //MULTIPLICA LA CANTIDAD * PRECIO
            for (int i = 0; i < DgVentaProducto.Rows.Count; i++)
            {
                int num1 = int.Parse(Convert.ToString(DgVentaProducto.Rows[i].Cells[2].Value));
                int num2 = int.Parse(Convert.ToString(DgVentaProducto.Rows[i].Cells[3].Value));
                DgVentaProducto.Rows[i].Cells[4].Value = num1 * num2;
            }



            //SUMA LA  COLUMNA SUBTOTAL Y LA MUESTRA EN EL TXTSUBTOTAL
            int suma = 0;

            foreach (DataGridViewRow row in DgVentaProducto.Rows)
            {
                if (row.Cells[4].Value == DBNull.Value)
                    continue;

                int valorcell = 0;
                int.TryParse(Convert.ToString(row.Cells[4].Value), out valorcell);

                suma += Convert.ToInt32(valorcell);
            }

            TxtSubtotal.Text = Convert.ToString(suma);
            TxtIva.Text = Convert.ToString(suma * 19 / 100);
            TxtTotal.Text = Convert.ToString(suma * 19 / 100 + suma);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormularioBuscarVenta fbv = new FormularioBuscarVenta(this);
            fbv.ShowDialog();
        }

        private void CargarCbEmpleado()
        {
            try
            {
                ServicioEmpleado see = new ServicioEmpleado();
                CbEmpleado.DataSource = see.ListaEmpleados();
                CbEmpleado.DisplayMember = "nombreCompletoPersona";
                CbEmpleado.ValueMember = "idEmpleado";

                if (CbEmpleado.Items.Count > 1)
                {
                    CbEmpleado.SelectedIndex = -1;
                    CbEmpleado.Text = "Seleccione";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY DATOS DE EMPLEADOS");
            }
           
        }

        //ENUMERA LAS FILAS EN EL DATAGRIDVIEW AL INGRESAR PRODUCTOS
        private void DgVentaProducto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }
    }
    
}
