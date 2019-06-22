namespace AppPrincipal
{
    partial class FormularioMantenedorProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorProducto));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.CbTipoproducto = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblStockActual = new System.Windows.Forms.Label();
            this.LblStockCritico = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtStockActual = new System.Windows.Forms.TextBox();
            this.TxtStockCritico = new System.Windows.Forms.TextBox();
            this.LblCodigoObligatorio = new System.Windows.Forms.Label();
            this.LblNombreProObligatorio = new System.Windows.Forms.Label();
            this.LblTipoProObligatorio = new System.Windows.Forms.Label();
            this.LblPrecioObligatorio = new System.Windows.Forms.Label();
            this.LblDescripcionObligatoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProducto = new System.Windows.Forms.Label();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.LblIdTipoProducto = new System.Windows.Forms.Label();
            this.TxtIdTipoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcionTipoProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(195, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Producto";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(24, 67);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 13);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProducto.Location = new System.Drawing.Point(240, 67);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(123, 13);
            this.LblNombreProducto.TabIndex = 2;
            this.LblNombreProducto.Text = "Nombre de Producto";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(27, 83);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(156, 20);
            this.TxtCodigo.TabIndex = 3;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(243, 83);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(261, 20);
            this.TxtNombreProducto.TabIndex = 4;
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoProducto.Location = new System.Drawing.Point(24, 121);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(105, 13);
            this.LblTipoProducto.TabIndex = 5;
            this.LblTipoProducto.Text = "Tipo de Producto";
            // 
            // CbTipoproducto
            // 
            this.CbTipoproducto.FormattingEnabled = true;
            this.CbTipoproducto.Location = new System.Drawing.Point(27, 137);
            this.CbTipoproducto.Name = "CbTipoproducto";
            this.CbTipoproducto.Size = new System.Drawing.Size(156, 21);
            this.CbTipoproducto.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(27, 183);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecio.Location = new System.Drawing.Point(40, 200);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(138, 20);
            this.TxtPrecio.TabIndex = 12;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // LblStockActual
            // 
            this.LblStockActual.AutoSize = true;
            this.LblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStockActual.Location = new System.Drawing.Point(24, 228);
            this.LblStockActual.Name = "LblStockActual";
            this.LblStockActual.Size = new System.Drawing.Size(80, 13);
            this.LblStockActual.TabIndex = 13;
            this.LblStockActual.Text = "Stock Actual";
            // 
            // LblStockCritico
            // 
            this.LblStockCritico.AutoSize = true;
            this.LblStockCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStockCritico.Location = new System.Drawing.Point(26, 280);
            this.LblStockCritico.Name = "LblStockCritico";
            this.LblStockCritico.Size = new System.Drawing.Size(80, 13);
            this.LblStockCritico.TabIndex = 15;
            this.LblStockCritico.Text = "Stock Critico";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcion.Location = new System.Drawing.Point(243, 140);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(261, 197);
            this.TxtDescripcion.TabIndex = 17;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(240, 121);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.LblDescripcion.TabIndex = 18;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(68, 414);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 41);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(301, 414);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 41);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtStockActual
            // 
            this.TxtStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStockActual.Location = new System.Drawing.Point(27, 246);
            this.TxtStockActual.Name = "TxtStockActual";
            this.TxtStockActual.Size = new System.Drawing.Size(156, 20);
            this.TxtStockActual.TabIndex = 21;
            this.TxtStockActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockActual_KeyPress);
            // 
            // TxtStockCritico
            // 
            this.TxtStockCritico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStockCritico.Location = new System.Drawing.Point(27, 298);
            this.TxtStockCritico.Name = "TxtStockCritico";
            this.TxtStockCritico.Size = new System.Drawing.Size(153, 20);
            this.TxtStockCritico.TabIndex = 22;
            this.TxtStockCritico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockCritico_KeyPress);
            // 
            // LblCodigoObligatorio
            // 
            this.LblCodigoObligatorio.AutoSize = true;
            this.LblCodigoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblCodigoObligatorio.Location = new System.Drawing.Point(187, 84);
            this.LblCodigoObligatorio.Name = "LblCodigoObligatorio";
            this.LblCodigoObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblCodigoObligatorio.TabIndex = 23;
            this.LblCodigoObligatorio.Text = "*";
            this.LblCodigoObligatorio.Visible = false;
            // 
            // LblNombreProObligatorio
            // 
            this.LblNombreProObligatorio.AutoSize = true;
            this.LblNombreProObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblNombreProObligatorio.Location = new System.Drawing.Point(508, 84);
            this.LblNombreProObligatorio.Name = "LblNombreProObligatorio";
            this.LblNombreProObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblNombreProObligatorio.TabIndex = 24;
            this.LblNombreProObligatorio.Text = "*";
            this.LblNombreProObligatorio.Visible = false;
            // 
            // LblTipoProObligatorio
            // 
            this.LblTipoProObligatorio.AutoSize = true;
            this.LblTipoProObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoProObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblTipoProObligatorio.Location = new System.Drawing.Point(189, 138);
            this.LblTipoProObligatorio.Name = "LblTipoProObligatorio";
            this.LblTipoProObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblTipoProObligatorio.TabIndex = 27;
            this.LblTipoProObligatorio.Text = "*";
            this.LblTipoProObligatorio.Visible = false;
            // 
            // LblPrecioObligatorio
            // 
            this.LblPrecioObligatorio.AutoSize = true;
            this.LblPrecioObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblPrecioObligatorio.Location = new System.Drawing.Point(181, 200);
            this.LblPrecioObligatorio.Name = "LblPrecioObligatorio";
            this.LblPrecioObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblPrecioObligatorio.TabIndex = 28;
            this.LblPrecioObligatorio.Text = "*";
            this.LblPrecioObligatorio.Visible = false;
            // 
            // LblDescripcionObligatoria
            // 
            this.LblDescripcionObligatoria.AutoSize = true;
            this.LblDescripcionObligatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcionObligatoria.ForeColor = System.Drawing.Color.Red;
            this.LblDescripcionObligatoria.Location = new System.Drawing.Point(318, 119);
            this.LblDescripcionObligatoria.Name = "LblDescripcionObligatoria";
            this.LblDescripcionObligatoria.Size = new System.Drawing.Size(14, 16);
            this.LblDescripcionObligatoria.TabIndex = 29;
            this.LblDescripcionObligatoria.Text = "*";
            this.LblDescripcionObligatoria.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "$";
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSize = true;
            this.IdProducto.Location = new System.Drawing.Point(26, 24);
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Size = new System.Drawing.Size(59, 13);
            this.IdProducto.TabIndex = 31;
            this.IdProducto.Text = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(27, 40);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.ReadOnly = true;
            this.TxtIdProducto.Size = new System.Drawing.Size(153, 20);
            this.TxtIdProducto.TabIndex = 32;
            this.TxtIdProducto.Visible = false;
            // 
            // LblIdTipoProducto
            // 
            this.LblIdTipoProducto.AutoSize = true;
            this.LblIdTipoProducto.Location = new System.Drawing.Point(24, 336);
            this.LblIdTipoProducto.Name = "LblIdTipoProducto";
            this.LblIdTipoProducto.Size = new System.Drawing.Size(80, 13);
            this.LblIdTipoProducto.TabIndex = 33;
            this.LblIdTipoProducto.Text = "IdTipoProducto";
            this.LblIdTipoProducto.Visible = false;
            // 
            // TxtIdTipoProducto
            // 
            this.TxtIdTipoProducto.Location = new System.Drawing.Point(27, 352);
            this.TxtIdTipoProducto.Name = "TxtIdTipoProducto";
            this.TxtIdTipoProducto.ReadOnly = true;
            this.TxtIdTipoProducto.Size = new System.Drawing.Size(153, 20);
            this.TxtIdTipoProducto.TabIndex = 34;
            this.TxtIdTipoProducto.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "DescripcionTipoProducto";
            this.label2.Visible = false;
            // 
            // TxtDescripcionTipoProducto
            // 
            this.TxtDescripcionTipoProducto.Location = new System.Drawing.Point(243, 352);
            this.TxtDescripcionTipoProducto.Name = "TxtDescripcionTipoProducto";
            this.TxtDescripcionTipoProducto.ReadOnly = true;
            this.TxtDescripcionTipoProducto.Size = new System.Drawing.Size(153, 20);
            this.TxtDescripcionTipoProducto.TabIndex = 36;
            this.TxtDescripcionTipoProducto.Visible = false;
            // 
            // FormularioMantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 502);
            this.ControlBox = false;
            this.Controls.Add(this.TxtDescripcionTipoProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdTipoProducto);
            this.Controls.Add(this.LblIdTipoProducto);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.IdProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDescripcionObligatoria);
            this.Controls.Add(this.LblPrecioObligatorio);
            this.Controls.Add(this.LblTipoProObligatorio);
            this.Controls.Add(this.LblNombreProObligatorio);
            this.Controls.Add(this.LblCodigoObligatorio);
            this.Controls.Add(this.TxtStockCritico);
            this.Controls.Add(this.TxtStockActual);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblStockCritico);
            this.Controls.Add(this.LblStockActual);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.CbTipoproducto);
            this.Controls.Add(this.LblTipoProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblNombreProducto);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Producto";
            this.Load += new System.EventHandler(this.FormularioMantenedorProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label LblStockActual;
        private System.Windows.Forms.Label LblStockCritico;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.TextBox TxtCodigo;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        public System.Windows.Forms.ComboBox CbTipoproducto;
        public System.Windows.Forms.TextBox TxtPrecio;
        public System.Windows.Forms.TextBox TxtDescripcion;
        public System.Windows.Forms.TextBox TxtStockActual;
        public System.Windows.Forms.TextBox TxtStockCritico;
        private System.Windows.Forms.Label LblCodigoObligatorio;
        private System.Windows.Forms.Label LblNombreProObligatorio;
        private System.Windows.Forms.Label LblTipoProObligatorio;
        private System.Windows.Forms.Label LblPrecioObligatorio;
        private System.Windows.Forms.Label LblDescripcionObligatoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdProducto;
        public System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Label LblIdTipoProducto;
        public System.Windows.Forms.TextBox TxtIdTipoProducto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtDescripcionTipoProducto;
    }
}