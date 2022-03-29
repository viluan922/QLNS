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
    public partial class rpphongban : Form
    {
        public rpphongban()
        {
            InitializeComponent();
        }

        private void rpphongban_Load(object sender, EventArgs e)
        {
            this.TblPhongBanTableAdapter.Fill(this.QLNS_DataDataSet2.TblPhongBan);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
