namespace AppPrincipal
{
    partial class FormularioBuscarRubro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBuscarRubro));
            this.DGlistadoRubro = new System.Windows.Forms.DataGridView();
            this.BtnBuscarRubro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistadoRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // DGlistadoRubro
            // 
            this.DGlistadoRubro.AllowUserToAddRows = false;
            this.DGlistadoRubro.AllowUserToDeleteRows = false;
            this.DGlistadoRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistadoRubro.Location = new System.Drawing.Point(12, 70);
            this.DGlistadoRubro.Name = "DGlistadoRubro";
            this.DGlistadoRubro.ReadOnly = true;
            this.DGlistadoRubro.Size = new System.Drawing.Size(681, 368);
            this.DGlistadoRubro.TabIndex = 0;
            this.DGlistadoRubro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistadoRubro_CellContentClick);
            // 
            // BtnBuscarRubro
            // 
            this.BtnBuscarRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarRubro.Location = new System.Drawing.Point(219, 21);
            this.BtnBuscarRubro.Name = "BtnBuscarRubro";
            this.BtnBuscarRubro.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarRubro.TabIndex = 1;
            this.BtnBuscarRubro.Text = "Buscar";
            this.BtnBuscarRubro.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(322, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioBuscarRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnBuscarRubro);
            this.Controls.Add(this.DGlistadoRubro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioBuscarRubro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioBuscarRubro";
            ((System.ComponentModel.ISupportInitialize)(this.DGlistadoRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGlistadoRubro;
        private System.Windows.Forms.Button BtnBuscarRubro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}