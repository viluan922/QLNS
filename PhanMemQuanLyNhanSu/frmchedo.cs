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
    public partial class frmchedo : Form
    {
        database cls = new database();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        public frmchedo()
        {
            InitializeComponent();
        }

        private void frmchedo_Load(object sender, EventArgs e)
        {
            dtngaycaoso.CustomFormat = " MM / dd / yyyy ";
            dtngaysinh.CustomFormat = " MM / dd / yyyy ";
            dtngayve.CustomFormat = " MM / dd / yyyy ";
            dtde.CustomFormat = " MM / dd / yyyy ";
            dttrolai.CustomFormat = " MM / dd / yyyy ";
            cls.loadcombobox(cbmmanv, "select * from TblSoBH", 0);
            cls.loadcombobox(cbxmanv, "select * from TblThaiSan", 2);
            cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
            cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            

            cbmmanv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtmaluong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtmabaohiem.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtngaycaoso.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtnoicapso.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtghichu.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmabophan.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtmaphong.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cbxmanv.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtten.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            dtngaysinh.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            dtngayve.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            dtde.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            dttrolai.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txttrocap.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txtgchu.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
        }

        private void btnthembh_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into TblSoBH values(N'" + cbmmanv.Text + "',N'" + txtmaluong.Text + "',N'" + txtmabaohiem.Text + "',N'" + dtngaycaoso.Text + "',N'" + txtnoicapso.Text + "',N'" + txtghichu.Text + "'";
                if (!cls.kttrungkhoa(txtmaluong.Text, "select MaSoBH from TblSoBH"))
                {
                    if (txtmaluong.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã số bảo hiểm");
                }
                else
                    MessageBox.Show("Mã số bảo hiểm này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnsuabh_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblSoBH set NgayCapSo=N'" + dtngaycaoso.Text + "',NoiCapSo=N'" + txtnoicapso.Text + "',GhiChu=N'" + txtghichu.Text + "' where MaNV=N'" + cbmmanv.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnxoabh_Click(object sender, EventArgs e)
        {

            string delete = "delete from TblSoBH where MaSoBH=N'" + txtmabaohiem.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dataGridView1, ds1, "select * from TblSoBH");
            }
        }

        private void btnsuats_Click(object sender, EventArgs e)
        {

            try
            {
                string update = "update TblThaiSan set HoTen=N'" + txtten.Text + "',NgaySinh=N'" + dtngaysinh.Text + "',NgayVeSom=N'" + dtngayve.Text + "',NgayNghiSinh=N'" + dtde.Text + "',NgayLamTroLai='" + dttrolai.Text + "',TroCapCTy=N'" + txttrocap.Text + "',GhiChu=N'" + txtgchu.Text + "' where MaNV=N'" + cbxmanv.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnxoats_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblThaiSan where MaNV=N'" + cbxmanv.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblThaiSan");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnmoi_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbmmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtngaycaoso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmabaohiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnoicapso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmaluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnxuat_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbxmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dttrolai_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtngayve_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txttrocap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgchu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmaphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmabophan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
