namespace AppPrincipal
{
    partial class FormularioMantenedorCliente
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblRutCliente = new System.Windows.Forms.Label();
            this.TxtRutCliente = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefeno1 = new System.Windows.Forms.TextBox();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.TxtTelefono3 = new System.Windows.Forms.TextBox();
            this.LblTelefono3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblRutObligatorio = new System.Windows.Forms.Label();
            this.lblMensajeNombre = new System.Windows.Forms.Label();
            this.lblMensajeDireccion = new System.Windows.Forms.Label();
            this.lblMensajeEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(148, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(137, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CLIENTE";
            // 
            // LblRutCliente
            // 
            this.LblRutCliente.AutoSize = true;
            this.LblRutCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutCliente.Location = new System.Drawing.Point(13, 83);
            this.LblRutCliente.Name = "LblRutCliente";
            this.LblRutCliente.Size = new System.Drawing.Size(27, 13);
            this.LblRutCliente.TabIndex = 2;
            this.LblRutCliente.Text = "Rut";
            // 
            // TxtRutCliente
            // 
            this.TxtRutCliente.Location = new System.Drawing.Point(13, 100);
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(197, 20);
            this.TxtRutCliente.TabIndex = 3;
            this.TxtRutCliente.Leave += new System.EventHandler(this.TxtRutCliente_Leave);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(13, 137);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombres";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(13, 153);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(307, 20);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(13, 192);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(61, 13);
            this.LblDireccion.TabIndex = 8;
            this.LblDireccion.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(12, 208);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(441, 20);
            this.TxtDireccion.TabIndex = 9;
            this.TxtDireccion.Leave += new System.EventHandler(this.TxtDireccion_Leave);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(13, 243);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(37, 13);
            this.LblEmail.TabIndex = 10;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(13, 259);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(307, 20);
            this.TxtEmail.TabIndex = 11;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtTelefeno1
            // 
            this.TxtTelefeno1.Location = new System.Drawing.Point(10, 316);
            this.TxtTelefeno1.Name = "TxtTelefeno1";
            this.TxtTelefeno1.Size = new System.Drawing.Size(130, 20);
            this.TxtTelefeno1.TabIndex = 12;
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono1.Location = new System.Drawing.Point(10, 300);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(130, 13);
            this.LblTelefono1.TabIndex = 13;
            this.LblTelefono1.Text = "Telefono 1 (Opcional)";
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono2.Location = new System.Drawing.Point(176, 300);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(130, 13);
            this.LblTelefono2.TabIndex = 14;
            this.LblTelefono2.Text = "Telefono 2 (Opcional)";
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(177, 316);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(129, 20);
            this.TxtTelefono2.TabIndex = 15;
            // 
            // TxtTelefono3
            // 
            this.TxtTelefono3.Location = new System.Drawing.Point(334, 316);
            this.TxtTelefono3.Name = "TxtTelefono3";
            this.TxtTelefono3.Size = new System.Drawing.Size(119, 20);
            this.TxtTelefono3.TabIndex = 16;
            // 
            // LblTelefono3
            // 
            this.LblTelefono3.AutoSize = true;
            this.LblTelefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono3.Location = new System.Drawing.Point(323, 300);
            this.LblTelefono3.Name = "LblTelefono3";
            this.LblTelefono3.Size = new System.Drawing.Size(130, 13);
            this.LblTelefono3.TabIndex = 17;
            this.LblTelefono3.Text = "Telefono 3 (Opcional)";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(58, 382);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(123, 36);
            this.BtnGuardar.TabIndex = 18;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(253, 382);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 36);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblRutObligatorio
            // 
            this.LblRutObligatorio.AutoSize = true;
            this.LblRutObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblRutObligatorio.Location = new System.Drawing.Point(217, 100);
            this.LblRutObligatorio.Name = "LblRutObligatorio";
            this.LblRutObligatorio.Size = new System.Drawing.Size(119, 16);
            this.LblRutObligatorio.TabIndex = 20;
            this.LblRutObligatorio.Text = "* OBLIGATORIO";
            this.LblRutObligatorio.Visible = false;
            // 
            // lblMensajeNombre
            // 
            this.lblMensajeNombre.AutoSize = true;
            this.lblMensajeNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeNombre.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeNombre.Location = new System.Drawing.Point(327, 153);
            this.lblMensajeNombre.Name = "lblMensajeNombre";
            this.lblMensajeNombre.Size = new System.Drawing.Size(20, 18);
            this.lblMensajeNombre.TabIndex = 21;
            this.lblMensajeNombre.Text = "* ";
            this.lblMensajeNombre.Visible = false;
            // 
            // lblMensajeDireccion
            // 
            this.lblMensajeDireccion.AutoSize = true;
            this.lblMensajeDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDireccion.Location = new System.Drawing.Point(459, 210);
            this.lblMensajeDireccion.Name = "lblMensajeDireccion";
            this.lblMensajeDireccion.Size = new System.Drawing.Size(15, 18);
            this.lblMensajeDireccion.TabIndex = 23;
            this.lblMensajeDireccion.Text = "*";
            this.lblMensajeDireccion.Visible = false;
            // 
            // lblMensajeEmail
            // 
            this.lblMensajeEmail.AutoSize = true;
            this.lblMensajeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeEmail.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeEmail.Location = new System.Drawing.Point(326, 261);
            this.lblMensajeEmail.Name = "lblMensajeEmail";
            this.lblMensajeEmail.Size = new System.Drawing.Size(15, 18);
            this.lblMensajeEmail.TabIndex = 24;
            this.lblMensajeEmail.Text = "*";
            this.lblMensajeEmail.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // FormularioMantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 446);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensajeEmail);
            this.Controls.Add(this.lblMensajeDireccion);
            this.Controls.Add(this.lblMensajeNombre);
            this.Controls.Add(this.LblRutObligatorio);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTelefono3);
            this.Controls.Add(this.TxtTelefono3);
            this.Controls.Add(this.TxtTelefono2);
            this.Controls.Add(this.LblTelefono2);
            this.Controls.Add(this.LblTelefono1);
            this.Controls.Add(this.TxtTelefeno1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtRutCliente);
            this.Controls.Add(this.LblRutCliente);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblRutCliente;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTelefono1;
        private System.Windows.Forms.Label LblTelefono2;
        private System.Windows.Forms.Label LblTelefono3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.TextBox TxtRutCliente;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.TextBox TxtDireccion;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.TextBox TxtTelefeno1;
        public System.Windows.Forms.TextBox TxtTelefono2;
        public System.Windows.Forms.TextBox TxtTelefono3;
        private System.Windows.Forms.Label LblRutObligatorio;
        private System.Windows.Forms.Label lblMensajeNombre;
        private System.Windows.Forms.Label lblMensajeDireccion;
        private System.Windows.Forms.Label lblMensajeEmail;
        private System.Windows.Forms.Label label1;
    }
}