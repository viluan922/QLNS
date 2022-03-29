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
    public partial class Frmttcanhan : Form
    {
        database cls = new database();
        public Frmttcanhan()
        {
            InitializeComponent();
        }

        private void Frmttcanhan_Load(object sender, EventArgs e)
        {
            dtpnvd.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dgvttcn, "select * from TblTTCaNhan");
            cls.loadcombobox(cmbmanv, "select * from TblTTNVCoBan", 2);
            
        }

        private void dgvtcn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cmbmanv.Text = dgvttcn.Rows[hang].Cells[0].Value.ToString();
                txtnoisinh.Text = dgvttcn.Rows[hang].Cells[1].Value.ToString();
                txtnguyenquan.Text = dgvttcn.Rows[hang].Cells[2].Value.ToString();
                txtthuongtru.Text = dgvttcn.Rows[hang].Cells[3].Value.ToString();
                txttamchu.Text = dgvttcn.Rows[hang].Cells[4].Value.ToString();
                txtsdt.Text = dgvttcn.Rows[hang].Cells[5].Value.ToString();
                txtdantoc.Text = dgvttcn.Rows[hang].Cells[6].Value.ToString();
                txttongiao.Text = dgvttcn.Rows[hang].Cells[7].Value.ToString();
                txtquoctich.Text = dgvttcn.Rows[hang].Cells[8].Value.ToString();
                txtnn.Text = dgvttcn.Rows[hang].Cells[9].Value.ToString();
                txttrinhdonn.Text = dgvttcn.Rows[hang].Cells[10].Value.ToString();
                txthocvan.Text = dgvttcn.Rows[hang].Cells[11].Value.ToString();
                txthocham.Text = dgvttcn.Rows[hang].Cells[12].Value.ToString();
                dtpnvd.Text = dgvttcn.Rows[hang].Cells[13].Value.ToString();
                txttdoanthe.Text = dgvttcn.Rows[hang].Cells[14].Value.ToString();
                txtchucvu.Text = dgvttcn.Rows[hang].Cells[15].Value.ToString();
                txtghichu.Text = dgvttcn.Rows[hang].Cells[16].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(cmbmanv.Text, "select MaNV from TblTTCaNhan"))
                {

                    string insert = "insert into TblTTCaNhan values(N'" + cmbmanv.Text + "',N'" + txtnoisinh.Text + "',N'" + txtnguyenquan.Text + "',N'" + txtthuongtru.Text + "',N'" + txttamchu.Text + "',N'" + txtsdt.Text + "',N'" + txtdantoc.Text + "',N'" + txttongiao.Text + "',N'" + txtquoctich.Text + "',N'" + txtnn.Text + "',N'" + txttrinhdonn.Text + "',N'" + txthocvan.Text + "',N'" + txthocham.Text + "','" + dtpnvd.Text + "',N'" + txttdoanthe.Text + "',N'" + txtchucvu.Text + "',N'" + txtghichu.Text + "')";

                    cls.thucthiketnoi(insert);
                    dgvttcn.Refresh();
                    cls.loaddatagridview(dgvttcn, "select * from TblTTCaNhan");
                }
                else MessageBox.Show("Thông tin về nhân viên này đã tồn tại");

            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không chính sác");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblTTCaNhan where MaNV=N'" + cmbmanv.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview(dgvttcn, "select * from TblTTCaNhan");
                }
            }
            catch
            {
                MessageBox.Show("không xóa được");
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

   

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTCaNhan set MaNV=N'" + cmbmanv.Text + "',Noisinh=N'" + txtnoisinh.Text + "',NguyenQuan=N'" + txtnguyenquan.Text + "',DCThuongChu=N'" + txtthuongtru.Text + "',DCTamChu='" + txttamchu.Text + "',SDT=N'" + txtsdt.Text + "',DanToc=N'" + txtdantoc.Text + "',TonGiao=N'" + txttongiao.Text + "',QuocTich='" + txtquoctich.Text + "',TiengNN=N'" + txtnn.Text + "',TrinhDoNN=N'" + txttrinhdonn.Text + "',HocVan=N'" + txthocvan.Text + "',HocHam=N'" + txthocham.Text + "',NgayVaoDoan=N'" + dtpnvd.Text + "',TenDoanThe='" + txttdoanthe.Text + "',ChucVuDoan='" + txtchucvu.Text + "',GhiChu=N'" + txtghichu.Text + "' where MaNV=N'" + cmbmanv.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dgvttcn, "select * from TblTTCaNhan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

       
    }
}
