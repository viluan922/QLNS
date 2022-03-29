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
    public partial class Frmdoimatkhau : Form
    {
        database cls = new database();
        public Frmdoimatkhau()
        {
            InitializeComponent();
        }

        
       
        private void btnhoantat_Click(object sender, EventArgs e)
        {
            string update = "update tbuser set Pass='" + txtmkmoi.Text + "' where(Username=N'" + txttentrycap.Text + "' and Pass='" + txtmkcu.Text + "')";
            string ten = txttentrycap.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtmkcu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtmkmoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtgolai.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (txtmkmoi.Text == txtgolai.Text)
                            {
                                cls.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmdoimatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}
