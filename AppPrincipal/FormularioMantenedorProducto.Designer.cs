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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtStockActual = new System.Windows.Forms.TextBox();
            this.TxtStockCritico = new System.Windows.Forms.TextBox();
            this.LblCodigoObligatorio = new System.Windows.Forms.Label();
            this.LblNombreProObligatorio = new System.Windows.Forms.Label();
            this.LblTipoProObligatorio = new System.Windows.Forms.Label();
            this.LblPrecioObligatorio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProducto = new System.Windows.Forms.Label();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.CbxFamiliaProducto = new System.Windows.Forms.ComboBox();
            this.LblFamiliaProducto = new System.Windows.Forms.Label();
            this.LblFamiliaObligatorio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(234, 6);
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
            this.LblNombreProducto.Location = new System.Drawing.Point(322, 67);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(123, 13);
            this.LblNombreProducto.TabIndex = 2;
            this.LblNombreProducto.Text = "Nombre de Producto";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(27, 83);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(231, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(325, 84);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(277, 20);
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
            this.CbTipoproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoproducto.FormattingEnabled = true;
            this.CbTipoproducto.Location = new System.Drawing.Point(27, 137);
            this.CbTipoproducto.Name = "CbTipoproducto";
            this.CbTipoproducto.Size = new System.Drawing.Size(231, 21);
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
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(42, 199);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(216, 20);
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
            this.LblStockCritico.Location = new System.Drawing.Point(27, 286);
            this.LblStockCritico.Name = "LblStockCritico";
            this.LblStockCritico.Size = new System.Drawing.Size(80, 13);
            this.LblStockCritico.TabIndex = 15;
            this.LblStockCritico.Text = "Stock Critico";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(113, 353);
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
            this.BtnCancelar.Location = new System.Drawing.Point(346, 353);
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
            this.TxtStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockActual.Location = new System.Drawing.Point(27, 247);
            this.TxtStockActual.Name = "TxtStockActual";
            this.TxtStockActual.Size = new System.Drawing.Size(231, 20);
            this.TxtStockActual.TabIndex = 21;
            this.TxtStockActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockActual_KeyPress);
            // 
            // TxtStockCritico
            // 
            this.TxtStockCritico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStockCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockCritico.Location = new System.Drawing.Point(27, 302);
            this.TxtStockCritico.Name = "TxtStockCritico";
            this.TxtStockCritico.Size = new System.Drawing.Size(231, 20);
            this.TxtStockCritico.TabIndex = 22;
            this.TxtStockCritico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockCritico_KeyPress);
            // 
            // LblCodigoObligatorio
            // 
            this.LblCodigoObligatorio.AutoSize = true;
            this.LblCodigoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblCodigoObligatorio.Location = new System.Drawing.Point(261, 88);
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
            this.LblNombreProObligatorio.Location = new System.Drawing.Point(607, 83);
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
            this.LblTipoProObligatorio.Location = new System.Drawing.Point(261, 142);
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
            this.LblPrecioObligatorio.Location = new System.Drawing.Point(261, 202);
            this.LblPrecioObligatorio.Name = "LblPrecioObligatorio";
            this.LblPrecioObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblPrecioObligatorio.TabIndex = 28;
            this.LblPrecioObligatorio.Text = "*";
            this.LblPrecioObligatorio.Visible = false;
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
            this.TxtIdProducto.Size = new System.Drawing.Size(231, 20);
            this.TxtIdProducto.TabIndex = 32;
            this.TxtIdProducto.Visible = false;
            // 
            // CbxFamiliaProducto
            // 
            this.CbxFamiliaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxFamiliaProducto.FormattingEnabled = true;
            this.CbxFamiliaProducto.Location = new System.Drawing.Point(325, 137);
            this.CbxFamiliaProducto.Name = "CbxFamiliaProducto";
            this.CbxFamiliaProducto.Size = new System.Drawing.Size(261, 21);
            this.CbxFamiliaProducto.TabIndex = 33;
            // 
            // LblFamiliaProducto
            // 
            this.LblFamiliaProducto.AutoSize = true;
            this.LblFamiliaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFamiliaProducto.Location = new System.Drawing.Point(322, 121);
            this.LblFamiliaProducto.Name = "LblFamiliaProducto";
            this.LblFamiliaProducto.Size = new System.Drawing.Size(101, 13);
            this.LblFamiliaProducto.TabIndex = 34;
            this.LblFamiliaProducto.Text = "Familia Producto";
            // 
            // LblFamiliaObligatorio
            // 
            this.LblFamiliaObligatorio.AutoSize = true;
            this.LblFamiliaObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFamiliaObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblFamiliaObligatorio.Location = new System.Drawing.Point(588, 142);
            this.LblFamiliaObligatorio.Name = "LblFamiliaObligatorio";
            this.LblFamiliaObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblFamiliaObligatorio.TabIndex = 35;
            this.LblFamiliaObligatorio.Text = "*";
            this.LblFamiliaObligatorio.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioMantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 441);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblFamiliaObligatorio);
            this.Controls.Add(this.LblFamiliaProducto);
            this.Controls.Add(this.CbxFamiliaProducto);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.IdProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPrecioObligatorio);
            this.Controls.Add(this.LblTipoProObligatorio);
            this.Controls.Add(this.LblNombreProObligatorio);
            this.Controls.Add(this.LblCodigoObligatorio);
            this.Controls.Add(this.TxtStockCritico);
            this.Controls.Add(this.TxtStockActual);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.TextBox TxtCodigo;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        public System.Windows.Forms.ComboBox CbTipoproducto;
        public System.Windows.Forms.TextBox TxtPrecio;
        public System.Windows.Forms.TextBox TxtStockActual;
        public System.Windows.Forms.TextBox TxtStockCritico;
        private System.Windows.Forms.Label LblCodigoObligatorio;
        private System.Windows.Forms.Label LblNombreProObligatorio;
        private System.Windows.Forms.Label LblTipoProObligatorio;
        private System.Windows.Forms.Label LblPrecioObligatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdProducto;
        public System.Windows.Forms.TextBox TxtIdProducto;
        public System.Windows.Forms.ComboBox CbxFamiliaProducto;
        private System.Windows.Forms.Label LblFamiliaProducto;
        private System.Windows.Forms.Label LblFamiliaObligatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}