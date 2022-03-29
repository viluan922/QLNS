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
    public partial class frmmain : Form
    {  
        public frmmain()
        {
            InitializeComponent();
           // this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
           
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void truyen()
        {

            //if (k == 4)
            //{
            //    menuItem2.Enabled = true;
            //    menuItem3.Enabled = true;
            //    menuItem14.Enabled = true;
            //    panel_danhmuc.Enabled = true;
            //    panel_chucnang.Enabled = true;
            //    panel_quanly.Enabled = true;
            //    barBubble.Enabled = true;
            //    cmd_dangnhap.Enabled = false;
            //    menuItem4.Enabled = false;
            //}
        }

        int n;
        public int k = 1;

        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                btntk.ForeColor = Color.DarkMagenta;
                btntk.Location = new Point(720, 90); //location 1014, 111

                btndanhmuc.Location = new Point(720, 280);
                btnquanly.Location = new Point(720, 330);
                btnchucnang.Location = new Point(720, 380);
                pntk.Show();
                pntk.Location = new Point(720, 140); 
                pntk.Size = new Size(160, 140);
                n = 1;
               
                n = 1;
            }
            else if (n == 1)
            {

                vitricu();
                n = 0;
            }
        }



        public void vitricu()
        {
            btntk.ForeColor = Color.Black;
            btndanhmuc.ForeColor = Color.Black;
            btnquanly.ForeColor = Color.Black;
            btnchucnang.ForeColor = Color.Black;
            pntk.Hide();
            pndanhmuc.Hide();
            pnquanly.Hide();
            ptncn.Hide();
            btntk.Location = new Point(720, 88);
            btndanhmuc.Location = new Point(720, 155);
            btnquanly.Location = new Point(720, 220);
            btnchucnang.Location = new Point(720, 285);
            //panel_chucnang.Size = new Size(143, 166);
            //panel_danhmuc.Size = new Size(143, 166);
            //panel_quanly.Size = new Size(143, 166);


        }

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap f1 = new FrmDangNhap();
            f1.ShowDialog();
            this.Close();
        }

     

        private void btndangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy dk = new frmDangKy();
            dk.ShowDialog();
            this.Close();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void btndanhmuc_Click(object sender, EventArgs e)
        {
           
            if (n == 0)
            {
                btndanhmuc.ForeColor = Color.DarkMagenta;
                btnquanly.Location = new Point(720, 380);
                btnchucnang.Location = new Point(720,430 );
                pndanhmuc.Show();
                pndanhmuc.Location = new Point(720, 200);
                pndanhmuc.Size = new Size(160, 170);
                n = 1;
            }
            else if (n == 1)
            {

                vitricu();
                n = 0;
            }
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                btnquanly.ForeColor = Color.DarkMagenta;

                btnchucnang.Location = new Point(720, 450);
                pnquanly.Show();
                pnquanly.Location = new Point(720, 270);
                pnquanly.Size = new Size(160, 170);
                n = 1;
            }
            else if (n == 1)
            {

                vitricu();
                n = 0;
            }
        }


        private void btnchucnang_Click(object sender, EventArgs e)
        {
            if(n == 0)
            {
                btnchucnang.ForeColor = Color.DarkMagenta;
                ptncn.Show();
                ptncn.Location = new Point(720, 330);
                ptncn.Size = new Size(160, 175);
                n = 1;
            }
            else if (n == 1 )
            {
                vitricu();
                n = 0;
            }
        }

        private void ptncn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTC_Click(object sender, EventArgs e)
        {

        }

        private void btnNhansu_Click(object sender, EventArgs e)
        {
            frmcoban fc = new frmcoban();
            pnChinh.Show();
            pnChinh.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            pnChinh.Controls.Add(fc);
            fc.Show();
        }

        private void btnttcn_Click(object sender, EventArgs e)
        {
            Frmttcanhan ft = new Frmttcanhan();

            pnChinh.Show();
            pnChinh.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            pnChinh.Controls.Add(ft);
            ft.Show();
        }

        private void pndanhmuc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnchedo_Click(object sender, EventArgs e)
        {
            frmchedo chedo = new frmchedo();
            pnChinh.Show();
            pnChinh.Controls.Clear();
            chedo.TopLevel = false;
            chedo.Dock = DockStyle.Fill;
            pnChinh.Controls.Add(chedo);
            chedo.Show();
        }

        private void btnluong_Click(object sender, EventArgs e)
        {
            Frmtienluong tl = new Frmtienluong();
            pnChinh.Show();
            pnChinh.Controls.Clear();
            tl.TopLevel = false;
            tl.Dock = DockStyle.Fill;
            pnChinh.Controls.Add(tl);
            tl.Show();
        }
    }
}

