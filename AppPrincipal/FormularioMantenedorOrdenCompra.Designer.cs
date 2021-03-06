﻿namespace AppPrincipal
{
    partial class FormularioMantenedorOrdenCompra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DPfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DPfechaTermino = new System.Windows.Forms.DateTimePicker();
            this.LblFechaTermino = new System.Windows.Forms.Label();
            this.CbEmpleado = new System.Windows.Forms.ComboBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantSolicitada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(82, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ORDEN DE COMPRA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(123, 556);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(114, 42);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(320, 556);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 42);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(13, 75);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(155, 20);
            this.TxtNumero.TabIndex = 6;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(12, 112);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(77, 13);
            this.LblFecha.TabIndex = 7;
            this.LblFecha.Text = "Fecha Inicio";
            // 
            // DPfechaInicio
            // 
            this.DPfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPfechaInicio.Location = new System.Drawing.Point(13, 128);
            this.DPfechaInicio.Name = "DPfechaInicio";
            this.DPfechaInicio.Size = new System.Drawing.Size(155, 20);
            this.DPfechaInicio.TabIndex = 8;
            // 
            // DPfechaTermino
            // 
            this.DPfechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPfechaTermino.Location = new System.Drawing.Point(13, 183);
            this.DPfechaTermino.Name = "DPfechaTermino";
            this.DPfechaTermino.Size = new System.Drawing.Size(155, 20);
            this.DPfechaTermino.TabIndex = 9;
            // 
            // LblFechaTermino
            // 
            this.LblFechaTermino.AutoSize = true;
            this.LblFechaTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaTermino.Location = new System.Drawing.Point(13, 168);
            this.LblFechaTermino.Name = "LblFechaTermino";
            this.LblFechaTermino.Size = new System.Drawing.Size(91, 13);
            this.LblFechaTermino.TabIndex = 10;
            this.LblFechaTermino.Text = "Fecha Termino";
            // 
            // CbEmpleado
            // 
            this.CbEmpleado.FormattingEnabled = true;
            this.CbEmpleado.Location = new System.Drawing.Point(334, 127);
            this.CbEmpleado.Name = "CbEmpleado";
            this.CbEmpleado.Size = new System.Drawing.Size(163, 21);
            this.CbEmpleado.TabIndex = 11;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.Location = new System.Drawing.Point(331, 111);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(62, 13);
            this.LblEmpleado.TabIndex = 12;
            this.LblEmpleado.Text = "Empleado";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(331, 58);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(46, 13);
            this.LblEstado.TabIndex = 13;
            this.LblEstado.Text = "Estado";
            // 
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(334, 74);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(160, 21);
            this.CbEstado.TabIndex = 14;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(13, 222);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(58, 13);
            this.LblProducto.TabIndex = 15;
            this.LblProducto.Text = "Producto";
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Location = new System.Drawing.Point(16, 239);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.ReadOnly = true;
            this.TxtCodProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtCodProducto.TabIndex = 16;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(123, 239);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(208, 20);
            this.TxtNombreProducto.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(447, 239);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(109, 20);
            this.TxtCantidad.TabIndex = 19;
            // 
            // LblCantSolicitada
            // 
            this.LblCantSolicitada.AutoSize = true;
            this.LblCantSolicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantSolicitada.Location = new System.Drawing.Point(447, 221);
            this.LblCantSolicitada.Name = "LblCantSolicitada";
            this.LblCantSolicitada.Size = new System.Drawing.Size(57, 13);
            this.LblCantSolicitada.TabIndex = 20;
            this.LblCantSolicitada.Text = "Cantidad";
            // 
            // FormularioMantenedorOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 610);
            this.ControlBox = false;
            this.Controls.Add(this.LblCantSolicitada);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.TxtCodProducto);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.CbEmpleado);
            this.Controls.Add(this.LblFechaTermino);
            this.Controls.Add(this.DPfechaTermino);
            this.Controls.Add(this.DPfechaInicio);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMantenedorOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Orden Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DPfechaInicio;
        private System.Windows.Forms.DateTimePicker DPfechaTermino;
        private System.Windows.Forms.Label LblFechaTermino;
        private System.Windows.Forms.ComboBox CbEmpleado;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantSolicitada;
    }
}