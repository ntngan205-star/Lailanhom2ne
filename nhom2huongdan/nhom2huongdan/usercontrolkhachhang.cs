using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom2huongdan
{
    public partial class usercontrolkhachhang : UserControl
    {
        public usercontrolkhachhang()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn = new KetNoiDuLieu();
        public void AnCacNutChucNang()
        {
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }

        public void Load_GR()
        {
            string sqlKhachHang = "select * from KhachHang";
            dgvKhachHang.DataSource = kn.TaoBang(sqlKhachHang);
        }

        public void timkiem(DataGridView dgvKhachHang, string tukhoa)
        {
            string chuoi = "select * from KhachHang where TenKH like N'%" + tukhoa + "%'";
            dgvKhachHang.DataSource = kn.TaoBang(chuoi);
        }

        private void usercontrolkhachhang_Load(object sender, EventArgs e)
        {
            try
            {
                kn.Myconn();
                Load_GR();
                dgvKhachHang.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối dữ liệu thất bại, ktra lại kết nối");
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form fr = new frmTTinKhachHang();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Load_GR();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            using (frmTTinKhachHang frm = new frmTTinKhachHang(dgvKhachHang.Rows[r].Cells[0].Value.ToString(), dgvKhachHang.Rows[r].Cells[1].Value.ToString(),
                dgvKhachHang.Rows[r].Cells[2].Value.ToString(), dgvKhachHang.Rows[r].Cells[3].Value.ToString(), dgvKhachHang.Rows[r].Cells[4].Value.ToString(),
                dgvKhachHang.Rows[r].Cells[5].Value.ToString()))

                frm.ShowDialog();
            Load_GR();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            timkiem(dgvKhachHang, tukhoa);
        }
    }
}
