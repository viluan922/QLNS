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
    public partial class Frmchamcong : Form
    {
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        database cls = new database();
        public Frmchamcong()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frmchamcong_Load(object sender, EventArgs e)
        {
            cls.loadcombobox(cb1, "select MaNV from TblHoSoThuViec", 0);
            cls.loadcombobox(cb2, "select MaNV from TblTTNVCoBan", 0);
            cls.loadcombobox(cb5, "select MaNV from TblTTNVCoBan", 0);
            cls.loaddatagridview1(dgvthuviec, ds1, "select * from TblBangCongThuViec");
            cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");
          //  cls.loaddatagridview1(dataGridView3, ds3, "select * from TblCongKhoiSanXuat");
            //cls.loaddatagridview1(dataGridView4, ds4, "select * from TblCongKhoiVanChuyen");
            cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblBangCongThuViec values(N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + cb1.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + txt6.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + txt9.Text + "')";
                if (!cls.kttrungkhoa(cb1.Text, "select MaNV from TblBangCongThuViec"))
                {
                    if (cb1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dgvthuviec.Refresh();
                        cls.loaddatagridview1(dgvthuviec, ds1, "select * from TblBangCongThuViec");

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
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + txt1.Text + "',TenPhong=N'" + txt2.Text + "',LuongTViec=N'" + txt3.Text + "',Thang=N'" + txt4.Text + "',Nam='" + txt5.Text + "',SoNgayCong=N'" + txt6.Text + "',SoNgayNghi=N'" + txt7.Text + "',SoGioLamThem=N'" + txt8.Text + "',GhiChu='" + txt9.Text + "' where MaNV=N'" + cb1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dgvthuviec, ds1, "select * from TblBangCongThuViec");
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
                string delete = "delete from TblBangCongThuViec where MaNV=N'" + cb1.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dgvthuviec, ds1, "select * from TblBangCongThuViec");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvthuviec_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            txt1.Text = dgvthuviec.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dgvthuviec.Rows[i].Cells[1].Value.ToString();
            cb1.Text = dgvthuviec.Rows[i].Cells[2].Value.ToString();
            txt3.Text = dgvthuviec.Rows[i].Cells[3].Value.ToString();
            txt4.Text = dgvthuviec.Rows[i].Cells[4].Value.ToString();
            txt5.Text = dgvthuviec.Rows[i].Cells[5].Value.ToString();
            txt6.Text = dgvthuviec.Rows[i].Cells[6].Value.ToString();
            txt7.Text = dgvthuviec.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dgvthuviec.Rows[i].Cells[8].Value.ToString();
            txt9.Text = dgvthuviec.Rows[i].Cells[9].Value.ToString();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt1, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 0);
            cls.loadtextboxchiso(txt2, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 1);
            cls.loadtextboxchiso(txt3, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 3);
            cls.loadtextboxchiso(txt4, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 4);
            cls.loadtextboxchiso(txt5, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 5);
            cls.loadtextboxchiso(txt6, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 6);
            cls.loadtextboxchiso(txt7, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 7);
            cls.loadtextboxchiso(txt8, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 8);
            cls.loadtextboxchiso(txt9, "select * from TblBangCongThuViec where MaNV='" + cb1.Text + "'", 9);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt12.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txt13.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt14.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txt15.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txt16.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txt17.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt18.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmoi2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblCongKhoiDieuHanh values(N'" + cb2.Text + "',N'" + txt10.Text + "',N'" + txt11.Text + "',N'" + txt12.Text + "',N'" + txt13.Text + "',N'" + txt14.Text + "',N'" + txt15.Text + "',N'" + txt16.Text + "',N'" + txt17.Text + "',N'" + txt18.Text + "')";
                if (!cls.kttrungkhoa(cb2.Text, "select MaNV from TblCongKhoiDieuHanh"))
                {
                    if (cb2.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dgvthuviec.Refresh();

                        cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");

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

        private void btnsua2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiDieuHanh set LCB=N'" + txt10.Text + "',PhuCapCVu=N'" + txt11.Text + "',PhuCapKhac=N'" + txt12.Text + "',Thang=N'" + txt13.Text + "',Nam='" + txt14.Text + "',SoNgayCongThang=N'" + txt15.Text + "',SoNgayNghi=N'" + txt16.Text + "',SoGioLamThem=N'" + txt17.Text + "',GhiChu='" + txt18.Text + "' where MaNV=N'" + cb2.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {

            try
            {
                string delete = "delete from TblCongKhoiDieuHanh where MaNV=N'" + cb2.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView2, ds2, "select * from TblCongKhoiDieuHanh");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmbaocaokhoidieuhanh dh = new frmbaocaokhoidieuhanh();
            dh.ShowDialog();
            
        }

        private void btnthoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt10, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 1);
            cls.loadtextboxchiso(txt11, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 2);
            cls.loadtextboxchiso(txt12, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 3);
            cls.loadtextboxchiso(txt13, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt14, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 5);
            cls.loadtextboxchiso(txt15, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 6);
            cls.loadtextboxchiso(txt16, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 7);
            cls.loadtextboxchiso(txt17, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 8);
            cls.loadtextboxchiso(txt18, "select * from TblCongKhoiDieuHanh where MaNV='" + cb2.Text + "'", 9);
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb5.Text = dataGridView5.Rows[i].Cells[0].Value.ToString();
            txt37.Text = dataGridView5.Rows[i].Cells[1].Value.ToString();
            txt38.Text = dataGridView5.Rows[i].Cells[2].Value.ToString();
            txt39.Text = dataGridView5.Rows[i].Cells[3].Value.ToString();
            txt40.Text = dataGridView5.Rows[i].Cells[4].Value.ToString();
            txt41.Text = dataGridView5.Rows[i].Cells[5].Value.ToString();
            txt42.Text = dataGridView5.Rows[i].Cells[6].Value.ToString();
            txt43.Text = dataGridView5.Rows[i].Cells[7].Value.ToString();
            txt44.Text = dataGridView5.Rows[i].Cells[8].Value.ToString();
            txt45.Text = dataGridView5.Rows[i].Cells[9].Value.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox10.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblCongKhoiVanPHong values(N'" + cb5.Text + "',N'" + txt37.Text + "',N'" + txt38.Text + "',N'" + txt39.Text + "',N'" + txt40.Text + "',N'" + txt41.Text + "',N'" + txt42.Text + "',N'" + txt43.Text + "',N'" + txt44.Text + "',N'" + txt45.Text + "')";
                if (!cls.kttrungkhoa(cb5.Text, "select MaNV from TblCongKhoiVanPHong"))
                {
                    if (cb5.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dgvthuviec.Refresh();
                        cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
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

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiVanPHong set LCB=N'" + txt37.Text + "',PhuCapCVu=N'" + txt38.Text + "',PhuCapKhac=N'" + txt39.Text + "',Thang=N'" + txt40.Text + "',Nam='" + txt41.Text + "',SoNgayCongThang=N'" + txt42.Text + "',SoNgayNghi=N'" + txt43.Text + "',SoGioLamThem=N'" + txt44.Text + "',GhiChu='" + txt45.Text + "' where MaNV=N'" + cb5.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiVanPHong where MaNV=N'" + cb5.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void cb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txt37, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 1);
            cls.loadtextboxchiso(txt38, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 2);
            cls.loadtextboxchiso(txt39, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 3);
            cls.loadtextboxchiso(txt40, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 4);
            cls.loadtextboxchiso(txt41, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 5);
            cls.loadtextboxchiso(txt42, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 6);
            cls.loadtextboxchiso(txt43, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 7);
            cls.loadtextboxchiso(txt44, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 8);
            cls.loadtextboxchiso(txt45, "select * from TblCongKhoiVanPHong where MaNV='" + cb5.Text + "'", 9);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Close();
            rpkhoivanphong vanphong = new rpkhoivanphong();
            vanphong.ShowDialog();
        }
    }
}
