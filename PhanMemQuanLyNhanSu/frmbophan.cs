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
    public partial class frmbophan : Form
    {
        database cls = new database();
        public frmbophan()
        {
            InitializeComponent();
        }

        private void frmbophan_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dgv, "select * from TblBoPhan");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmabophan.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txttenbophan.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtghichu.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            string del = "delete from TblBoPhan where MaBoPhan='" + txtmabophan.Text + "'";
            string del1 = "delete from TblPhongBan where MaBoPhan='" + txtmabophan.Text + "'";
            //string del = "delete from TblPhongBan where MaPhong=N'" + textBox2.Text + "'";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(del1);
                cls.thucthiketnoi(del);
                cls.loaddatagridview(dgv, "select * from TblBoPhan");
            }
            //}
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(txtmabophan.Text, "select MaBoPhan from TblBoPhan"))
                {
                    string insert = "insert into TblBoPhan values(N'" + txtmabophan.Text + "',N'" + txttenbophan.Text + "',N'" + txtghichu.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dgv, "select * from TblBoPhan");
                }
                else
                {
                    MessageBox.Show("Bộ phận này đã tòn tại ", "Trùng bộ phân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBoPhan set TenBoPhan=N'" + txttenbophan.Text + "',GhiChu=N'" + txtghichu.Text + "' where MaBoPhan='" + txtmabophan.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dgv, "select * from TblBoPhan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string del = "delete from TblBoPhan where MaBoPhan='" + txtmabophan.Text + "'";
            string del1 = "delete from TblPhongBan where MaBoPhan='" + txtmabophan.Text + "'";

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(del1);
                cls.thucthiketnoi(del);
                cls.loaddatagridview(dgv, "select * from TblBoPhan");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
