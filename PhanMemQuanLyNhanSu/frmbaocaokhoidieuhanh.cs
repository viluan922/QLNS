using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanSu
{
    public partial class frmbaocaokhoidieuhanh : Form
    {
        public frmbaocaokhoidieuhanh()
        {
            InitializeComponent();
        }

        private void frmbaocaokhoidieuhanh_Load(object sender, EventArgs e)
        {
            this.TblCongKhoiDieuHanhTableAdapter.Fill(this.QLNS_DataDataSet.TblCongKhoiDieuHanh);
            this.reportViewer1.RefreshReport();
           // this.reportViewer2.RefreshReport();
           // this.reportViewer3.RefreshReport();
        }
    }
}
