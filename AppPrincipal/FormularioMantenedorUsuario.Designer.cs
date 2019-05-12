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
            this.BtnAceptar.Location = new System.Drawing.Point(71, 432);
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
            this.BtnCancelar.Location = new System.Drawing.Point(327, 432);
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
            this.LblRut.Location = new System.Drawing.Point(29, 104);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(27, 13);
            this.LblRut.TabIndex = 4;
            this.LblRut.Text = "Rut";
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(71, 97);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(157, 20);
            this.TxtRut.TabIndex = 5;
            this.TxtRut.Leave += new System.EventHandler(this.TxtRut_Leave);
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(281, 104);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(40, 13);
            this.LblCargo.TabIndex = 6;
            this.LblCargo.Text = "Cargo";
            // 
            // CbCargo
            // 
            this.CbCargo.FormattingEnabled = true;
            this.CbCargo.Location = new System.Drawing.Point(327, 96);
            this.CbCargo.Name = "CbCargo";
            this.CbCargo.Size = new System.Drawing.Size(175, 21);
            this.CbCargo.TabIndex = 7;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(15, 150);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(71, 145);
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
            this.LblRutObligatorio.Location = new System.Drawing.Point(232, 99);
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
            this.LblCargoObligatorio.Location = new System.Drawing.Point(506, 98);
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
            this.LblNombreObligatorio.Location = new System.Drawing.Point(507, 147);
            this.LblNombreObligatorio.Name = "LblNombreObligatorio";
            this.LblNombreObligatorio.Size = new System.Drawing.Size(14, 16);
            this.LblNombreObligatorio.TabIndex = 12;
            this.LblNombreObligatorio.Text = "*";
            this.LblNombreObligatorio.Visible = false;
            // 
            // FormularioMantenedorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 526);
            this.ControlBox = false;
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
    }
}