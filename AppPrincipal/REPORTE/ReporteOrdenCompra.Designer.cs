namespace AppPrincipal.REPORTE
{
    partial class ReporteOrdenCompra
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
            this.DataOrdenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexionFerme = new AppPrincipal.REPORTE.ConexionFerme();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataOrdenCompraTableAdapter = new AppPrincipal.REPORTE.ConexionFermeTableAdapters.DataOrdenCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataOrdenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).BeginInit();
            this.SuspendLayout();
            // 
            // DataOrdenCompraBindingSource
            // 
            this.DataOrdenCompraBindingSource.DataMember = "DataOrdenCompra";
            this.DataOrdenCompraBindingSource.DataSource = this.ConexionFerme;
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
            reportDataSource1.Value = this.DataOrdenCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppPrincipal.REPORTE.ReportMostrarOrdenCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1233, 527);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataOrdenCompraTableAdapter
            // 
            this.DataOrdenCompraTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 527);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteOrdenCompra";
            this.Text = "ReporteOrdenCompra";
            this.Load += new System.EventHandler(this.ReporteOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOrdenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataOrdenCompraBindingSource;
        private ConexionFerme ConexionFerme;
        private ConexionFermeTableAdapters.DataOrdenCompraTableAdapter DataOrdenCompraTableAdapter;
    }
}