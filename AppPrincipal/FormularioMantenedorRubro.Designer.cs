namespace AppPrincipal
{
    partial class FormularioMantenedorRubro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorRubro));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TxtRubro = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImagenTicketBueno = new System.Windows.Forms.PictureBox();
            this.LblCodigoObligatorio = new System.Windows.Forms.Label();
            this.LblDescripcionObligatoria = new System.Windows.Forms.Label();
            this.BtnBuscarRubro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenTicketBueno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(175, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "RUBRO";
            // 
            // TxtRubro
            // 
            this.TxtRubro.Location = new System.Drawing.Point(88, 104);
            this.TxtRubro.Name = "TxtRubro";
            this.TxtRubro.Size = new System.Drawing.Size(162, 20);
            this.TxtRubro.TabIndex = 3;
            this.TxtRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRubro_KeyPress);
            this.TxtRubro.Leave += new System.EventHandler(this.TxtRubro_Leave);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(36, 107);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 13);
            this.LblCodigo.TabIndex = 4;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(12, 140);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.LblDescripcion.TabIndex = 5;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(88, 140);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(355, 20);
            this.TxtDescripcion.TabIndex = 6;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            this.TxtDescripcion.Leave += new System.EventHandler(this.TxtDescripcion_Leave);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(75, 227);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(110, 42);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(279, 227);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 42);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ImagenTicketBueno
            // 
            this.ImagenTicketBueno.Image = ((System.Drawing.Image)(resources.GetObject("ImagenTicketBueno.Image")));
            this.ImagenTicketBueno.Location = new System.Drawing.Point(385, 36);
            this.ImagenTicketBueno.Name = "ImagenTicketBueno";
            this.ImagenTicketBueno.Size = new System.Drawing.Size(58, 50);
            this.ImagenTicketBueno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenTicketBueno.TabIndex = 9;
            this.ImagenTicketBueno.TabStop = false;
            this.ImagenTicketBueno.Visible = false;
            // 
            // LblCodigoObligatorio
            // 
            this.LblCodigoObligatorio.AutoSize = true;
            this.LblCodigoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblCodigoObligatorio.Location = new System.Drawing.Point(271, 107);
            this.LblCodigoObligatorio.Name = "LblCodigoObligatorio";
            this.LblCodigoObligatorio.Size = new System.Drawing.Size(88, 15);
            this.LblCodigoObligatorio.TabIndex = 10;
            this.LblCodigoObligatorio.Text = "* Obligatorio";
            this.LblCodigoObligatorio.Visible = false;
            // 
            // LblDescripcionObligatoria
            // 
            this.LblDescripcionObligatoria.AutoSize = true;
            this.LblDescripcionObligatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcionObligatoria.ForeColor = System.Drawing.Color.Red;
            this.LblDescripcionObligatoria.Location = new System.Drawing.Point(449, 144);
            this.LblDescripcionObligatoria.Name = "LblDescripcionObligatoria";
            this.LblDescripcionObligatoria.Size = new System.Drawing.Size(14, 16);
            this.LblDescripcionObligatoria.TabIndex = 11;
            this.LblDescripcionObligatoria.Text = "*";
            this.LblDescripcionObligatoria.Visible = false;
            // 
            // BtnBuscarRubro
            // 
            this.BtnBuscarRubro.Location = new System.Drawing.Point(250, 102);
            this.BtnBuscarRubro.Name = "BtnBuscarRubro";
            this.BtnBuscarRubro.Size = new System.Drawing.Size(22, 24);
            this.BtnBuscarRubro.TabIndex = 12;
            this.BtnBuscarRubro.Text = "B";
            this.BtnBuscarRubro.UseVisualStyleBackColor = true;
            this.BtnBuscarRubro.Click += new System.EventHandler(this.BtnBuscarRubro_Click);
            // 
            // FormularioMantenedorRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBuscarRubro);
            this.Controls.Add(this.LblDescripcionObligatoria);
            this.Controls.Add(this.LblCodigoObligatorio);
            this.Controls.Add(this.ImagenTicketBueno);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.TxtRubro);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorRubro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Rubro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenTicketBueno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox TxtRubro;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox ImagenTicketBueno;
        private System.Windows.Forms.Label LblCodigoObligatorio;
        private System.Windows.Forms.Label LblDescripcionObligatoria;
        private System.Windows.Forms.Button BtnBuscarRubro;
    }
}