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
    public partial class frmmain2 : Form
    {

        string Username = "", Pass = "", Ten = "" , Ngaysinh ="";
        public frmmain2()
        {
            InitializeComponent();
           
        }
        public frmmain2(string Username , string Pass ,string Ten, string NgaySinh)
        {
            InitializeComponent();
            this.Username = Username;
            this.Pass = Pass;
            this.Ten = Ten;
            this.Ngaysinh = Ngaysinh;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap f1 = new FrmDangNhap();
            f1.ShowDialog();
            this.Close();

        }

        private void frmmain2_Load(object sender, EventArgs e)
        {

        }

        public int k = 1;
        public void truyen()
        {

            if (k == 4)
            {
                MenuItem2.Enabled = true;
                MenuItem3.Enabled = true;
                MenuItem4.Enabled = true;
                MenuItem5.Enabled = true;
                MenuItem6.Enabled = true;
                MenuItem7.Enabled = true;
                //panel_chucnang.Enabled = true;
                //panel_quanly.Enabled = true;
                //barBubble.Enabled = true;
                //cmd_dangnhap.Enabled = false;
                MenuItem7.Enabled = false;
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                Frmttcanhan ft = new Frmttcanhan();

                pnchinh.Show();
                pnchinh.Controls.Clear();
                ft.TopLevel = false;
                ft.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(ft);
                ft.Show();
                MessageBox.Show("Được thao tác quyền này");
            }
            else
            {
                MessageBox.Show("Không được thao tác quyền này");
            }
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {   if (Username == "duytan" || Username == "admin")
            {
                frmcoban fc = new frmcoban();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                fc.TopLevel = false;
                fc.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(fc);
                fc.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {

                MessageBox.Show("Không được thao tác quyền này");
            }
        }

        private void chếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                frmchedo chedo = new frmchedo();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                chedo.TopLevel = false;
                chedo.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(chedo);
                chedo.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
            
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                Frmtienluong tl = new Frmtienluong();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                tl.TopLevel = false;
                tl.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(tl);
                tl.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");

            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
           
        }

        private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                Frmphongban tl = new Frmphongban();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                tl.TopLevel = false;
                tl.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(tl);
                tl.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                frmbophan frb = new frmbophan();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                frb.TopLevel = false;
                frb.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(frb);
                frb.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
        }

        private void hồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                Frmhosotv frb = new Frmhosotv();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                frb.TopLevel = false;
                frb.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(frb);
                frb.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
        }

        private void timKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmtimkiem frb = new Frmtimkiem();
            pnchinh.Show();
            pnchinh.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            pnchinh.Controls.Add(frb);
            frb.Show();
            MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
        }

        private void chucNangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                this.Hide();
                frmDangKy dk = new frmDangKy();
                dk.ShowDialog();
                this.Close();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
        }

        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
            this.Close();
           
        }

        private void MenuItem6_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                Frmdoimatkhau fdkmk = new Frmdoimatkhau();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                fdkmk.TopLevel = false;
                fdkmk.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(fdkmk);
                fdkmk.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnchinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bảnCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                Frmchamcong fdkmk = new Frmchamcong();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                fdkmk.TopLevel = false;
                fdkmk.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(fdkmk);
                fdkmk.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
        }

        private void báoCáoPhongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                rpphongban fdkmk = new rpphongban();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                fdkmk.TopLevel = false;
                fdkmk.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(fdkmk);
                fdkmk.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
        }

        private void báoCáoNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Username == "duytan" || Username == "admin")
            {
                rpnhansu fdkmk = new rpnhansu();
                pnchinh.Show();
                pnchinh.Controls.Clear();
                fdkmk.TopLevel = false;
                fdkmk.Dock = DockStyle.Fill;
                pnchinh.Controls.Add(fdkmk);
                fdkmk.Show();
                MessageBox.Show("Bạn Được Thao Tác Quyền Này!!");
            }
            else
            {
                MessageBox.Show("Bạn Không Được Thao Tác Quyền Này");
            }
        }
    }
}
