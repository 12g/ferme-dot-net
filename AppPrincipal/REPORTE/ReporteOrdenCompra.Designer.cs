﻿namespace AppPrincipal.REPORTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteOrdenCompra));
            this.TablaOrdenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexionFerme = new AppPrincipal.REPORTE.ConexionFerme();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TablaOrdenCompraTableAdapter = new AppPrincipal.REPORTE.ConexionFermeTableAdapters.TablaOrdenCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TablaOrdenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaOrdenCompraBindingSource
            // 
            this.TablaOrdenCompraBindingSource.DataMember = "TablaOrdenCompra";
            this.TablaOrdenCompraBindingSource.DataSource = this.ConexionFerme;
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
            reportDataSource1.Value = this.TablaOrdenCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppPrincipal.REPORTE.ReportOrdenCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TablaOrdenCompraTableAdapter
            // 
            this.TablaOrdenCompraTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteOrdenCompra";
            this.Text = "ReporteOrdenCompra";
            this.Load += new System.EventHandler(this.ReporteOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaOrdenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexionFerme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TablaOrdenCompraBindingSource;
        private ConexionFerme ConexionFerme;
        private ConexionFermeTableAdapters.TablaOrdenCompraTableAdapter TablaOrdenCompraTableAdapter;
    }
}