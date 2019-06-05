namespace AppPrincipal
{
    partial class FormularioMantenedorUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorUsuario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblRut = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.CbCargo = new System.Windows.Forms.ComboBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblRutObligatorio = new System.Windows.Forms.Label();
            this.LblCargoObligatorio = new System.Windows.Forms.Label();
            this.LblNombreObligatorio = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccionObligatoria = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmailObligatorio = new System.Windows.Forms.Label();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.TxtTelefono1 = new System.Windows.Forms.TextBox();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.LblTelefono3 = new System.Windows.Forms.Label();
            this.TxtTelefono3 = new System.Windows.Forms.TextBox();
            this.LblTelefono1Obligatorio = new System.Windows.Forms.Label();
            this.IdUsuario = new System.Windows.Forms.Label();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(204, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "USUARIO";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(71, 450);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(117, 39);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(327, 450);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(117, 39);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblRut
            // 
            this.LblRut.AutoSize = true;
            this.LblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRut.Location = new System.Drawing.Point(29, 72);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(27, 13);
            this.LblRut.TabIndex = 4;
            this.LblRut.Text = "Rut";
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(71, 65);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(157, 20);
            this.TxtRut.TabIndex = 5;
            this.TxtRut.Leave += new System.EventHandler(this.TxtRut_Leave);
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(281, 72);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(40, 13);
            this.LblCargo.TabIndex = 6;
            this.LblCargo.Text = "Cargo";
            // 
            // CbCargo
            // 
            this.CbCargo.FormattingEnabled = true;
            this.CbCargo.Location = new System.Drawing.Point(327, 64);
            this.CbCargo.Name = "CbCargo";
            this.CbCargo.Size = new System.Drawing.Size(175, 21);
            this.CbCargo.TabIndex = 7;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(15, 118);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(71, 113);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(431, 20);
            this.TxtNombre.TabIndex = 9;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // LblRutObligatorio
            // 
            this.LblRutObligatorio.AutoSize = true;
            this.LblRutObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblRutObligatorio.Location = new System.Drawing.Point(232, 67);
            this.LblRutObligatorio.Name = "LblRutObligatorio";
            this.LblRutObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblRutObligatorio.TabIndex = 10;
            this.LblRutObligatorio.Text = "*";
            this.LblRutObligatorio.Visible = false;
            // 
            // LblCargoObligatorio
            // 
            this.LblCargoObligatorio.AutoSize = true;
            this.LblCargoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblCargoObligatorio.Location = new System.Drawing.Point(506, 66);
            this.LblCargoObligatorio.Name = "LblCargoObligatorio";
            this.LblCargoObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblCargoObligatorio.TabIndex = 11;
            this.LblCargoObligatorio.Text = "*";
            this.LblCargoObligatorio.Visible = false;
            // 
            // LblNombreObligatorio
            // 
            this.LblNombreObligatorio.AutoSize = true;
            this.LblNombreObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblNombreObligatorio.Location = new System.Drawing.Point(507, 115);
            this.LblNombreObligatorio.Name = "LblNombreObligatorio";
            this.LblNombreObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblNombreObligatorio.TabIndex = 12;
            this.LblNombreObligatorio.Text = "*";
            this.LblNombreObligatorio.Visible = false;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(4, 155);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(61, 13);
            this.LblDireccion.TabIndex = 13;
            this.LblDireccion.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(71, 147);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(431, 20);
            this.TxtDireccion.TabIndex = 14;
            // 
            // LblDireccionObligatoria
            // 
            this.LblDireccionObligatoria.AutoSize = true;
            this.LblDireccionObligatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccionObligatoria.ForeColor = System.Drawing.Color.Red;
            this.LblDireccionObligatoria.Location = new System.Drawing.Point(505, 149);
            this.LblDireccionObligatoria.Name = "LblDireccionObligatoria";
            this.LblDireccionObligatoria.Size = new System.Drawing.Size(16, 20);
            this.LblDireccionObligatoria.TabIndex = 15;
            this.LblDireccionObligatoria.Text = "*";
            this.LblDireccionObligatoria.Visible = false;
            this.LblDireccionObligatoria.Leave += new System.EventHandler(this.LblDireccionObligatoria_Leave);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(13, 190);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(37, 13);
            this.LblEmail.TabIndex = 16;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(71, 182);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(431, 20);
            this.TxtEmail.TabIndex = 17;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // LblEmailObligatorio
            // 
            this.LblEmailObligatorio.AutoSize = true;
            this.LblEmailObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblEmailObligatorio.Location = new System.Drawing.Point(505, 183);
            this.LblEmailObligatorio.Name = "LblEmailObligatorio";
            this.LblEmailObligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblEmailObligatorio.TabIndex = 18;
            this.LblEmailObligatorio.Text = "*";
            this.LblEmailObligatorio.Visible = false;
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono1.Location = new System.Drawing.Point(1, 230);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(68, 13);
            this.LblTelefono1.TabIndex = 19;
            this.LblTelefono1.Text = "Telefono 1";
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Location = new System.Drawing.Point(71, 223);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.Size = new System.Drawing.Size(168, 20);
            this.TxtTelefono1.TabIndex = 20;
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono2.Location = new System.Drawing.Point(259, 226);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(68, 13);
            this.LblTelefono2.TabIndex = 21;
            this.LblTelefono2.Text = "Telefono 2";
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(327, 223);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(176, 20);
            this.TxtTelefono2.TabIndex = 22;
            // 
            // LblTelefono3
            // 
            this.LblTelefono3.AutoSize = true;
            this.LblTelefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono3.Location = new System.Drawing.Point(0, 268);
            this.LblTelefono3.Name = "LblTelefono3";
            this.LblTelefono3.Size = new System.Drawing.Size(68, 13);
            this.LblTelefono3.TabIndex = 23;
            this.LblTelefono3.Text = "Telefono 3";
            // 
            // TxtTelefono3
            // 
            this.TxtTelefono3.Location = new System.Drawing.Point(71, 265);
            this.TxtTelefono3.Name = "TxtTelefono3";
            this.TxtTelefono3.Size = new System.Drawing.Size(168, 20);
            this.TxtTelefono3.TabIndex = 24;
            // 
            // LblTelefono1Obligatorio
            // 
            this.LblTelefono1Obligatorio.AutoSize = true;
            this.LblTelefono1Obligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono1Obligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblTelefono1Obligatorio.Location = new System.Drawing.Point(241, 225);
            this.LblTelefono1Obligatorio.Name = "LblTelefono1Obligatorio";
            this.LblTelefono1Obligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblTelefono1Obligatorio.TabIndex = 25;
            this.LblTelefono1Obligatorio.Text = "*";
            this.LblTelefono1Obligatorio.Visible = false;
            // 
            // IdUsuario
            // 
            this.IdUsuario.AutoSize = true;
            this.IdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario.Location = new System.Drawing.Point(8, 9);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(61, 13);
            this.IdUsuario.TabIndex = 26;
            this.IdUsuario.Text = "IdUsuario";
            this.IdUsuario.Visible = false;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(11, 25);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.ReadOnly = true;
            this.TxtIdUsuario.Size = new System.Drawing.Size(126, 20);
            this.TxtIdUsuario.TabIndex = 27;
            this.TxtIdUsuario.Visible = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(38, 331);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(50, 13);
            this.LblUsuario.TabIndex = 28;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(41, 347);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(168, 20);
            this.TxtUsuario.TabIndex = 29;
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(310, 331);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(71, 13);
            this.LblContraseña.TabIndex = 30;
            this.LblContraseña.Text = "Contraseña";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(313, 347);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(176, 20);
            this.TxtContraseña.TabIndex = 31;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(279, 265);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(42, 13);
            this.LblFecha.TabIndex = 32;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(327, 261);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.ReadOnly = true;
            this.TxtFecha.Size = new System.Drawing.Size(176, 20);
            this.TxtFecha.TabIndex = 33;
            // 
            // FormularioMantenedorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 501);
            this.ControlBox = false;
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.IdUsuario);
            this.Controls.Add(this.LblTelefono1Obligatorio);
            this.Controls.Add(this.TxtTelefono3);
            this.Controls.Add(this.LblTelefono3);
            this.Controls.Add(this.TxtTelefono2);
            this.Controls.Add(this.LblTelefono2);
            this.Controls.Add(this.TxtTelefono1);
            this.Controls.Add(this.LblTelefono1);
            this.Controls.Add(this.LblEmailObligatorio);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblDireccionObligatoria);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblNombreObligatorio);
            this.Controls.Add(this.LblCargoObligatorio);
            this.Controls.Add(this.LblRutObligatorio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.CbCargo);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.LblRut);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioMantenedorUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Usuario";
            this.Load += new System.EventHandler(this.FormularioMantenedorUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.ComboBox CbCargo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblRutObligatorio;
        private System.Windows.Forms.Label LblCargoObligatorio;
        private System.Windows.Forms.Label LblNombreObligatorio;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccionObligatoria;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmailObligatorio;
        private System.Windows.Forms.Label LblTelefono1;
        private System.Windows.Forms.TextBox TxtTelefono1;
        private System.Windows.Forms.Label LblTelefono2;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.Label LblTelefono3;
        private System.Windows.Forms.TextBox TxtTelefono3;
        private System.Windows.Forms.Label LblTelefono1Obligatorio;
        private System.Windows.Forms.Label IdUsuario;
        public System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtFecha;
    }
}