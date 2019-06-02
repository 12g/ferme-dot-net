namespace AppPrincipal
{
    partial class FromularioVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromularioVentas));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.RbBoleta = new System.Windows.Forms.RadioButton();
            this.RbFactura = new System.Windows.Forms.RadioButton();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.LblNumeroDocumento = new System.Windows.Forms.Label();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblDni = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.LblNombreRazonSocial = new System.Windows.Forms.Label();
            this.TxtNombreRazonSocial = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.DgVentaProducto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnNuevVenta = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgVentaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(322, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(271, 42);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "REALIZAR VENTA";
            // 
            // RbBoleta
            // 
            this.RbBoleta.AutoSize = true;
            this.RbBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbBoleta.Location = new System.Drawing.Point(12, 63);
            this.RbBoleta.Name = "RbBoleta";
            this.RbBoleta.Size = new System.Drawing.Size(86, 28);
            this.RbBoleta.TabIndex = 6;
            this.RbBoleta.TabStop = true;
            this.RbBoleta.Text = "Boleta";
            this.RbBoleta.UseVisualStyleBackColor = true;
            // 
            // RbFactura
            // 
            this.RbFactura.AutoSize = true;
            this.RbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFactura.Location = new System.Drawing.Point(104, 63);
            this.RbFactura.Name = "RbFactura";
            this.RbFactura.Size = new System.Drawing.Size(98, 28);
            this.RbFactura.TabIndex = 7;
            this.RbFactura.TabStop = true;
            this.RbFactura.Text = "Factura";
            this.RbFactura.UseVisualStyleBackColor = true;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(16, 155);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(42, 13);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(15, 171);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.ReadOnly = true;
            this.TxtFecha.Size = new System.Drawing.Size(116, 20);
            this.TxtFecha.TabIndex = 9;
            // 
            // LblNumeroDocumento
            // 
            this.LblNumeroDocumento.AutoSize = true;
            this.LblNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroDocumento.Location = new System.Drawing.Point(12, 106);
            this.LblNumeroDocumento.Name = "LblNumeroDocumento";
            this.LblNumeroDocumento.Size = new System.Drawing.Size(89, 13);
            this.LblNumeroDocumento.TabIndex = 10;
            this.LblNumeroDocumento.Text = "N° Documento";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(12, 122);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(187, 20);
            this.TxtNumeroDocumento.TabIndex = 11;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(205, 119);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(104, 23);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "Buscar Venta";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDni.Location = new System.Drawing.Point(379, 106);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(29, 13);
            this.LblDni.TabIndex = 13;
            this.LblDni.Text = "DNI";
            // 
            // TxtRut
            // 
            this.TxtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.Location = new System.Drawing.Point(382, 122);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.ReadOnly = true;
            this.TxtRut.Size = new System.Drawing.Size(187, 20);
            this.TxtRut.TabIndex = 14;
            // 
            // BtnCliente
            // 
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(575, 119);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(104, 23);
            this.BtnCliente.TabIndex = 15;
            this.BtnCliente.Text = "Buscar Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            // 
            // LblNombreRazonSocial
            // 
            this.LblNombreRazonSocial.AutoSize = true;
            this.LblNombreRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreRazonSocial.Location = new System.Drawing.Point(379, 155);
            this.LblNombreRazonSocial.Name = "LblNombreRazonSocial";
            this.LblNombreRazonSocial.Size = new System.Drawing.Size(140, 13);
            this.LblNombreRazonSocial.TabIndex = 16;
            this.LblNombreRazonSocial.Text = "Nombre o Razon Social";
            // 
            // TxtNombreRazonSocial
            // 
            this.TxtNombreRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreRazonSocial.Location = new System.Drawing.Point(382, 171);
            this.TxtNombreRazonSocial.Name = "TxtNombreRazonSocial";
            this.TxtNombreRazonSocial.ReadOnly = true;
            this.TxtNombreRazonSocial.Size = new System.Drawing.Size(187, 20);
            this.TxtNombreRazonSocial.TabIndex = 17;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(16, 212);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 13);
            this.LblCodigo.TabIndex = 18;
            this.LblCodigo.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(12, 228);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(232, 20);
            this.TxtCodigo.TabIndex = 19;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(272, 212);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 20;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(275, 228);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(269, 20);
            this.TxtNombreProducto.TabIndex = 21;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProducto.Location = new System.Drawing.Point(550, 228);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(117, 23);
            this.BtnBuscarProducto.TabIndex = 22;
            this.BtnBuscarProducto.Text = "Buscar Producto";
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(721, 212);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(57, 13);
            this.LblCantidad.TabIndex = 23;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(724, 231);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(141, 20);
            this.TxtCantidad.TabIndex = 24;
            // 
            // DgVentaProducto
            // 
            this.DgVentaProducto.AllowUserToAddRows = false;
            this.DgVentaProducto.AllowUserToDeleteRows = false;
            this.DgVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVentaProducto.Location = new System.Drawing.Point(19, 257);
            this.DgVentaProducto.Name = "DgVentaProducto";
            this.DgVentaProducto.ReadOnly = true;
            this.DgVentaProducto.Size = new System.Drawing.Size(853, 205);
            this.DgVentaProducto.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(897, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Gold;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(897, 317);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(109, 41);
            this.BtnEditar.TabIndex = 28;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.Red;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(897, 381);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(109, 41);
            this.BtnBorrar.TabIndex = 29;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(12, 500);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(120, 39);
            this.LblTotal.TabIndex = 30;
            this.LblTotal.Text = "Total :";
            // 
            // BtnNuevVenta
            // 
            this.BtnNuevVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevVenta.Location = new System.Drawing.Point(747, 498);
            this.BtnNuevVenta.Name = "BtnNuevVenta";
            this.BtnNuevVenta.Size = new System.Drawing.Size(125, 41);
            this.BtnNuevVenta.TabIndex = 31;
            this.BtnNuevVenta.Text = "Nueva venta";
            this.BtnNuevVenta.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(897, 498);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(109, 41);
            this.BtnCerrar.TabIndex = 32;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(322, 484);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(271, 55);
            this.BtnImprimir.TabIndex = 33;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(121, 492);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(175, 47);
            this.TxtTotal.TabIndex = 34;
            // 
            // FromularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 541);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnNuevVenta);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgVentaProducto);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.BtnBuscarProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.TxtNombreRazonSocial);
            this.Controls.Add(this.LblNombreRazonSocial);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtNumeroDocumento);
            this.Controls.Add(this.LblNumeroDocumento);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.RbFactura);
            this.Controls.Add(this.RbBoleta);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FromularioVentas";
            this.Text = "FromularioVentas";
            this.Load += new System.EventHandler(this.FromularioVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgVentaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.RadioButton RbBoleta;
        private System.Windows.Forms.RadioButton RbFactura;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label LblNumeroDocumento;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Label LblNombreRazonSocial;
        private System.Windows.Forms.TextBox TxtNombreRazonSocial;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnNuevVenta;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.TextBox TxtTotal;
        public System.Windows.Forms.TextBox TxtCodigo;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        public System.Windows.Forms.DataGridView DgVentaProducto;
    }
}