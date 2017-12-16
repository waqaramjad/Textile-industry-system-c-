namespace ISE_WIM.Reports
{
    partial class production_report_viewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yarnReciptDataSet1 = new ISE_WIM.YarnReciptDataSet();
            this.production_dataset = new ISE_WIM.Reports.production_dataset();
            this.Production_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Production_ReportTableAdapter = new ISE_WIM.Reports.production_datasetTableAdapters.Production_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yarnReciptDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.production_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Production_ReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Production_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ISE_WIM.Reports.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 358);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // yarnReciptDataSet1
            // 
            this.yarnReciptDataSet1.DataSetName = "YarnReciptDataSet";
            this.yarnReciptDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // production_dataset
            // 
            this.production_dataset.DataSetName = "production_dataset";
            this.production_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Production_ReportBindingSource
            // 
            this.Production_ReportBindingSource.DataMember = "Production_Report";
            this.Production_ReportBindingSource.DataSource = this.production_dataset;
            // 
            // Production_ReportTableAdapter
            // 
            this.Production_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // production_report_viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 523);
            this.Controls.Add(this.reportViewer1);
            this.Name = "production_report_viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "production_report_viewer";
            this.Load += new System.EventHandler(this.production_report_viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yarnReciptDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.production_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Production_ReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private YarnReciptDataSet yarnReciptDataSet1;
        private System.Windows.Forms.BindingSource Production_ReportBindingSource;
        private production_dataset production_dataset;
        private production_datasetTableAdapters.Production_ReportTableAdapter Production_ReportTableAdapter;
    }
}