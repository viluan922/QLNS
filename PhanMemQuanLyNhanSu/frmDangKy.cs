using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhanMemQuanLyNhanSu
{
    public partial class frmDangKy : Form
    {
        database cls = new database();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtdangnhap.Text = "";
            txtmk.Text = "";
            txttenthat.Text = "";
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
             dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
        }

        private void btnhoantat_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.CustomFormat = "MM/dd/yyyy";
                string insert = "insert into tbuser values(N'" + txtdangnhap.Text + "','" + txtmk.Text + "',N'" + txttenthat.Text + "','" + dateTimePicker1.Text + "')";
                if (cls.kttrungkhoa(txtdangnhap.Text, "select * from tbuser") == true)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn có thể thử tên khác");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmain2 fm = new frmmain2();
            fm.ShowDialog();
            //this.Hide();
            //fm.Close();

        }
    }
}
