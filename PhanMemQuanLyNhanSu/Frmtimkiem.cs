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
    public partial class Frmtimkiem : Form
    {
        database cls = new database();
        public Frmtimkiem()
        {
            InitializeComponent();
        }

        private void timkiem_Load(object sender, EventArgs e)
        {
            //radioma.Checked = true;
            cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan");

        }
        int i = 0;
        private void txtmaso_TextChanged(object sender, EventArgs e)
        {


            if ((txt.Text == "") || (txt.Text == "Nhập vào từ khóa tìm kiếm"))
            {
                cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan");
            }
            else
            {

                if (i == 1)
                {
                    cls.loatextbox(txt, "select * from TblTTNVCoBan where MaNV like N'" + txt.Text + "%'", 2);
                    cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan where MaNV like N'" + txt.Text + "%'");
                }
                if (i == 2)
                {
                    cls.loatextbox(txt, "select * from TblTTNVCoBan where MaNV like N'" + txt.Text + "%'", 3);
                    cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan where HoTen like N'" + txt.Text + "%'");
                }
                if (i == 3)
                {
                    cls.loatextbox(txt, "select * from TblTTNVCoBan where MaNV like N'" + txt.Text + "%'", 8);
                    cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan where CMTND like N'" + txt.Text + "%'");
                }

            }


        }
        private void radioma_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }
        private void radioten_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }
        private void radiocm_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            if ((txt.Text == "") || (txt.Text == "Nhập vào từ khóa tìm kiếm"))
            {
                MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (i == 1)
                {
                    cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan where MaNV=N'" + txt.Text + "'");
                }
                if (i == 2)
                {
                    cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan where HoTen=N'" + txt.Text + "'");
                }
                if (i == 3)
                {
                    cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan where CMTND=N'" + txt.Text + "'");
                }
            }


        }

        private void Frmtimkiem_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan");
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            cls.loaddatagridview(dgvtimkiem, "select * from TblTTNVCoBan");
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
