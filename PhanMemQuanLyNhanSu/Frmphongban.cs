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
    public partial class Frmphongban : Form
    {
        database cls = new database();
        public Frmphongban()
        {
            InitializeComponent();
        }

        private void Frmphongban_Load(object sender, EventArgs e)
        {
            dtngaythanhlap.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dgv, "select * from tblphongban");
            cls.loadcombobox(cbxmabophan, "select * from TblBoPhan", 0);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbxmabophan.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtmaphong.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txttenphong.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dtngaythanhlap.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtghichu.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            cbxmabophan.Text = "";
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
                if (!cls.kttrungkhoa(txtmaphong.Text, "select MaPhong from TblPhongBan"))
                {
                    string insert = "insert into TblPhongBan values('" + cbxmabophan.Text + "',N'" + txtmaphong.Text + "',N'" + txttenphong.Text + "',N'" + dtngaythanhlap.Text + "',N'" + txtghichu.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dgv, "select * from tblphongban");
                }
                else
                {
                    MessageBox.Show("Mã phòng này đã tòn tại bạn có thể thử mã phòng khác", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update tblPhongBan set MaBoPhan=N'" + cbxmabophan.Text + "',TenPhong=N'" + txttenphong.Text + "',NgayTLap=N'" + dtngaythanhlap.Text + "',GhiChu=N'" + txtghichu.Text + "' where MaPhong=N'" + txtmaphong.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dgv, "select * from tblphongban");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from TblPhongBan where MaPhong=N'" + txtmaphong.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dgv, "select * from tblphongban");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
