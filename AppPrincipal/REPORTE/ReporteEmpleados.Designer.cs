namespace AppPrincipal.REPORTE
{
    partial class ReporteEmpleados
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEmpleados));
            this.TablaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexionFerme = new AppPrincipal.REPORTE.ConexionFerme();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TablaEmpleadosTableAdapter = new AppPrincipal.REPORTE.ConexionFermeTableAdapters.TablaEmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaEmpleadosBindingSource
            // 
            this.TablaEmpleadosBindingSource.DataMember = "TablaEmpleados";
            this.TablaEmpleadosBindingSource.DataSource = this.ConexionFerme;
            // 
            // ConexionFerme
            // 
            this.ConexionFerme.DataSetName = "ConexionFerme";
            this.ConexionFerme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TablaEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppPrincipal.REPORTE.ReportEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(731, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TablaEmpleadosTableAdapter
            // 
            this.TablaEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteEmpleados";
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TablaEmpleadosBindingSource;
        private ConexionFerme ConexionFerme;
        private ConexionFermeTableAdapters.TablaEmpleadosTableAdapter TablaEmpleadosTableAdapter;
    }
}