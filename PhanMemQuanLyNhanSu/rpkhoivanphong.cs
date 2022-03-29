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
    public partial class rpkhoivanphong : Form
    {
        public rpkhoivanphong()
        {
            InitializeComponent();
        }

        private void rpkhoivanphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNS_DataDataSet1.TblCongKhoiVanPHong' table. You can move, or remove it, as needed.
            this.TblCongKhoiVanPHongTableAdapter.Fill(this.QLNS_DataDataSet1.TblCongKhoiVanPHong);

            this.reportViewer1.RefreshReport();
        }
    }
}
