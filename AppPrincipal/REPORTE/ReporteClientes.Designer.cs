namespace AppPrincipal.REPORTE
{
    partial class ReporteClientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConexionFerme = new AppPrincipal.REPORTE.ConexionFerme();
            this.PERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PERSONATableAdapter = new AppPrincipal.REPORTE.ConexionFermeTableAdapters.PERSONATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PERSONABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PERSONABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppPrincipal.REPORTE.ReportCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(987, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConexionFerme
            // 
            this.ConexionFerme.DataSetName = "ConexionFerme";
            this.ConexionFerme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PERSONABindingSource
            // 
            this.PERSONABindingSource.DataMember = "PERSONA";
            this.PERSONABindingSource.DataSource = this.ConexionFerme;
            // 
            // PERSONATableAdapter
            // 
            this.PERSONATableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClientes";
            this.Text = "ReporteClientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PERSONABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PERSONABindingSource;
        private ConexionFerme ConexionFerme;
        private ConexionFermeTableAdapters.PERSONATableAdapter PERSONATableAdapter;
    }
}