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
    public partial class Frmtienluong : Form
    {
        database cls = new database();
        DataSet ds1 = new DataSet();
        public Frmtienluong()
        {
            InitializeComponent();
        }

        private void Frmtienluong_Load(object sender, EventArgs e)
        {
            dtpngaytang.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker2.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            DataSet ds1 = new DataSet();
            cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
            cls.loadcombobox(cbxnv, "select * from TblTTNVCoBan", 2);
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt7.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txt8.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            dateTimePicker3.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            txt9.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
        }

        private void btnthemcty_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblBangLuongCTy values(N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + dateTimePicker1.Text + "',N'" + txt6.Text + "',N'" + dateTimePicker2.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + dateTimePicker3.Text + "',N'" + txt9.Text + "')";
                if (!cls.kttrungkhoa(txt1.Text, "select MaLuong from TblBangLuongCTy"))
                {
                    if (txt1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã Lương");
                }
                else
                    MessageBox.Show("Mã Lương này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnsuacty_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangLuongCTy set ChucVu=N'" + txt2.Text + "',ChucDanh=N'" + txt3.Text + "',LCB=N'" + txt4.Text + "',PCChucVu=N'" + txt5.Text + "',NgayNhap='" + dateTimePicker1.Text + "',LCBMoi=N'" + txt6.Text + "',NgaySua=N'" + dateTimePicker2.Text + "',LyDo=N'" + txt7.Text + "',PCCVuMoi='" + txt8.Text + "',NgaySuaPC=N'" + dateTimePicker3.Text + "',GhiChu=N'" + txt9.Text + "' where MaLuong=N'" + txt1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnxoacty_Click(object sender, EventArgs e)
        {

            string delete = "delete from TblBangLuongCTy where MaLuong=N'" + txt1.Text + "'";
            string delete1 = "delete from TblSoBH where MaLuong=N'" + txt1.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete1);
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView1, "select * from TblBangLuongCTy");
            }
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbxnv.Text = dg2.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dg2.Rows[i].Cells[1].Value.ToString();
            txtgt.Text = dg2.Rows[i].Cells[2].Value.ToString();
            txtchucvu.Text = dg2.Rows[i].Cells[3].Value.ToString();
            txtchucdanh.Text = dg2.Rows[i].Cells[4].Value.ToString();
            txtluongcbcu.Text = dg2.Rows[i].Cells[5].Value.ToString();
            txtcobannew.Text = dg2.Rows[i].Cells[6].Value.ToString();
            txttrocapcu.Text = dg2.Rows[i].Cells[7].Value.ToString();
            txtphucap.Text = dg2.Rows[i].Cells[8].Value.ToString();
            dtpngaytang.Text = dg2.Rows[i].Cells[9].Value.ToString();
            txtlido.Text = dg2.Rows[i].Cells[10].Value.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblTangLuong values(N'" + cbxnv.Text + "',N'" + txthoten.Text + "',N'" + txtgt.Text + "',N'" + txtchucvu.Text + "',N'" + txtchucdanh.Text + "',N'" + txtluongcbcu.Text + "',N'" + txtcobannew.Text + "',N'" + txttrocapcu.Text + "',N'" + txtphucap.Text + "',N'" + dtpngaytang.Text + "',N'" + txtlido.Text + "')";
            if (!cls.kttrungkhoa(cbxnv.Text, "select MaNV from TblTangLuong"))
            {
                if (cbxnv.Text != "")
                {
                    cls.thucthiketnoi(insert);
                    dg2.Refresh();
                    cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                string update = "update TblTangLuong set HoTen=N'" + txthoten.Text + "',GioiTinh=N'" + txtgt.Text + "',ChucVu=N'" + txtchucvu.Text + "',ChucDanh=N'" + txtchucdanh.Text + "',LCBCu='" + txtluongcbcu.Text + "',LCBMoi=N'" + txtcobannew.Text + "',PCapCu=N'" + txttrocapcu.Text + "',PCapMoi=N'" + txtphucap.Text + "',NgayTang='" + dtpngaytang.Text + "',LyDo=N'" + txtlido.Text + "' where MaNV=N'" + cbxnv.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            string delete = "delete from TblTangLuong where MaNV=N'" + cbxnv.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dg2, ds1, "select * from TblTangLuong");
            }
        }

        private void txtgt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
