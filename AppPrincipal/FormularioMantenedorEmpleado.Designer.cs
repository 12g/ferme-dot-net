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
            this.LblCargo = new System.Windows.Forms.Label();
            this.CbxCargo = new System.Windows.Forms.ComboBox();
            this.LblIdEmpleado = new System.Windows.Forms.Label();
            this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.TxtIdPersona = new System.Windows.Forms.TextBox();
            this.lblIdpersona = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(68, 159);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(122, 35);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(301, 159);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(122, 35);
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
            this.TxtRutCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRutCliente.Location = new System.Drawing.Point(12, 88);
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(151, 20);
            this.TxtRutCliente.TabIndex = 4;
            this.TxtRutCliente.Leave += new System.EventHandler(this.TxtRutCliente_Leave);
            // 
            // LblRutObligatorio
            // 
            this.LblRutObligatorio.AutoSize = true;
            this.LblRutObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblRutObligatorio.Location = new System.Drawing.Point(45, 72);
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
            this.LblNombre.Location = new System.Drawing.Point(9, 118);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 13);
            this.LblNombre.TabIndex = 22;
            this.LblNombre.Text = "Nombres";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(12, 133);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(464, 20);
            this.TxtNombre.TabIndex = 23;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // lblMensajeNombre
            // 
            this.lblMensajeNombre.AutoSize = true;
            this.lblMensajeNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeNombre.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeNombre.Location = new System.Drawing.Point(65, 112);
            this.lblMensajeNombre.Name = "lblMensajeNombre";
            this.lblMensajeNombre.Size = new System.Drawing.Size(20, 18);
            this.lblMensajeNombre.TabIndex = 24;
            this.lblMensajeNombre.Text = "* ";
            this.lblMensajeNombre.Visible = false;
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(175, 72);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(40, 13);
            this.LblCargo.TabIndex = 37;
            this.LblCargo.Text = "Cargo";
            // 
            // CbxCargo
            // 
            this.CbxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCargo.FormattingEnabled = true;
            this.CbxCargo.Location = new System.Drawing.Point(178, 87);
            this.CbxCargo.Name = "CbxCargo";
            this.CbxCargo.Size = new System.Drawing.Size(144, 21);
            this.CbxCargo.TabIndex = 38;
            // 
            // LblIdEmpleado
            // 
            this.LblIdEmpleado.AutoSize = true;
            this.LblIdEmpleado.Location = new System.Drawing.Point(259, 203);
            this.LblIdEmpleado.Name = "LblIdEmpleado";
            this.LblIdEmpleado.Size = new System.Drawing.Size(63, 13);
            this.LblIdEmpleado.TabIndex = 39;
            this.LblIdEmpleado.Text = "IdEmpleado";
            this.LblIdEmpleado.Visible = false;
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Location = new System.Drawing.Point(328, 203);
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.ReadOnly = true;
            this.TxtIdEmpleado.Size = new System.Drawing.Size(148, 20);
            this.TxtIdEmpleado.TabIndex = 40;
            this.TxtIdEmpleado.Visible = false;
            // 
            // TxtIdPersona
            // 
            this.TxtIdPersona.Location = new System.Drawing.Point(67, 200);
            this.TxtIdPersona.Name = "TxtIdPersona";
            this.TxtIdPersona.ReadOnly = true;
            this.TxtIdPersona.Size = new System.Drawing.Size(148, 20);
            this.TxtIdPersona.TabIndex = 41;
            this.TxtIdPersona.Visible = false;
            // 
            // lblIdpersona
            // 
            this.lblIdpersona.AutoSize = true;
            this.lblIdpersona.Location = new System.Drawing.Point(8, 203);
            this.lblIdpersona.Name = "lblIdpersona";
            this.lblIdpersona.Size = new System.Drawing.Size(55, 13);
            this.lblIdpersona.TabIndex = 42;
            this.lblIdpersona.Text = "IdPersona";
            this.lblIdpersona.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioMantenedorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 229);
            this.ControlBox = false;
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIdpersona);
            this.Controls.Add(this.TxtIdPersona);
            this.Controls.Add(this.TxtIdEmpleado);
            this.Controls.Add(this.LblIdEmpleado);
            this.Controls.Add(this.CbxCargo);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.lblMensajeNombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblRutObligatorio);
            this.Controls.Add(this.TxtRutCliente);
            this.Controls.Add(this.LblRutCliente);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label LblCargo;
        public System.Windows.Forms.ComboBox CbxCargo;
        private System.Windows.Forms.Label LblIdEmpleado;
        public System.Windows.Forms.TextBox TxtIdEmpleado;
        public System.Windows.Forms.TextBox TxtIdPersona;
        private System.Windows.Forms.Label lblIdpersona;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}