namespace AppPrincipal
{
    partial class FormularioMantenedorCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMantenedorCargo));
            this.label1 = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnGuargar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblCodigoObligatorio = new System.Windows.Forms.Label();
            this.LblDescObligatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGO";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(37, 90);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 13);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(12, 115);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(104, 82);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(240, 20);
            this.TxtCodigo.TabIndex = 3;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(104, 107);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(240, 20);
            this.TxtDescripcion.TabIndex = 4;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // BtnGuargar
            // 
            this.BtnGuargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuargar.Location = new System.Drawing.Point(64, 171);
            this.BtnGuargar.Name = "BtnGuargar";
            this.BtnGuargar.Size = new System.Drawing.Size(108, 40);
            this.BtnGuargar.TabIndex = 5;
            this.BtnGuargar.Text = "Guardar";
            this.BtnGuargar.UseVisualStyleBackColor = true;
            this.BtnGuargar.Click += new System.EventHandler(this.BtnGuargar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(252, 171);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 40);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblCodigoObligatorio
            // 
            this.LblCodigoObligatorio.AutoSize = true;
            this.LblCodigoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblCodigoObligatorio.Location = new System.Drawing.Point(348, 82);
            this.LblCodigoObligatorio.Name = "LblCodigoObligatorio";
            this.LblCodigoObligatorio.Size = new System.Drawing.Size(16, 20);
            this.LblCodigoObligatorio.TabIndex = 7;
            this.LblCodigoObligatorio.Text = "*";
            this.LblCodigoObligatorio.Visible = false;
            this.LblCodigoObligatorio.Leave += new System.EventHandler(this.LblCodigoObligatorio_Leave);
            // 
            // LblDescObligatorio
            // 
            this.LblDescObligatorio.AutoSize = true;
            this.LblDescObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescObligatorio.ForeColor = System.Drawing.Color.Red;
            this.LblDescObligatorio.Location = new System.Drawing.Point(347, 110);
            this.LblDescObligatorio.Name = "LblDescObligatorio";
            this.LblDescObligatorio.Size = new System.Drawing.Size(18, 24);
            this.LblDescObligatorio.TabIndex = 8;
            this.LblDescObligatorio.Text = "*";
            this.LblDescObligatorio.Visible = false;
            this.LblDescObligatorio.Leave += new System.EventHandler(this.LblDescObligatorio_Leave);
            // 
            // FormularioMantenedorCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 266);
            this.ControlBox = false;
            this.Controls.Add(this.LblDescObligatorio);
            this.Controls.Add(this.LblCodigoObligatorio);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuargar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Cargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnGuargar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblCodigoObligatorio;
        private System.Windows.Forms.Label LblDescObligatorio;
    }
}