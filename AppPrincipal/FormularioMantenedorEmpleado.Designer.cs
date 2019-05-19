namespace AppPrincipal
{
    partial class FormularioMantenedorEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorEmpleado));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblRutCliente = new System.Windows.Forms.Label();
            this.TxtRutCliente = new System.Windows.Forms.TextBox();
            this.LblRutObligatorio = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblMensajeNombre = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.lblMensajeDireccion = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.lblMensajeEmail = new System.Windows.Forms.Label();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.TxtTelefeno1 = new System.Windows.Forms.TextBox();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.LblTelefono3 = new System.Windows.Forms.Label();
            this.TxtTelefono3 = new System.Windows.Forms.TextBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.CbxCargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(72, 345);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(122, 46);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(285, 345);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(122, 46);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(172, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(143, 31);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Empleado";
            // 
            // LblRutCliente
            // 
            this.LblRutCliente.AutoSize = true;
            this.LblRutCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutCliente.Location = new System.Drawing.Point(12, 72);
            this.LblRutCliente.Name = "LblRutCliente";
            this.LblRutCliente.Size = new System.Drawing.Size(27, 13);
            this.LblRutCliente.TabIndex = 3;
            this.LblRutCliente.Text = "Rut";
            // 
            // TxtRutCliente
            // 
            this.TxtRutCliente.Location = new System.Drawing.Point(12, 88);
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(197, 20);
            this.TxtRutCliente.TabIndex = 4;
            this.TxtRutCliente.Leave += new System.EventHandler(this.TxtRutCliente_Leave);
            // 
            // LblRutObligatorio
            // 
            this.LblRutObligatorio.AutoSize = true;
            this.LblRutObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblRutObligatorio.Location = new System.Drawing.Point(212, 89);
            this.LblRutObligatorio.Name = "LblRutObligatorio";
            this.LblRutObligatorio.Size = new System.Drawing.Size(18, 16);
            this.LblRutObligatorio.TabIndex = 21;
            this.LblRutObligatorio.Text = "* ";
            this.LblRutObligatorio.Visible = false;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(12, 124);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 13);
            this.LblNombre.TabIndex = 22;
            this.LblNombre.Text = "Nombres";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(12, 140);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(307, 20);
            this.TxtNombre.TabIndex = 23;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // lblMensajeNombre
            // 
            this.lblMensajeNombre.AutoSize = true;
            this.lblMensajeNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeNombre.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeNombre.Location = new System.Drawing.Point(325, 142);
            this.lblMensajeNombre.Name = "lblMensajeNombre";
            this.lblMensajeNombre.Size = new System.Drawing.Size(20, 18);
            this.lblMensajeNombre.TabIndex = 24;
            this.lblMensajeNombre.Text = "* ";
            this.lblMensajeNombre.Visible = false;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(12, 178);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(61, 13);
            this.LblDireccion.TabIndex = 25;
            this.LblDireccion.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(12, 194);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(441, 20);
            this.TxtDireccion.TabIndex = 26;
            this.TxtDireccion.Leave += new System.EventHandler(this.TxtDireccion_Leave);
            // 
            // lblMensajeDireccion
            // 
            this.lblMensajeDireccion.AutoSize = true;
            this.lblMensajeDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDireccion.Location = new System.Drawing.Point(455, 196);
            this.lblMensajeDireccion.Name = "lblMensajeDireccion";
            this.lblMensajeDireccion.Size = new System.Drawing.Size(15, 18);
            this.lblMensajeDireccion.TabIndex = 27;
            this.lblMensajeDireccion.Text = "*";
            this.lblMensajeDireccion.Visible = false;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(12, 229);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(37, 13);
            this.LblEmail.TabIndex = 28;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(12, 245);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(307, 20);
            this.TxtEmail.TabIndex = 29;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // lblMensajeEmail
            // 
            this.lblMensajeEmail.AutoSize = true;
            this.lblMensajeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeEmail.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeEmail.Location = new System.Drawing.Point(322, 245);
            this.lblMensajeEmail.Name = "lblMensajeEmail";
            this.lblMensajeEmail.Size = new System.Drawing.Size(15, 18);
            this.lblMensajeEmail.TabIndex = 30;
            this.lblMensajeEmail.Text = "*";
            this.lblMensajeEmail.Visible = false;
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono1.Location = new System.Drawing.Point(12, 283);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(130, 13);
            this.LblTelefono1.TabIndex = 31;
            this.LblTelefono1.Text = "Telefono 1 (Opcional)";
            // 
            // TxtTelefeno1
            // 
            this.TxtTelefeno1.Location = new System.Drawing.Point(12, 299);
            this.TxtTelefeno1.Name = "TxtTelefeno1";
            this.TxtTelefeno1.Size = new System.Drawing.Size(130, 20);
            this.TxtTelefeno1.TabIndex = 32;
            this.TxtTelefeno1.Text = "0";
            this.TxtTelefeno1.Leave += new System.EventHandler(this.TxtTelefeno1_Leave);
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono2.Location = new System.Drawing.Point(189, 283);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(130, 13);
            this.LblTelefono2.TabIndex = 33;
            this.LblTelefono2.Text = "Telefono 2 (Opcional)";
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(192, 299);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(129, 20);
            this.TxtTelefono2.TabIndex = 34;
            this.TxtTelefono2.Text = "0";
            this.TxtTelefono2.Leave += new System.EventHandler(this.TxtTelefono2_Leave);
            // 
            // LblTelefono3
            // 
            this.LblTelefono3.AutoSize = true;
            this.LblTelefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono3.Location = new System.Drawing.Point(351, 283);
            this.LblTelefono3.Name = "LblTelefono3";
            this.LblTelefono3.Size = new System.Drawing.Size(130, 13);
            this.LblTelefono3.TabIndex = 35;
            this.LblTelefono3.Text = "Telefono 3 (Opcional)";
            // 
            // TxtTelefono3
            // 
            this.TxtTelefono3.Location = new System.Drawing.Point(354, 299);
            this.TxtTelefono3.Name = "TxtTelefono3";
            this.TxtTelefono3.Size = new System.Drawing.Size(119, 20);
            this.TxtTelefono3.TabIndex = 36;
            this.TxtTelefono3.Text = "0";
            this.TxtTelefono3.Leave += new System.EventHandler(this.TxtTelefono3_Leave);
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(262, 71);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(40, 13);
            this.LblCargo.TabIndex = 37;
            this.LblCargo.Text = "Cargo";
            // 
            // CbxCargo
            // 
            this.CbxCargo.FormattingEnabled = true;
            this.CbxCargo.Location = new System.Drawing.Point(265, 87);
            this.CbxCargo.Name = "CbxCargo";
            this.CbxCargo.Size = new System.Drawing.Size(188, 21);
            this.CbxCargo.TabIndex = 38;
            // 
            // FormularioMantenedorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 408);
            this.ControlBox = false;
            this.Controls.Add(this.CbxCargo);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.TxtTelefono3);
            this.Controls.Add(this.LblTelefono3);
            this.Controls.Add(this.TxtTelefono2);
            this.Controls.Add(this.LblTelefono2);
            this.Controls.Add(this.TxtTelefeno1);
            this.Controls.Add(this.LblTelefono1);
            this.Controls.Add(this.lblMensajeEmail);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.lblMensajeDireccion);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblMensajeNombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblRutObligatorio);
            this.Controls.Add(this.TxtRutCliente);
            this.Controls.Add(this.LblRutCliente);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorEmpleado";
            this.Text = "Mantenedor Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblRutCliente;
        public System.Windows.Forms.TextBox TxtRutCliente;
        private System.Windows.Forms.Label LblRutObligatorio;
        private System.Windows.Forms.Label LblNombre;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lblMensajeNombre;
        private System.Windows.Forms.Label LblDireccion;
        public System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label lblMensajeDireccion;
        private System.Windows.Forms.Label LblEmail;
        public System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label lblMensajeEmail;
        private System.Windows.Forms.Label LblTelefono1;
        public System.Windows.Forms.TextBox TxtTelefeno1;
        private System.Windows.Forms.Label LblTelefono2;
        public System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.Label LblTelefono3;
        public System.Windows.Forms.TextBox TxtTelefono3;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.ComboBox CbxCargo;
    }
}