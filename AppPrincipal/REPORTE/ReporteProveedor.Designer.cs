namespace AppPrincipal.REPORTE
{
    partial class ReporteProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteProveedor));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.conexionFerme = new AppPrincipal.REPORTE.ConexionFerme();
            this.tablaProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaProveedorTableAdapter = new AppPrincipal.REPORTE.ConexionFermeTableAdapters.TablaProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.conexionFerme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tablaProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppPrincipal.REPORTE.ReportProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(734, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // conexionFerme
            // 
            this.conexionFerme.DataSetName = "ConexionFerme";
            this.conexionFerme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaProveedorBindingSource
            // 
            this.tablaProveedorBindingSource.DataMember = "TablaProveedor";
            this.tablaProveedorBindingSource.DataSource = this.conexionFerme;
            // 
            // tablaProveedorTableAdapter
            // 
            this.tablaProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteProveedor";
            this.Text = "ReporteProveedor";
            this.Load += new System.EventHandler(this.ReporteProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conexionFerme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ConexionFerme conexionFerme;
        private System.Windows.Forms.BindingSource tablaProveedorBindingSource;
        private ConexionFermeTableAdapters.TablaProveedorTableAdapter tablaProveedorTableAdapter;
    }
}