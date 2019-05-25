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
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantSolicitada = new System.Windows.Forms.Label();
            this.DgListadoProductoOC = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblNumeroObligatorio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCantidadObligatoria = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoProductoOC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(125, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ORDEN DE COMPRA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(143, 556);
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
            this.BtnCancelar.Location = new System.Drawing.Point(444, 556);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(173, 42);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
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
            this.TxtNumero.Location = new System.Drawing.Point(13, 75);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(250, 20);
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
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(415, 74);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(116, 21);
            this.CbEstado.TabIndex = 14;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(13, 222);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(58, 13);
            this.LblProducto.TabIndex = 15;
            this.LblProducto.Text = "Producto";
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Location = new System.Drawing.Point(16, 235);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.ReadOnly = true;
            this.TxtCodProducto.Size = new System.Drawing.Size(191, 20);
            this.TxtCodProducto.TabIndex = 16;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(226, 235);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(225, 20);
            this.TxtNombreProducto.TabIndex = 17;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(563, 236);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(80, 20);
            this.TxtCantidad.TabIndex = 19;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // LblCantSolicitada
            // 
            this.LblCantSolicitada.AutoSize = true;
            this.LblCantSolicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantSolicitada.Location = new System.Drawing.Point(560, 220);
            this.LblCantSolicitada.Name = "LblCantSolicitada";
            this.LblCantSolicitada.Size = new System.Drawing.Size(57, 13);
            this.LblCantSolicitada.TabIndex = 20;
            this.LblCantSolicitada.Text = "Cantidad";
            // 
            // DgListadoProductoOC
            // 
            this.DgListadoProductoOC.AllowUserToAddRows = false;
            this.DgListadoProductoOC.AllowUserToDeleteRows = false;
            this.DgListadoProductoOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListadoProductoOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad});
            this.DgListadoProductoOC.Location = new System.Drawing.Point(14, 279);
            this.DgListadoProductoOC.Name = "DgListadoProductoOC";
            this.DgListadoProductoOC.ReadOnly = true;
            this.DgListadoProductoOC.Size = new System.Drawing.Size(695, 263);
            this.DgListadoProductoOC.TabIndex = 21;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(649, 236);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(60, 23);
            this.BtnAgregar.TabIndex = 22;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblNumeroObligatorio
            // 
            this.LblNumeroObligatorio.AutoSize = true;
            this.LblNumeroObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblNumeroObligatorio.Location = new System.Drawing.Point(269, 83);
            this.LblNumeroObligatorio.Name = "LblNumeroObligatorio";
            this.LblNumeroObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblNumeroObligatorio.TabIndex = 23;
            this.LblNumeroObligatorio.Text = "*";
            this.LblNumeroObligatorio.Visible = false;
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
            this.LblCantidadObligatoria.Location = new System.Drawing.Point(543, 240);
            this.LblCantidadObligatoria.Name = "LblCantidadObligatoria";
            this.LblCantidadObligatoria.Size = new System.Drawing.Size(14, 16);
            this.LblCantidadObligatoria.TabIndex = 25;
            this.LblCantidadObligatoria.Text = "*";
            this.LblCantidadObligatoria.Leave += new System.EventHandler(this.LblCantidadObligatoria_Leave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(457, 233);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(58, 23);
            this.BtnBuscar.TabIndex = 26;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // FormularioMantenedorOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 610);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblCantidadObligatoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNumeroObligatorio);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgListadoProductoOC);
            this.Controls.Add(this.LblCantSolicitada);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.TxtCodProducto);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.CbEstado);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoProductoOC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DPfechaInicio;
        private System.Windows.Forms.DateTimePicker DPfechaTermino;
        private System.Windows.Forms.Label LblFechaTermino;
        private System.Windows.Forms.ComboBox CbEmpleado;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantSolicitada;
        private System.Windows.Forms.DataGridView DgListadoProductoOC;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblNumeroObligatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCantidadObligatoria;
        private System.Windows.Forms.Button BtnBuscar;
        public System.Windows.Forms.TextBox TxtCodProducto;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}