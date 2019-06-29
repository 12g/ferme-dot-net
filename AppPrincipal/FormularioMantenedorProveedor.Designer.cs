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
            this.LblRutObligatorio = new System.Windows.Forms.Label();
            this.LblRazonSocialObligatorio = new System.Windows.Forms.Label();
            this.IdProveedor = new System.Windows.Forms.Label();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.TxtIdPersona = new System.Windows.Forms.TextBox();
            this.LblIdPersona = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(146, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "PROVEEDOR";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(73, 169);
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
            this.BtnCancelar.Location = new System.Drawing.Point(279, 169);
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
            this.LblRut.Location = new System.Drawing.Point(12, 48);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(27, 13);
            this.LblRut.TabIndex = 4;
            this.LblRut.Text = "Rut";
            // 
            // TxtRut
            // 
            this.TxtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.Location = new System.Drawing.Point(12, 64);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(222, 20);
            this.TxtRut.TabIndex = 5;
            this.TxtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRut_KeyPress);
            this.TxtRut.Leave += new System.EventHandler(this.TxtRut_Leave);
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(9, 107);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(82, 13);
            this.LblRazonSocial.TabIndex = 6;
            this.LblRazonSocial.Text = "Razon Social";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(12, 123);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(293, 20);
            this.TxtRazonSocial.TabIndex = 7;
            // 
            // LblRutObligatorio
            // 
            this.LblRutObligatorio.AutoSize = true;
            this.LblRutObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblRutObligatorio.Location = new System.Drawing.Point(240, 64);
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
            this.LblRazonSocialObligatorio.Location = new System.Drawing.Point(311, 123);
            this.LblRazonSocialObligatorio.Name = "LblRazonSocialObligatorio";
            this.LblRazonSocialObligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblRazonSocialObligatorio.TabIndex = 13;
            this.LblRazonSocialObligatorio.Text = "*";
            this.LblRazonSocialObligatorio.Visible = false;
            this.LblRazonSocialObligatorio.Leave += new System.EventHandler(this.LblRazonSocialObligatorio_Leave);
            // 
            // IdProveedor
            // 
            this.IdProveedor.AutoSize = true;
            this.IdProveedor.Location = new System.Drawing.Point(9, 217);
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.Size = new System.Drawing.Size(65, 13);
            this.IdProveedor.TabIndex = 28;
            this.IdProveedor.Text = "IdProveedor";
            this.IdProveedor.Visible = false;
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Location = new System.Drawing.Point(84, 214);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.ReadOnly = true;
            this.TxtIdProveedor.Size = new System.Drawing.Size(127, 20);
            this.TxtIdProveedor.TabIndex = 29;
            this.TxtIdProveedor.Visible = false;
            // 
            // TxtIdPersona
            // 
            this.TxtIdPersona.Location = new System.Drawing.Point(354, 214);
            this.TxtIdPersona.Name = "TxtIdPersona";
            this.TxtIdPersona.ReadOnly = true;
            this.TxtIdPersona.Size = new System.Drawing.Size(127, 20);
            this.TxtIdPersona.TabIndex = 30;
            this.TxtIdPersona.Visible = false;
            // 
            // LblIdPersona
            // 
            this.LblIdPersona.AutoSize = true;
            this.LblIdPersona.Location = new System.Drawing.Point(288, 217);
            this.LblIdPersona.Name = "LblIdPersona";
            this.LblIdPersona.Size = new System.Drawing.Size(55, 13);
            this.LblIdPersona.TabIndex = 31;
            this.LblIdPersona.Text = "IdPersona";
            this.LblIdPersona.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioMantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 238);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblIdPersona);
            this.Controls.Add(this.TxtIdPersona);
            this.Controls.Add(this.TxtIdProveedor);
            this.Controls.Add(this.IdProveedor);
            this.Controls.Add(this.LblRazonSocialObligatorio);
            this.Controls.Add(this.LblRutObligatorio);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.Label LblRazonSocial;
        public System.Windows.Forms.TextBox TxtRut;
        public System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRutObligatorio;
        private System.Windows.Forms.Label LblRazonSocialObligatorio;
        private System.Windows.Forms.Label IdProveedor;
        public System.Windows.Forms.TextBox TxtIdProveedor;
        public System.Windows.Forms.TextBox TxtIdPersona;
        private System.Windows.Forms.Label LblIdPersona;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}