namespace AppPrincipal
{
    partial class FormularioRecepcion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRecepcion));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnBuscarOrdenCompra = new System.Windows.Forms.Button();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DpFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.LblEstadoRecepcion = new System.Windows.Forms.Label();
            this.CbxEstadoRecepcion = new System.Windows.Forms.ComboBox();
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.DgListadoRecepcion = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulomenu = new System.Windows.Forms.Label();
            this.lblTituloMenu2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoRecepcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(21, 23);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(289, 29);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "RECEPCION DE PRODUCTOS";
            // 
            // BtnBuscarOrdenCompra
            // 
            this.BtnBuscarOrdenCompra.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscarOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarOrdenCompra.Location = new System.Drawing.Point(279, 92);
            this.BtnBuscarOrdenCompra.Name = "BtnBuscarOrdenCompra";
            this.BtnBuscarOrdenCompra.Size = new System.Drawing.Size(58, 23);
            this.BtnBuscarOrdenCompra.TabIndex = 38;
            this.BtnBuscarOrdenCompra.Text = "Buscar";
            this.BtnBuscarOrdenCompra.UseVisualStyleBackColor = false;
            this.BtnBuscarOrdenCompra.Click += new System.EventHandler(this.BtnBuscarOrdenCompra_Click);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(25, 94);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(248, 20);
            this.TxtNumero.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha Creacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Fecha Recepcion";
            // 
            // DpFechaRecepcion
            // 
            this.DpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpFechaRecepcion.Location = new System.Drawing.Point(26, 196);
            this.DpFechaRecepcion.Name = "DpFechaRecepcion";
            this.DpFechaRecepcion.Size = new System.Drawing.Size(246, 20);
            this.DpFechaRecepcion.TabIndex = 42;
            // 
            // LblEstadoRecepcion
            // 
            this.LblEstadoRecepcion.AutoSize = true;
            this.LblEstadoRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoRecepcion.Location = new System.Drawing.Point(434, 78);
            this.LblEstadoRecepcion.Name = "LblEstadoRecepcion";
            this.LblEstadoRecepcion.Size = new System.Drawing.Size(111, 13);
            this.LblEstadoRecepcion.TabIndex = 43;
            this.LblEstadoRecepcion.Text = "Estado Recepcion";
            // 
            // CbxEstadoRecepcion
            // 
            this.CbxEstadoRecepcion.FormattingEnabled = true;
            this.CbxEstadoRecepcion.Location = new System.Drawing.Point(437, 93);
            this.CbxEstadoRecepcion.Name = "CbxEstadoRecepcion";
            this.CbxEstadoRecepcion.Size = new System.Drawing.Size(103, 21);
            this.CbxEstadoRecepcion.TabIndex = 44;
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Location = new System.Drawing.Point(437, 147);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.ReadOnly = true;
            this.TxtEmpleado.Size = new System.Drawing.Size(247, 20);
            this.TxtEmpleado.TabIndex = 45;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.Location = new System.Drawing.Point(434, 131);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(62, 13);
            this.LblEmpleado.TabIndex = 46;
            this.LblEmpleado.Text = "Empleado";
            // 
            // DgListadoRecepcion
            // 
            this.DgListadoRecepcion.AllowUserToAddRows = false;
            this.DgListadoRecepcion.AllowUserToDeleteRows = false;
            this.DgListadoRecepcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgListadoRecepcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgListadoRecepcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgListadoRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgListadoRecepcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgListadoRecepcion.Location = new System.Drawing.Point(26, 242);
            this.DgListadoRecepcion.Name = "DgListadoRecepcion";
            this.DgListadoRecepcion.ReadOnly = true;
            this.DgListadoRecepcion.Size = new System.Drawing.Size(933, 199);
            this.DgListadoRecepcion.TabIndex = 47;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(310, 494);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(174, 42);
            this.BtnGuardar.TabIndex = 48;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(522, 493);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(173, 42);
            this.BtnCancelar.TabIndex = 49;
            this.BtnCancelar.Text = "Nuevo";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(902, 493);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(104, 45);
            this.BtnCerrar.TabIndex = 50;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(739, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulomenu
            // 
            this.lblTitulomenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulomenu.AutoSize = true;
            this.lblTitulomenu.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulomenu.ForeColor = System.Drawing.Color.Black;
            this.lblTitulomenu.Location = new System.Drawing.Point(831, 26);
            this.lblTitulomenu.Name = "lblTitulomenu";
            this.lblTitulomenu.Size = new System.Drawing.Size(172, 45);
            this.lblTitulomenu.TabIndex = 52;
            this.lblTitulomenu.Text = "Ferreteria";
            // 
            // lblTituloMenu2
            // 
            this.lblTituloMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloMenu2.AutoSize = true;
            this.lblTituloMenu2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenu2.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMenu2.Location = new System.Drawing.Point(846, 71);
            this.lblTituloMenu2.Name = "lblTituloMenu2";
            this.lblTituloMenu2.Size = new System.Drawing.Size(126, 45);
            this.lblTituloMenu2.TabIndex = 51;
            this.lblTituloMenu2.Text = "FERME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "R : recepcionado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "RR : rechazado";
            // 
            // DpFechaCreacion
            // 
            this.DpFechaCreacion.Enabled = false;
            this.DpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpFechaCreacion.Location = new System.Drawing.Point(26, 147);
            this.DpFechaCreacion.Name = "DpFechaCreacion";
            this.DpFechaCreacion.Size = new System.Drawing.Size(246, 20);
            this.DpFechaCreacion.TabIndex = 56;
            // 
            // FormularioRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 541);
            this.Controls.Add(this.DpFechaCreacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulomenu);
            this.Controls.Add(this.lblTituloMenu2);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DgListadoRecepcion);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.TxtEmpleado);
            this.Controls.Add(this.CbxEstadoRecepcion);
            this.Controls.Add(this.LblEstadoRecepcion);
            this.Controls.Add(this.DpFechaRecepcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscarOrdenCompra);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioRecepcion";
            this.Text = "FormularioRecepcion";
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoRecepcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnBuscarOrdenCompra;
        public System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker DpFechaRecepcion;
        private System.Windows.Forms.Label LblEstadoRecepcion;
        private System.Windows.Forms.Label LblEmpleado;
        public System.Windows.Forms.DataGridView DgListadoRecepcion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulomenu;
        private System.Windows.Forms.Label lblTituloMenu2;
        public System.Windows.Forms.ComboBox CbxEstadoRecepcion;
        public System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker DpFechaCreacion;
    }
}