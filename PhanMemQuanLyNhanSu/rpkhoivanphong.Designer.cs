namespace PhanMemQuanLyNhanSu
{
    partial class rpkhoivanphong
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
            this.QLNS_DataDataSet1 = new PhanMemQuanLyNhanSu.QLNS_DataDataSet1();
            this.TblCongKhoiVanPHongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblCongKhoiVanPHongTableAdapter = new PhanMemQuanLyNhanSu.QLNS_DataDataSet1TableAdapters.TblCongKhoiVanPHongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiVanPHongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblCongKhoiVanPHongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyNhanSu.Rpkhoivanphong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1112, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLNS_DataDataSet1
            // 
            this.QLNS_DataDataSet1.DataSetName = "QLNS_DataDataSet1";
            this.QLNS_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblCongKhoiVanPHongBindingSource
            // 
            this.TblCongKhoiVanPHongBindingSource.DataMember = "TblCongKhoiVanPHong";
            this.TblCongKhoiVanPHongBindingSource.DataSource = this.QLNS_DataDataSet1;
            // 
            // TblCongKhoiVanPHongTableAdapter
            // 
            this.TblCongKhoiVanPHongTableAdapter.ClearBeforeFill = true;
            // 
            // rpkhoivanphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpkhoivanphong";
            this.Text = "rpkhoivanphong";
            this.Load += new System.EventHandler(this.rpkhoivanphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiVanPHongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblCongKhoiVanPHongBindingSource;
        private QLNS_DataDataSet1 QLNS_DataDataSet1;
        private QLNS_DataDataSet1TableAdapters.TblCongKhoiVanPHongTableAdapter TblCongKhoiVanPHongTableAdapter;
    }
}