namespace AppPrincipal
{
    partial class FormularioMantenedorProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorProveedor));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblRut = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblRutObligatorio = new System.Windows.Forms.Label();
            this.LblRazonSocialObligatorio = new System.Windows.Forms.Label();
            this.LblTelefonoObligatorio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccionObligatoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmailObligatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(171, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "PROVEEDOR";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(78, 332);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(138, 39);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(317, 332);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(138, 39);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblRut
            // 
            this.LblRut.AutoSize = true;
            this.LblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRut.Location = new System.Drawing.Point(16, 70);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(27, 13);
            this.LblRut.TabIndex = 4;
            this.LblRut.Text = "Rut";
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(12, 86);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(171, 20);
            this.TxtRut.TabIndex = 5;
            this.TxtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRut_KeyPress);
            this.TxtRut.Leave += new System.EventHandler(this.TxtRut_Leave);
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(9, 125);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(82, 13);
            this.LblRazonSocial.TabIndex = 6;
            this.LblRazonSocial.Text = "Razon Social";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(12, 141);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(443, 20);
            this.TxtRazonSocial.TabIndex = 7;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(9, 263);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(57, 13);
            this.LblTelefono.TabIndex = 8;
            this.LblTelefono.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(12, 279);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(193, 20);
            this.TxtTelefono.TabIndex = 9;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            this.TxtTelefono.Leave += new System.EventHandler(this.TxtTelefono_Leave);
            // 
            // LblRutObligatorio
            // 
            this.LblRutObligatorio.AutoSize = true;
            this.LblRutObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblRutObligatorio.Location = new System.Drawing.Point(189, 86);
            this.LblRutObligatorio.Name = "LblRutObligatorio";
            this.LblRutObligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblRutObligatorio.TabIndex = 12;
            this.LblRutObligatorio.Text = "*";
            this.LblRutObligatorio.Visible = false;
            // 
            // LblRazonSocialObligatorio
            // 
            this.LblRazonSocialObligatorio.AutoSize = true;
            this.LblRazonSocialObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocialObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblRazonSocialObligatorio.Location = new System.Drawing.Point(459, 141);
            this.LblRazonSocialObligatorio.Name = "LblRazonSocialObligatorio";
            this.LblRazonSocialObligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblRazonSocialObligatorio.TabIndex = 13;
            this.LblRazonSocialObligatorio.Text = "*";
            this.LblRazonSocialObligatorio.Visible = false;
            this.LblRazonSocialObligatorio.Leave += new System.EventHandler(this.LblRazonSocialObligatorio_Leave);
            // 
            // LblTelefonoObligatorio
            // 
            this.LblTelefonoObligatorio.AutoSize = true;
            this.LblTelefonoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefonoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblTelefonoObligatorio.Location = new System.Drawing.Point(211, 279);
            this.LblTelefonoObligatorio.Name = "LblTelefonoObligatorio";
            this.LblTelefonoObligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblTelefonoObligatorio.TabIndex = 14;
            this.LblTelefonoObligatorio.Text = "*";
            this.LblTelefonoObligatorio.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(12, 185);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(443, 20);
            this.TxtDireccion.TabIndex = 17;
            // 
            // LblDireccionObligatoria
            // 
            this.LblDireccionObligatoria.AutoSize = true;
            this.LblDireccionObligatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccionObligatoria.ForeColor = System.Drawing.Color.Red;
            this.LblDireccionObligatoria.Location = new System.Drawing.Point(458, 185);
            this.LblDireccionObligatoria.Name = "LblDireccionObligatoria";
            this.LblDireccionObligatoria.Size = new System.Drawing.Size(16, 20);
            this.LblDireccionObligatoria.TabIndex = 18;
            this.LblDireccionObligatoria.Text = "*";
            this.LblDireccionObligatoria.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(12, 229);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(443, 20);
            this.TxtEmail.TabIndex = 20;
            // 
            // LblEmailObligatorio
            // 
            this.LblEmailObligatorio.AutoSize = true;
            this.LblEmailObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblEmailObligatorio.Location = new System.Drawing.Point(458, 229);
            this.LblEmailObligatorio.Name = "LblEmailObligatorio";
            this.LblEmailObligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblEmailObligatorio.TabIndex = 21;
            this.LblEmailObligatorio.Text = "*";
            this.LblEmailObligatorio.Visible = false;
            // 
            // FormularioMantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 395);
            this.ControlBox = false;
            this.Controls.Add(this.LblEmailObligatorio);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDireccionObligatoria);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTelefonoObligatorio);
            this.Controls.Add(this.LblRazonSocialObligatorio);
            this.Controls.Add(this.LblRutObligatorio);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TxtRazonSocial);
            this.Controls.Add(this.LblRazonSocial);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.LblRut);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.Label LblTelefono;
        public System.Windows.Forms.TextBox TxtRut;
        public System.Windows.Forms.TextBox TxtRazonSocial;
        public System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblRutObligatorio;
        private System.Windows.Forms.Label LblRazonSocialObligatorio;
        private System.Windows.Forms.Label LblTelefonoObligatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccionObligatoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmailObligatorio;
    }
}