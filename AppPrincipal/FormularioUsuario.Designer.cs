namespace AppPrincipal
{
    partial class FormularioUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnCrearUsuario = new System.Windows.Forms.Button();
            this.BtnCargo = new System.Windows.Forms.Button();
            this.BtnCrearEmpleado = new System.Windows.Forms.Button();
            this.DGlistadoUsuario = new System.Windows.Forms.DataGridView();
            this.BtnEditarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistadoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(258, 29);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "LISTADO DE EMPLEADOS";
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(12, 48);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(54, 13);
            this.LblBuscar.TabIndex = 3;
            this.LblBuscar.Text = "Buscar..";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.Location = new System.Drawing.Point(72, 45);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(774, 20);
            this.TxtBuscar.TabIndex = 4;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(890, 473);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(116, 39);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(890, 183);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(116, 39);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(890, 138);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(116, 39);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearUsuario.Location = new System.Drawing.Point(890, 312);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(116, 39);
            this.BtnCrearUsuario.TabIndex = 10;
            this.BtnCrearUsuario.Text = "Crear Usuario";
            this.BtnCrearUsuario.UseVisualStyleBackColor = true;
            this.BtnCrearUsuario.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnCargo
            // 
            this.BtnCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargo.Location = new System.Drawing.Point(890, 267);
            this.BtnCargo.Name = "BtnCargo";
            this.BtnCargo.Size = new System.Drawing.Size(116, 39);
            this.BtnCargo.TabIndex = 13;
            this.BtnCargo.Text = "Cargo";
            this.BtnCargo.UseVisualStyleBackColor = true;
            this.BtnCargo.Click += new System.EventHandler(this.BtnCargo_Click);
            // 
            // BtnCrearEmpleado
            // 
            this.BtnCrearEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearEmpleado.Location = new System.Drawing.Point(890, 93);
            this.BtnCrearEmpleado.Name = "BtnCrearEmpleado";
            this.BtnCrearEmpleado.Size = new System.Drawing.Size(116, 39);
            this.BtnCrearEmpleado.TabIndex = 14;
            this.BtnCrearEmpleado.Text = "Empleados";
            this.BtnCrearEmpleado.UseVisualStyleBackColor = true;
            this.BtnCrearEmpleado.Click += new System.EventHandler(this.BtnCrearEmpleado_Click);
            // 
            // DGlistadoUsuario
            // 
            this.DGlistadoUsuario.AllowUserToAddRows = false;
            this.DGlistadoUsuario.AllowUserToDeleteRows = false;
            this.DGlistadoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlistadoUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistadoUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.DGlistadoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGlistadoUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGlistadoUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGlistadoUsuario.ColumnHeadersHeight = 40;
            this.DGlistadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGlistadoUsuario.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGlistadoUsuario.EnableHeadersVisualStyles = false;
            this.DGlistadoUsuario.GridColor = System.Drawing.Color.SteelBlue;
            this.DGlistadoUsuario.Location = new System.Drawing.Point(12, 80);
            this.DGlistadoUsuario.Name = "DGlistadoUsuario";
            this.DGlistadoUsuario.ReadOnly = true;
            this.DGlistadoUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistadoUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGlistadoUsuario.RowHeadersVisible = false;
            this.DGlistadoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGlistadoUsuario.Size = new System.Drawing.Size(834, 418);
            this.DGlistadoUsuario.TabIndex = 15;
            // 
            // BtnEditarUsuario
            // 
            this.BtnEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarUsuario.Location = new System.Drawing.Point(890, 357);
            this.BtnEditarUsuario.Name = "BtnEditarUsuario";
            this.BtnEditarUsuario.Size = new System.Drawing.Size(116, 39);
            this.BtnEditarUsuario.TabIndex = 16;
            this.BtnEditarUsuario.Text = "Editar Usuario";
            this.BtnEditarUsuario.UseVisualStyleBackColor = true;
            this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1018, 524);
            this.Controls.Add(this.BtnEditarUsuario);
            this.Controls.Add(this.DGlistadoUsuario);
            this.Controls.Add(this.BtnCrearEmpleado);
            this.Controls.Add(this.BtnCargo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCrearUsuario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FormularioUsuario";
            this.Text = "FormularioUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DGlistadoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnCrearUsuario;
        private System.Windows.Forms.Button BtnCargo;
        private System.Windows.Forms.Button BtnCrearEmpleado;
        public System.Windows.Forms.DataGridView DGlistadoUsuario;
        private System.Windows.Forms.Button BtnEditarUsuario;
    }
}