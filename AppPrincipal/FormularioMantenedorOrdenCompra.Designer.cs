namespace AppPrincipal
{
    partial class FormularioMantenedorOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorOrdenCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DPfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DPfechaTermino = new System.Windows.Forms.DateTimePicker();
            this.LblFechaTermino = new System.Windows.Forms.Label();
            this.CbEmpleado = new System.Windows.Forms.ComboBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantSolicitada = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCantidadObligatoria = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.LblIdProducto = new System.Windows.Forms.Label();
            this.lblTituloMenu2 = new System.Windows.Forms.Label();
            this.lblTitulomenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBuscarOrdenCompra = new System.Windows.Forms.Button();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.DgListadoProductoOC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoProductoOC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 33);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ORDEN DE COMPRA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(233, 488);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(174, 42);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(561, 488);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(173, 42);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Nuevo";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(15, 75);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(248, 20);
            this.TxtNumero.TabIndex = 6;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            this.TxtNumero.Leave += new System.EventHandler(this.TxtNumero_Leave);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(12, 112);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(77, 13);
            this.LblFecha.TabIndex = 7;
            this.LblFecha.Text = "Fecha Inicio";
            // 
            // DPfechaInicio
            // 
            this.DPfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPfechaInicio.Location = new System.Drawing.Point(13, 128);
            this.DPfechaInicio.Name = "DPfechaInicio";
            this.DPfechaInicio.Size = new System.Drawing.Size(250, 20);
            this.DPfechaInicio.TabIndex = 8;
            // 
            // DPfechaTermino
            // 
            this.DPfechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPfechaTermino.Location = new System.Drawing.Point(13, 183);
            this.DPfechaTermino.Name = "DPfechaTermino";
            this.DPfechaTermino.Size = new System.Drawing.Size(250, 20);
            this.DPfechaTermino.TabIndex = 9;
            // 
            // LblFechaTermino
            // 
            this.LblFechaTermino.AutoSize = true;
            this.LblFechaTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaTermino.Location = new System.Drawing.Point(13, 168);
            this.LblFechaTermino.Name = "LblFechaTermino";
            this.LblFechaTermino.Size = new System.Drawing.Size(91, 13);
            this.LblFechaTermino.TabIndex = 10;
            this.LblFechaTermino.Text = "Fecha Termino";
            // 
            // CbEmpleado
            // 
            this.CbEmpleado.FormattingEnabled = true;
            this.CbEmpleado.Location = new System.Drawing.Point(415, 127);
            this.CbEmpleado.Name = "CbEmpleado";
            this.CbEmpleado.Size = new System.Drawing.Size(294, 21);
            this.CbEmpleado.TabIndex = 11;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.Location = new System.Drawing.Point(412, 111);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(62, 13);
            this.LblEmpleado.TabIndex = 12;
            this.LblEmpleado.Text = "Empleado";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(412, 58);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(46, 13);
            this.LblEstado.TabIndex = 13;
            this.LblEstado.Text = "Estado";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(13, 216);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(58, 13);
            this.LblProducto.TabIndex = 15;
            this.LblProducto.Text = "Producto";
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Location = new System.Drawing.Point(16, 229);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.ReadOnly = true;
            this.TxtCodProducto.Size = new System.Drawing.Size(251, 20);
            this.TxtCodProducto.TabIndex = 16;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(288, 231);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(290, 20);
            this.TxtNombreProducto.TabIndex = 17;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(691, 232);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(140, 20);
            this.TxtCantidad.TabIndex = 19;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // LblCantSolicitada
            // 
            this.LblCantSolicitada.AutoSize = true;
            this.LblCantSolicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantSolicitada.Location = new System.Drawing.Point(688, 216);
            this.LblCantSolicitada.Name = "LblCantSolicitada";
            this.LblCantSolicitada.Size = new System.Drawing.Size(57, 13);
            this.LblCantSolicitada.TabIndex = 20;
            this.LblCantSolicitada.Text = "Cantidad";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(902, 264);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(104, 45);
            this.BtnAgregar.TabIndex = 22;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // LblCantidadObligatoria
            // 
            this.LblCantidadObligatoria.AutoSize = true;
            this.LblCantidadObligatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadObligatoria.ForeColor = System.Drawing.Color.Red;
            this.LblCantidadObligatoria.Location = new System.Drawing.Point(837, 236);
            this.LblCantidadObligatoria.Name = "LblCantidadObligatoria";
            this.LblCantidadObligatoria.Size = new System.Drawing.Size(14, 16);
            this.LblCantidadObligatoria.TabIndex = 25;
            this.LblCantidadObligatoria.Text = "*";
            this.LblCantidadObligatoria.Leave += new System.EventHandler(this.LblCantidadObligatoria_Leave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(584, 229);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(58, 23);
            this.BtnBuscar.TabIndex = 26;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(902, 315);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(104, 45);
            this.BtnEditar.TabIndex = 27;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(902, 366);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(104, 45);
            this.BtnBorrar.TabIndex = 28;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(415, 183);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.ReadOnly = true;
            this.TxtIdProducto.Size = new System.Drawing.Size(96, 20);
            this.TxtIdProducto.TabIndex = 29;
            this.TxtIdProducto.Visible = false;
            // 
            // LblIdProducto
            // 
            this.LblIdProducto.AutoSize = true;
            this.LblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdProducto.Location = new System.Drawing.Point(412, 168);
            this.LblIdProducto.Name = "LblIdProducto";
            this.LblIdProducto.Size = new System.Drawing.Size(69, 13);
            this.LblIdProducto.TabIndex = 30;
            this.LblIdProducto.Text = "IdProducto";
            this.LblIdProducto.Visible = false;
            // 
            // lblTituloMenu2
            // 
            this.lblTituloMenu2.AutoSize = true;
            this.lblTituloMenu2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenu2.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMenu2.Location = new System.Drawing.Point(852, 57);
            this.lblTituloMenu2.Name = "lblTituloMenu2";
            this.lblTituloMenu2.Size = new System.Drawing.Size(126, 45);
            this.lblTituloMenu2.TabIndex = 31;
            this.lblTituloMenu2.Text = "FERME";
            // 
            // lblTitulomenu
            // 
            this.lblTitulomenu.AutoSize = true;
            this.lblTitulomenu.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulomenu.ForeColor = System.Drawing.Color.Black;
            this.lblTitulomenu.Location = new System.Drawing.Point(837, 12);
            this.lblTitulomenu.Name = "lblTitulomenu";
            this.lblTitulomenu.Size = new System.Drawing.Size(172, 45);
            this.lblTitulomenu.TabIndex = 32;
            this.lblTitulomenu.Text = "Ferreteria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(745, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(902, 485);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(104, 45);
            this.BtnCerrar.TabIndex = 34;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnBuscarOrdenCompra
            // 
            this.BtnBuscarOrdenCompra.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscarOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarOrdenCompra.Location = new System.Drawing.Point(269, 73);
            this.BtnBuscarOrdenCompra.Name = "BtnBuscarOrdenCompra";
            this.BtnBuscarOrdenCompra.Size = new System.Drawing.Size(58, 23);
            this.BtnBuscarOrdenCompra.TabIndex = 35;
            this.BtnBuscarOrdenCompra.Text = "Buscar";
            this.BtnBuscarOrdenCompra.UseVisualStyleBackColor = false;
            this.BtnBuscarOrdenCompra.Click += new System.EventHandler(this.BtnBuscarOrdenCompra_Click);
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(415, 75);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.ReadOnly = true;
            this.TxtEstado.Size = new System.Drawing.Size(100, 20);
            this.TxtEstado.TabIndex = 36;
            // 
            // DgListadoProductoOC
            // 
            this.DgListadoProductoOC.AllowUserToAddRows = false;
            this.DgListadoProductoOC.AllowUserToDeleteRows = false;
            this.DgListadoProductoOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgListadoProductoOC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgListadoProductoOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgListadoProductoOC.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgListadoProductoOC.Location = new System.Drawing.Point(16, 264);
            this.DgListadoProductoOC.Name = "DgListadoProductoOC";
            this.DgListadoProductoOC.ReadOnly = true;
            this.DgListadoProductoOC.Size = new System.Drawing.Size(852, 199);
            this.DgListadoProductoOC.TabIndex = 37;
            this.DgListadoProductoOC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListadoProductoOC_CellClick);
            this.DgListadoProductoOC.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgListadoProductoOC_DataBindingComplete);
            // 
            // FormularioMantenedorOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 528);
            this.ControlBox = false;
            this.Controls.Add(this.DgListadoProductoOC);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.BtnBuscarOrdenCompra);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulomenu);
            this.Controls.Add(this.lblTituloMenu2);
            this.Controls.Add(this.LblIdProducto);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblCantidadObligatoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblCantSolicitada);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.TxtCodProducto);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.CbEmpleado);
            this.Controls.Add(this.LblFechaTermino);
            this.Controls.Add(this.DPfechaTermino);
            this.Controls.Add(this.DPfechaInicio);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Orden Compra";
            this.Load += new System.EventHandler(this.FormularioMantenedorOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoProductoOC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblFechaTermino;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantSolicitada;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCantidadObligatoria;
        private System.Windows.Forms.Button BtnBuscar;
        public System.Windows.Forms.TextBox TxtCodProducto;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnBorrar;
        public System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Label LblIdProducto;
        private System.Windows.Forms.Label lblTituloMenu2;
        private System.Windows.Forms.Label lblTitulomenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBuscarOrdenCompra;
        public System.Windows.Forms.TextBox TxtEstado;
        public System.Windows.Forms.TextBox TxtNumero;
        public System.Windows.Forms.DateTimePicker DPfechaInicio;
        public System.Windows.Forms.DateTimePicker DPfechaTermino;
        public System.Windows.Forms.ComboBox CbEmpleado;
        public System.Windows.Forms.DataGridView DgListadoProductoOC;
    }
}