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
    public partial class frmcoban : Form
    {
        database cls = new database();
        public frmcoban()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cbxmabophan.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                cbxmaphong.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtnhanvien.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txthoten.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                txtbidanh.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                dtngaysinh.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
                cbxgt.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
                txttthonnhan.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
                txtcmtnd.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
                dtngaycap.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
                txtnoicap.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
                txtchucvu.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
                txtchucdanh.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
                txtloaihd.Text = dataGridView1.Rows[hang].Cells[13].Value.ToString();
                txtthoigian.Text = dataGridView1.Rows[hang].Cells[14].Value.ToString();
                dtngayky.Text = dataGridView1.Rows[hang].Cells[15].Value.ToString();
                dtngayhethan.Text = dataGridView1.Rows[hang].Cells[16].Value.ToString();
                txtanhmh.Text = dataGridView1.Rows[hang].Cells[17].Value.ToString();
                txtghichu.Text = dataGridView1.Rows[hang].Cells[18].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }

        private void frmcoban_Load(object sender, EventArgs e)
        {
            dtngaysinh.CustomFormat = " MM / dd / yyyy ";
            dtngaycap.CustomFormat = " MM / dd / yyyy ";
            dtngayky.CustomFormat = " MM / dd / yyyy ";
            dtngayhethan.CustomFormat = " MM / dd / yyyy ";
            cls.loadcombobox(cbxmabophan, "select * from TblBoPhan", 0);
            cls.loadcombobox(cbxmaphong, "select * from TblPhongBan", 1);
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
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

                string insert = "insert into TblTTNVCoBan values(N'" + cbxmabophan.Text + "',N'" + cbxmaphong.Text + "',N'" + txtnhanvien.Text + "',N'" + txthoten.Text + "',N'" + txtbidanh.Text + "',N'" + dtngaysinh.Text + "',N'" + cbxgt.Text + "',N'" + txttthonnhan.Text + "',N'" + txtcmtnd.Text + "',N'" + dtngaycap.Text + "',N'" + txtnoicap.Text + "',N'" + txtchucvu.Text + "',N'" + txtchucdanh.Text + "',N'" + txtloaihd.Text + "',N'" + txtthoigian.Text + "',N'" + dtngayky.Text + "',N'" + dtngayhethan.Text + "',N'" + txtanhmh.Text + "',N'" + txtghichu.Text + "')";
                if (!cls.kttrungkhoa(txtnhanvien.Text, "select MaNV from TblTTNVCoBan"))
                {
                    if (txtnhanvien.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string update = "update TblTTNVCoBan set MaBoPhan=N'" + cbxmabophan.Text + "',MaPhong=N'" + cbxmaphong.Text + "',HoTen=N'" + txthoten.Text + "',BiDanh=N'" + txtbidanh.Text + "',NgaySinh='" + dtngaysinh.Text + "',GioiTinh=N'" + cbxgt.Text + "',TTHonNhan=N'" + txttthonnhan.Text + "',CMTND=N'" + txtcmtnd.Text + "',NgayCap='" + dtngaycap.Text + "',NoiCap=N'" + txtnoicap.Text + "',ChucVu=N'" + txtchucvu.Text + "',ChucDanh=N'" + txtchucdanh.Text + "',LoaiHD=N'" + txtloaihd.Text + "',ThoiGian=N'" + txtthoigian.Text + "',NgayKy='" + dtngayky.Text + "',NgayHetHan='" + dtngayhethan.Text + "',Anh=N'" + txtanhmh.Text + "',GhiChu=N'" + txtghichu.Text + "' where MaNV=N'" + txtnhanvien.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblTTNVCoBan where MaNV=N'" + txtnhanvien.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
