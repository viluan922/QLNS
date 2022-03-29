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
    public partial class Frmhosotv : Form
    {
        database cls = new database();
        public Frmhosotv()
        {
            InitializeComponent();
        }

        private void Frmhosotv_Load(object sender, EventArgs e)
        {
            dtngaysinh.CustomFormat = " MM / dd / yyyy ";
            dtngaytv.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
            cls.loadcombobox(cbxmaphong, "select * from Tblphongban", 1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbxmaphong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtmanhanvien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txthoten.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtngaysinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtgt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txttrinhdo.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            ttxthocham.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtvitritv.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            dtngaytv.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txtthangtv.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            txtghichu.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
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
                if (!cls.kttrungkhoa(txtmanhanvien.Text, "select MaNV from TblHoSoThuViec"))
                {
                    string insert = "insert into TblHoSoThuViec values('" + cbxmaphong.Text + "',N'" + txtmanhanvien.Text + "',N'" + txthoten.Text + "',N'" + dtngaysinh.Text + "',N'" + txtgt.Text + "',N'" + txtdiachi.Text + "',N'" + txttrinhdo.Text + "',N'" + ttxthocham.Text + "',N'" + txtvitritv.Text + "',N'" + dtngaytv.Text + "',N'" + txtthangtv.Text + "',N'" + txtghichu.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
                }
                else
                {
                    MessageBox.Show("Mã nhân viên này đã tòn tại bạn có thể thử mã nhân viên khác", "Trùng mã nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                string del = "delete from TblHoSoThuViec where MaNV=N'" + txtmanhanvien.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(del);
                    cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
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
                string update = "update TblHoSoThuViec set MaPhong=N'" + cbxmaphong.Text + "',HoTen=N'" + txthoten.Text + "',NgaySinh=N'" + dtngaysinh.Text + "',GioiTinh=N'" + txtgt.Text + "',DiaChi=N'" + txtdiachi.Text + "',TDHocVan=N'" + txttrinhdo.Text + "',HocHam=N'" + ttxthocham.Text + "',ViTriThuViec=N'" + txtvitritv.Text + "',NgayTV=N'" + dtngaytv.Text + "',ThangTV=N'" + txtthangtv.Text + "',GhiChu=N'" + txtghichu.Text + "' where MaNV='" + txtmanhanvien.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblHoSoThuViec");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
