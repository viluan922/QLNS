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
    public partial class rpnhansu : Form
    {
        public rpnhansu()
        {
            InitializeComponent();
        }

        private void rpnhansu_Load(object sender, EventArgs e)
        {
            this.TblTTNVCoBanTableAdapter.Fill(this.QLNS_DataDataSet2.TblTTNVCoBan);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
