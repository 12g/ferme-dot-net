namespace AppPrincipal
{
    partial class FormularioBuscarVenta
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
            this.DgMostrarVentasRealizadas = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblBuscarVenta = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgMostrarVentasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgMostrarVentasRealizadas
            // 
            this.DgMostrarVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMostrarVentasRealizadas.Location = new System.Drawing.Point(16, 99);
            this.DgMostrarVentasRealizadas.Name = "DgMostrarVentasRealizadas";
            this.DgMostrarVentasRealizadas.Size = new System.Drawing.Size(806, 309);
            this.DgMostrarVentasRealizadas.TabIndex = 0;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(281, 443);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(298, 43);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(349, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(135, 42);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "VENTAS";
            // 
            // LblBuscarVenta
            // 
            this.LblBuscarVenta.AutoSize = true;
            this.LblBuscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarVenta.Location = new System.Drawing.Point(13, 45);
            this.LblBuscarVenta.Name = "LblBuscarVenta";
            this.LblBuscarVenta.Size = new System.Drawing.Size(46, 13);
            this.LblBuscarVenta.TabIndex = 5;
            this.LblBuscarVenta.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(16, 62);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(290, 20);
            this.TxtBuscar.TabIndex = 6;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // FormularioBuscarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscarVenta);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DgMostrarVentasRealizadas);
            this.Name = "FormularioBuscarVenta";
            this.Text = "FormularioBuscarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.DgMostrarVentasRealizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgMostrarVentasRealizadas;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblBuscarVenta;
        private System.Windows.Forms.TextBox TxtBuscar;
    }
}