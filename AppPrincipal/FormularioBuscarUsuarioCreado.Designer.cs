namespace AppPrincipal
{
    partial class FormularioBuscarUsuarioCreado
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtBuscarPersona = new System.Windows.Forms.TextBox();
            this.DgMostrarPersona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgMostrarPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(209, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(237, 29);
            this.LblTitulo.TabIndex = 16;
            this.LblTitulo.Text = "LISTADO DE USUARIOS";
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(8, 57);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(46, 13);
            this.LblBuscar.TabIndex = 15;
            this.LblBuscar.Text = "Buscar";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(214, 436);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(234, 43);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarPersona
            // 
            this.TxtBuscarPersona.Location = new System.Drawing.Point(12, 73);
            this.TxtBuscarPersona.Name = "TxtBuscarPersona";
            this.TxtBuscarPersona.Size = new System.Drawing.Size(227, 20);
            this.TxtBuscarPersona.TabIndex = 13;
            // 
            // DgMostrarPersona
            // 
            this.DgMostrarPersona.AllowUserToAddRows = false;
            this.DgMostrarPersona.AllowUserToDeleteRows = false;
            this.DgMostrarPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgMostrarPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMostrarPersona.Location = new System.Drawing.Point(11, 113);
            this.DgMostrarPersona.Name = "DgMostrarPersona";
            this.DgMostrarPersona.ReadOnly = true;
            this.DgMostrarPersona.Size = new System.Drawing.Size(649, 299);
            this.DgMostrarPersona.TabIndex = 12;
            // 
            // FormularioBuscarUsuarioCreado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 491);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtBuscarPersona);
            this.Controls.Add(this.DgMostrarPersona);
            this.Name = "FormularioBuscarUsuarioCreado";
            this.Text = "FormularioBuscarUsuarioCreado";
            ((System.ComponentModel.ISupportInitialize)(this.DgMostrarPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtBuscarPersona;
        private System.Windows.Forms.DataGridView DgMostrarPersona;
    }
}