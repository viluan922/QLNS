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
    public partial class FrmDangNhap : Form

    {

        database cls = new database();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }



        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cls.getdata("select * from tbuser where Username = '" + txtDangnhap.Text + "' and Pass = '" + txtmatkhau.Text + "'");
            //  //  if ((cls.kt(txtDangnhap.Text, "select * from tbuser", 0) == true) && (cls.kt(txtmatkhau.Text, "select * from tbuser", 1) == true))
            //    {



            //        this.Hide();
            //        frmmain2 fm = new frmmain2();
            //        fm.k = 4;
            //        fm.truyen();
            //        MessageBox.Show("Bạn đã đăng nhập thành công");
            //        fm.ShowDialog();

            //    }
            //    else
            //        MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Chức Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmmain2 f = new frmmain2(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                f.k = 4;
                f.truyen();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

