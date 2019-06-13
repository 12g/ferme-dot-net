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
            this.LblFecha = new System.Windows.Forms.Label();
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnNuevVenta = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblCantidadObligatoria = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.CbEmpleado = new System.Windows.Forms.ComboBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.LblIva = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.lblTituloMenu2 = new System.Windows.Forms.Label();
            this.lblTitulomenu = new System.Windows.Forms.Label();
            this.LblIdProducto = new System.Windows.Forms.Label();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.CbTipoDocto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.LblIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgVentaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(322, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(247, 37);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "REALIZAR VENTA";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(450, 83);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(42, 13);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Fecha";
            // 
            // LblNumeroDocumento
            // 
            this.LblNumeroDocumento.AutoSize = true;
            this.LblNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroDocumento.Location = new System.Drawing.Point(12, 83);
            this.LblNumeroDocumento.Name = "LblNumeroDocumento";
            this.LblNumeroDocumento.Size = new System.Drawing.Size(89, 13);
            this.LblNumeroDocumento.TabIndex = 10;
            this.LblNumeroDocumento.Text = "N° Documento";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(104, 80);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(187, 20);
            this.TxtNumeroDocumento.TabIndex = 11;
            this.TxtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDocumento_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(297, 80);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(104, 23);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "Buscar Venta";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDni.Location = new System.Drawing.Point(12, 116);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(29, 13);
            this.LblDni.TabIndex = 13;
            this.LblDni.Text = "DNI";
            // 
            // TxtRut
            // 
            this.TxtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.Location = new System.Drawing.Point(104, 113);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.ReadOnly = true;
            this.TxtRut.Size = new System.Drawing.Size(187, 20);
            this.TxtRut.TabIndex = 14;
            // 
            // BtnCliente
            // 
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(297, 113);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(104, 23);
            this.BtnCliente.TabIndex = 15;
            this.BtnCliente.Text = "Buscar Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // LblNombreRazonSocial
            // 
            this.LblNombreRazonSocial.AutoSize = true;
            this.LblNombreRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreRazonSocial.Location = new System.Drawing.Point(12, 145);
            this.LblNombreRazonSocial.Name = "LblNombreRazonSocial";
            this.LblNombreRazonSocial.Size = new System.Drawing.Size(50, 13);
            this.LblNombreRazonSocial.TabIndex = 16;
            this.LblNombreRazonSocial.Text = "Nombre";
            // 
            // TxtNombreRazonSocial
            // 
            this.TxtNombreRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreRazonSocial.Location = new System.Drawing.Point(104, 145);
            this.TxtNombreRazonSocial.Name = "TxtNombreRazonSocial";
            this.TxtNombreRazonSocial.ReadOnly = true;
            this.TxtNombreRazonSocial.Size = new System.Drawing.Size(187, 20);
            this.TxtNombreRazonSocial.TabIndex = 17;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(12, 171);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 13);
            this.LblCodigo.TabIndex = 18;
            this.LblCodigo.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(12, 187);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(162, 20);
            this.TxtCodigo.TabIndex = 19;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(193, 171);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 20;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(196, 187);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(229, 20);
            this.TxtNombreProducto.TabIndex = 21;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProducto.Location = new System.Drawing.Point(564, 185);
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
            this.LblCantidad.Location = new System.Drawing.Point(721, 171);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(57, 13);
            this.LblCantidad.TabIndex = 23;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(724, 185);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(141, 20);
            this.TxtCantidad.TabIndex = 24;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            this.TxtCantidad.Leave += new System.EventHandler(this.TxtCantidad_Leave);
            // 
            // DgVentaProducto
            // 
            this.DgVentaProducto.AllowUserToAddRows = false;
            this.DgVentaProducto.AllowUserToDeleteRows = false;
            this.DgVentaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgVentaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVentaProducto.Location = new System.Drawing.Point(15, 211);
            this.DgVentaProducto.Name = "DgVentaProducto";
            this.DgVentaProducto.ReadOnly = true;
            this.DgVentaProducto.Size = new System.Drawing.Size(853, 181);
            this.DgVentaProducto.TabIndex = 26;
            this.DgVentaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgVentaProducto_CellClick);
            this.DgVentaProducto.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgVentaProducto_DataBindingComplete);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(897, 211);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(109, 41);
            this.BtnAgregar.TabIndex = 27;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(897, 269);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(109, 41);
            this.BtnEditar.TabIndex = 28;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(897, 329);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(109, 41);
            this.BtnBorrar.TabIndex = 29;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(11, 481);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(73, 24);
            this.LblTotal.TabIndex = 30;
            this.LblTotal.Text = "Total $";
            // 
            // BtnNuevVenta
            // 
            this.BtnNuevVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevVenta.Location = new System.Drawing.Point(626, 462);
            this.BtnNuevVenta.Name = "BtnNuevVenta";
            this.BtnNuevVenta.Size = new System.Drawing.Size(138, 43);
            this.BtnNuevVenta.TabIndex = 31;
            this.BtnNuevVenta.Text = "Nuevo";
            this.BtnNuevVenta.UseVisualStyleBackColor = true;
            this.BtnNuevVenta.Click += new System.EventHandler(this.BtnNuevVenta_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(897, 488);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(109, 41);
            this.BtnCerrar.TabIndex = 32;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(263, 461);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(138, 43);
            this.BtnImprimir.TabIndex = 33;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTotal.BackColor = System.Drawing.Color.Silver;
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(81, 482);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(140, 22);
            this.TxtTotal.TabIndex = 34;
            // 
            // LblCantidadObligatoria
            // 
            this.LblCantidadObligatoria.AutoSize = true;
            this.LblCantidadObligatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadObligatoria.ForeColor = System.Drawing.Color.Red;
            this.LblCantidadObligatoria.Location = new System.Drawing.Point(705, 185);
            this.LblCantidadObligatoria.Name = "LblCantidadObligatoria";
            this.LblCantidadObligatoria.Size = new System.Drawing.Size(16, 20);
            this.LblCantidadObligatoria.TabIndex = 35;
            this.LblCantidadObligatoria.Text = "*";
            this.LblCantidadObligatoria.Visible = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(443, 187);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ReadOnly = true;
            this.TxtPrecio.Size = new System.Drawing.Size(115, 20);
            this.TxtPrecio.TabIndex = 36;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(440, 171);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(43, 13);
            this.LblPrecio.TabIndex = 37;
            this.LblPrecio.Text = "Precio";
            // 
            // CbEmpleado
            // 
            this.CbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEmpleado.FormattingEnabled = true;
            this.CbEmpleado.Location = new System.Drawing.Point(506, 116);
            this.CbEmpleado.Name = "CbEmpleado";
            this.CbEmpleado.Size = new System.Drawing.Size(160, 21);
            this.CbEmpleado.TabIndex = 38;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.Location = new System.Drawing.Point(440, 116);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(62, 13);
            this.LblEmpleado.TabIndex = 39;
            this.LblEmpleado.Text = "Empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(724, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // TxtIva
            // 
            this.TxtIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtIva.BackColor = System.Drawing.Color.Silver;
            this.TxtIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIva.Location = new System.Drawing.Point(81, 448);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.ReadOnly = true;
            this.TxtIva.Size = new System.Drawing.Size(140, 22);
            this.TxtIva.TabIndex = 45;
            // 
            // LblIva
            // 
            this.LblIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIva.Location = new System.Drawing.Point(11, 448);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(43, 24);
            this.LblIva.TabIndex = 46;
            this.LblIva.Text = "IVA";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSubtotal.BackColor = System.Drawing.Color.Silver;
            this.TxtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(81, 414);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.ReadOnly = true;
            this.TxtSubtotal.Size = new System.Drawing.Size(140, 22);
            this.TxtSubtotal.TabIndex = 47;
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.Location = new System.Drawing.Point(11, 414);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(54, 24);
            this.LblSubtotal.TabIndex = 48;
            this.LblSubtotal.Text = "Neto";
            // 
            // lblTituloMenu2
            // 
            this.lblTituloMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloMenu2.AutoSize = true;
            this.lblTituloMenu2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenu2.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMenu2.Location = new System.Drawing.Point(843, 51);
            this.lblTituloMenu2.Name = "lblTituloMenu2";
            this.lblTituloMenu2.Size = new System.Drawing.Size(126, 45);
            this.lblTituloMenu2.TabIndex = 49;
            this.lblTituloMenu2.Text = "FERME";
            // 
            // lblTitulomenu
            // 
            this.lblTitulomenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulomenu.AutoSize = true;
            this.lblTitulomenu.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulomenu.ForeColor = System.Drawing.Color.Black;
            this.lblTitulomenu.Location = new System.Drawing.Point(843, 9);
            this.lblTitulomenu.Name = "lblTitulomenu";
            this.lblTitulomenu.Size = new System.Drawing.Size(172, 45);
            this.lblTitulomenu.TabIndex = 50;
            this.lblTitulomenu.Text = "Ferreteria";
            // 
            // LblIdProducto
            // 
            this.LblIdProducto.AutoSize = true;
            this.LblIdProducto.Location = new System.Drawing.Point(23, 25);
            this.LblIdProducto.Name = "LblIdProducto";
            this.LblIdProducto.Size = new System.Drawing.Size(59, 13);
            this.LblIdProducto.TabIndex = 51;
            this.LblIdProducto.Text = "IdProducto";
            this.LblIdProducto.Visible = false;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(104, 25);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.ReadOnly = true;
            this.TxtIdProducto.Size = new System.Drawing.Size(144, 20);
            this.TxtIdProducto.TabIndex = 52;
            this.TxtIdProducto.Visible = false;
            // 
            // CbTipoDocto
            // 
            this.CbTipoDocto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoDocto.FormattingEnabled = true;
            this.CbTipoDocto.Location = new System.Drawing.Point(104, 51);
            this.CbTipoDocto.Name = "CbTipoDocto";
            this.CbTipoDocto.Size = new System.Drawing.Size(187, 21);
            this.CbTipoDocto.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tipo Docto";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(443, 462);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(138, 43);
            this.BtnGuardar.TabIndex = 56;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // DpFecha
            // 
            this.DpFecha.Enabled = false;
            this.DpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpFecha.Location = new System.Drawing.Point(507, 80);
            this.DpFecha.Name = "DpFecha";
            this.DpFecha.Size = new System.Drawing.Size(159, 20);
            this.DpFecha.TabIndex = 57;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCliente.Location = new System.Drawing.Point(506, 143);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.ReadOnly = true;
            this.TxtIdCliente.Size = new System.Drawing.Size(141, 20);
            this.TxtIdCliente.TabIndex = 58;
            this.TxtIdCliente.Visible = false;
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Location = new System.Drawing.Point(440, 143);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(48, 13);
            this.LblIdCliente.TabIndex = 59;
            this.LblIdCliente.Text = "IdCliente";
            this.LblIdCliente.Visible = false;
            // 
            // FromularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 541);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.DpFecha);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbTipoDocto);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.LblIdProducto);
            this.Controls.Add(this.lblTitulomenu);
            this.Controls.Add(this.lblTituloMenu2);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.CbEmpleado);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LblCantidadObligatoria);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnNuevVenta);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
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
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FromularioVentas";
            this.Text = "FromularioVentas";
            this.Load += new System.EventHandler(this.FromularioVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgVentaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblNumeroDocumento;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Label LblNombreRazonSocial;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnNuevVenta;
        private System.Windows.Forms.Button BtnImprimir;
        public System.Windows.Forms.TextBox TxtCodigo;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        public System.Windows.Forms.DataGridView DgVentaProducto;
        private System.Windows.Forms.Label LblCantidadObligatoria;
        private System.Windows.Forms.Label LblPrecio;
        public System.Windows.Forms.TextBox TxtPrecio;
        public System.Windows.Forms.TextBox TxtRut;
        public System.Windows.Forms.TextBox TxtNombreRazonSocial;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox TxtNumeroDocumento;
        public System.Windows.Forms.TextBox TxtTotal;
        public System.Windows.Forms.ComboBox CbEmpleado;
        public System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.Label LblIva;
        public System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label lblTituloMenu2;
        private System.Windows.Forms.Label lblTitulomenu;
        private System.Windows.Forms.Label LblIdProducto;
        public System.Windows.Forms.TextBox TxtIdProducto;
        public System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CbTipoDocto;
        private System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.DateTimePicker DpFecha;
        public System.Windows.Forms.TextBox TxtIdCliente;
        public System.Windows.Forms.Label LblIdCliente;
    }
}