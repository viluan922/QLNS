namespace PhanMemQuanLyNhanSu
{
    partial class rpphongban
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
            this.TblPhongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblPhongBanTableAdapter = new PhanMemQuanLyNhanSu.QLNS_DataDataSet2TableAdapters.TblPhongBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPhongBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblPhongBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyNhanSu.Rpphongban.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(928, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLNS_DataDataSet2
            // 
            this.QLNS_DataDataSet2.DataSetName = "QLNS_DataDataSet2";
            this.QLNS_DataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblPhongBanBindingSource
            // 
            this.TblPhongBanBindingSource.DataMember = "TblPhongBan";
            this.TblPhongBanBindingSource.DataSource = this.QLNS_DataDataSet2;
            // 
            // TblPhongBanTableAdapter
            // 
            this.TblPhongBanTableAdapter.ClearBeforeFill = true;
            // 
            // rpphongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpphongban";
            this.Text = "rpphongban";
            this.Load += new System.EventHandler(this.rpphongban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblPhongBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblPhongBanBindingSource;
        private QLNS_DataDataSet2 QLNS_DataDataSet2;
        private QLNS_DataDataSet2TableAdapters.TblPhongBanTableAdapter TblPhongBanTableAdapter;
    }
}