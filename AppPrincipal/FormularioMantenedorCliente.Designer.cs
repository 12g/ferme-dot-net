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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorCliente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblRutCliente = new System.Windows.Forms.Label();
            this.TxtRutCliente = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblRutObligatorio = new System.Windows.Forms.Label();
            this.lblMensajeNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.TxtIdPersona = new System.Windows.Forms.TextBox();
            this.LblIdPersona = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.LblRutCliente.Location = new System.Drawing.Point(13, 51);
            this.LblRutCliente.Name = "LblRutCliente";
            this.LblRutCliente.Size = new System.Drawing.Size(27, 13);
            this.LblRutCliente.TabIndex = 2;
            this.LblRutCliente.Text = "Rut";
            // 
            // TxtRutCliente
            // 
            this.TxtRutCliente.Location = new System.Drawing.Point(12, 67);
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(197, 20);
            this.TxtRutCliente.TabIndex = 3;
            this.TxtRutCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRutCliente_KeyPress);
            this.TxtRutCliente.Leave += new System.EventHandler(this.TxtRutCliente_Leave);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(13, 98);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombres";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(12, 117);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(305, 20);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(63, 153);
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
            this.BtnCancelar.Location = new System.Drawing.Point(281, 153);
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
            this.LblRutObligatorio.Location = new System.Drawing.Point(215, 68);
            this.LblRutObligatorio.Name = "LblRutObligatorio";
            this.LblRutObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblRutObligatorio.TabIndex = 20;
            this.LblRutObligatorio.Text = "*";
            this.LblRutObligatorio.Visible = false;
            // 
            // lblMensajeNombre
            // 
            this.lblMensajeNombre.AutoSize = true;
            this.lblMensajeNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeNombre.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeNombre.Location = new System.Drawing.Point(323, 119);
            this.lblMensajeNombre.Name = "lblMensajeNombre";
            this.lblMensajeNombre.Size = new System.Drawing.Size(20, 18);
            this.lblMensajeNombre.TabIndex = 21;
            this.lblMensajeNombre.Text = "* ";
            this.lblMensajeNombre.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Location = new System.Drawing.Point(9, 206);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(48, 13);
            this.LblIdCliente.TabIndex = 26;
            this.LblIdCliente.Text = "IdCliente";
            this.LblIdCliente.Visible = false;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(63, 199);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.ReadOnly = true;
            this.TxtIdCliente.Size = new System.Drawing.Size(126, 20);
            this.TxtIdCliente.TabIndex = 27;
            this.TxtIdCliente.Visible = false;
            // 
            // TxtIdPersona
            // 
            this.TxtIdPersona.Location = new System.Drawing.Point(303, 203);
            this.TxtIdPersona.Name = "TxtIdPersona";
            this.TxtIdPersona.ReadOnly = true;
            this.TxtIdPersona.Size = new System.Drawing.Size(130, 20);
            this.TxtIdPersona.TabIndex = 28;
            this.TxtIdPersona.Visible = false;
            // 
            // LblIdPersona
            // 
            this.LblIdPersona.AutoSize = true;
            this.LblIdPersona.Location = new System.Drawing.Point(242, 206);
            this.LblIdPersona.Name = "LblIdPersona";
            this.LblIdPersona.Size = new System.Drawing.Size(55, 13);
            this.LblIdPersona.TabIndex = 29;
            this.LblIdPersona.Text = "IdPersona";
            this.LblIdPersona.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioMantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 229);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblIdPersona);
            this.Controls.Add(this.TxtIdPersona);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensajeNombre);
            this.Controls.Add(this.LblRutObligatorio);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblRutCliente;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.TextBox TxtRutCliente;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblRutObligatorio;
        private System.Windows.Forms.Label lblMensajeNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdCliente;
        public System.Windows.Forms.TextBox TxtIdCliente;
        public System.Windows.Forms.TextBox TxtIdPersona;
        private System.Windows.Forms.Label LblIdPersona;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}