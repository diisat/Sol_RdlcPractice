namespace Presentacion.Reports
{
    partial class frm_rpt_Categories
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
            this.dS_Reports = new Presentacion.Reports.DS_Reports();
            this.uSPListCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_List_CATableAdapter = new Presentacion.Reports.DS_ReportsTableAdapters.USP_List_CATableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListCABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Report_Categories";
            reportDataSource1.Value = this.uSPListCABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reports.RPT_Categories.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reports
            // 
            this.dS_Reports.DataSetName = "DS_Reports";
            this.dS_Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListCABindingSource
            // 
            this.uSPListCABindingSource.DataMember = "USP_List_CA";
            this.uSPListCABindingSource.DataSource = this.dS_Reports;
            // 
            // uSP_List_CATableAdapter
            // 
            this.uSP_List_CATableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(41, 52);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            // 
            // frm_rpt_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rpt_Categories";
            this.Text = "frm_rpt_Categories";
            this.Load += new System.EventHandler(this.frm_rpt_Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListCABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListCABindingSource;
        private DS_Reports dS_Reports;
        private DS_ReportsTableAdapters.USP_List_CATableAdapter uSP_List_CATableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}