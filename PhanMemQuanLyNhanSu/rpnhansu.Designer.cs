namespace PhanMemQuanLyNhanSu
{
    partial class rpnhansu
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
            this.QLNS_DataDataSet2 = new PhanMemQuanLyNhanSu.QLNS_DataDataSet2();
            this.TblTTNVCoBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblTTNVCoBanTableAdapter = new PhanMemQuanLyNhanSu.QLNS_DataDataSet2TableAdapters.TblTTNVCoBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblTTNVCoBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblTTNVCoBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyNhanSu.Rpnhansu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1182, 557);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLNS_DataDataSet2
            // 
            this.QLNS_DataDataSet2.DataSetName = "QLNS_DataDataSet2";
            this.QLNS_DataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblTTNVCoBanBindingSource
            // 
            this.TblTTNVCoBanBindingSource.DataMember = "TblTTNVCoBan";
            this.TblTTNVCoBanBindingSource.DataSource = this.QLNS_DataDataSet2;
            // 
            // TblTTNVCoBanTableAdapter
            // 
            this.TblTTNVCoBanTableAdapter.ClearBeforeFill = true;
            // 
            // rpnhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 557);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpnhansu";
            this.Text = "rpnhansu";
            this.Load += new System.EventHandler(this.rpnhansu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblTTNVCoBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblTTNVCoBanBindingSource;
        private QLNS_DataDataSet2 QLNS_DataDataSet2;
        private QLNS_DataDataSet2TableAdapters.TblTTNVCoBanTableAdapter TblTTNVCoBanTableAdapter;
    }
}