namespace AppPrincipal.REPORTE
{
    partial class ReporteProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteProducto));
            this.DataProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexionFerme = new AppPrincipal.REPORTE.ConexionFerme();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataProductoTableAdapter = new AppPrincipal.REPORTE.ConexionFermeTableAdapters.DataProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).BeginInit();
            this.SuspendLayout();
            // 
            // DataProductoBindingSource
            // 
            this.DataProductoBindingSource.DataMember = "DataProducto";
            this.DataProductoBindingSource.DataSource = this.ConexionFerme;
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
            reportDataSource1.Value = this.DataProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppPrincipal.REPORTE.ReportProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(891, 542);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataProductoTableAdapter
            // 
            this.DataProductoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 542);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteProducto";
            this.Load += new System.EventHandler(this.ReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataProductoBindingSource;
        private ConexionFerme ConexionFerme;
        private ConexionFermeTableAdapters.DataProductoTableAdapter DataProductoTableAdapter;
    }
}