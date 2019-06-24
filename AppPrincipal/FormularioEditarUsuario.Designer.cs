namespace AppPrincipal
{
    partial class FormularioEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEditarUsuario));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.IdUsuario = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.LblRut = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TxtIdPersona = new System.Windows.Forms.TextBox();
            this.LblIdpersona = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(172, 69);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 51;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(315, 69);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(176, 20);
            this.TxtFecha.TabIndex = 50;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(312, 56);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(42, 13);
            this.LblFecha.TabIndex = 49;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(281, 185);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(225, 20);
            this.TxtContraseña.TabIndex = 48;
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(283, 169);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(71, 13);
            this.LblContraseña.TabIndex = 47;
            this.LblContraseña.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(26, 185);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(225, 20);
            this.TxtUsuario.TabIndex = 46;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(23, 169);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(50, 13);
            this.LblUsuario.TabIndex = 45;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(380, 270);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.ReadOnly = true;
            this.TxtIdUsuario.Size = new System.Drawing.Size(126, 20);
            this.TxtIdUsuario.TabIndex = 44;
            this.TxtIdUsuario.Visible = false;
            // 
            // IdUsuario
            // 
            this.IdUsuario.AutoSize = true;
            this.IdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario.Location = new System.Drawing.Point(312, 273);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(61, 13);
            this.IdUsuario.TabIndex = 43;
            this.IdUsuario.Text = "IdUsuario";
            this.IdUsuario.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(22, 125);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(484, 20);
            this.TxtNombre.TabIndex = 42;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(19, 109);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 41;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(22, 72);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(144, 20);
            this.TxtRut.TabIndex = 40;
            // 
            // LblRut
            // 
            this.LblRut.AutoSize = true;
            this.LblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRut.Location = new System.Drawing.Point(19, 56);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(27, 13);
            this.LblRut.TabIndex = 39;
            this.LblRut.Text = "Rut";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(298, 225);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(117, 39);
            this.BtnCancelar.TabIndex = 38;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(98, 225);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(117, 39);
            this.BtnAceptar.TabIndex = 37;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(142, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 31);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "EDITAR USUARIO";
            // 
            // TxtIdPersona
            // 
            this.TxtIdPersona.Location = new System.Drawing.Point(89, 270);
            this.TxtIdPersona.Name = "TxtIdPersona";
            this.TxtIdPersona.ReadOnly = true;
            this.TxtIdPersona.Size = new System.Drawing.Size(126, 20);
            this.TxtIdPersona.TabIndex = 52;
            this.TxtIdPersona.Visible = false;
            // 
            // LblIdpersona
            // 
            this.LblIdpersona.AutoSize = true;
            this.LblIdpersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdpersona.Location = new System.Drawing.Point(19, 273);
            this.LblIdpersona.Name = "LblIdpersona";
            this.LblIdpersona.Size = new System.Drawing.Size(64, 13);
            this.LblIdpersona.TabIndex = 53;
            this.LblIdpersona.Text = "IdPersona";
            this.LblIdpersona.Visible = false;
            // 
            // FormularioEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(526, 297);
            this.ControlBox = false;
            this.Controls.Add(this.LblIdpersona);
            this.Controls.Add(this.TxtIdPersona);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.IdUsuario);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.LblRut);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioEditarUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioEditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblFecha;
        public System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblContraseña;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        public System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Label IdUsuario;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        public System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.TextBox TxtIdPersona;
        private System.Windows.Forms.Label LblIdpersona;
        public System.Windows.Forms.TextBox TxtFecha;
    }
}