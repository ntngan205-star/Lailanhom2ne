using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlks
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn=new KetNoiDuLieu();
        SqlCommand cmd = null;

        public void Load_GR()
        {
            string sqlNhanVien = "select * from NhanVien";
            dgvNhanVien.DataSource = kn.TaoBang(sqlNhanVien);
        }

        public void timkiem(DataGridView dgvNhanVien, string tukhoa)
        {
            string chuoi = "select * from NhanVien where TenNV like N'%" + tukhoa + "%'";
            dgvNhanVien.DataSource = kn.TaoBang(chuoi);
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                kn.Myconn();
                Load_GR();
                dgvNhanVien.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối dữ liệu thất bại, ktra lại kết nối");
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form fr = new frmttNhanvien();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Load_GR();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            using (frmttNhanvien frm = new frmttNhanvien(dgvNhanVien.Rows[r].Cells[0].Value.ToString(), 
                dgvNhanVien.Rows[r].Cells[1].Value.ToString(),
                dgvNhanVien.Rows[r].Cells[2].Value.ToString(), 
                dgvNhanVien.Rows[r].Cells[3].Value.ToString(), 
                dgvNhanVien.Rows[r].Cells[4].Value.ToString(),
                dgvNhanVien.Rows[r].Cells[5].Value.ToString(), 
                dgvNhanVien.Rows[r].Cells[6].Value.ToString(), 
                dgvNhanVien.Rows[r].Cells[7].Value.ToString()))

                frm.ShowDialog();
            Load_GR();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            timkiem(dgvNhanVien, tukhoa);
        }
    }
}
