namespace PhanMemQuanLyNhanSu
{
    partial class frmbaocaokhoidieuhanh
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
            this.QLNS_DataDataSet = new PhanMemQuanLyNhanSu.QLNS_DataDataSet();
            this.TblCongKhoiDieuHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblCongKhoiDieuHanhTableAdapter = new PhanMemQuanLyNhanSu.QLNS_DataDataSetTableAdapters.TblCongKhoiDieuHanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblCongKhoiDieuHanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyNhanSu.Rpdieuhanh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1240, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLNS_DataDataSet
            // 
            this.QLNS_DataDataSet.DataSetName = "QLNS_DataDataSet";
            this.QLNS_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblCongKhoiDieuHanhBindingSource
            // 
            this.TblCongKhoiDieuHanhBindingSource.DataMember = "TblCongKhoiDieuHanh";
            this.TblCongKhoiDieuHanhBindingSource.DataSource = this.QLNS_DataDataSet;
            // 
            // TblCongKhoiDieuHanhTableAdapter
            // 
            this.TblCongKhoiDieuHanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmbaocaokhoidieuhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmbaocaokhoidieuhanh";
            this.Text = "frmbaocaokhoidieuhanh";
            this.Load += new System.EventHandler(this.frmbaocaokhoidieuhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNS_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblCongKhoiDieuHanhBindingSource;
        private QLNS_DataDataSet QLNS_DataDataSet;
        private QLNS_DataDataSetTableAdapters.TblCongKhoiDieuHanhTableAdapter TblCongKhoiDieuHanhTableAdapter;
    }
}