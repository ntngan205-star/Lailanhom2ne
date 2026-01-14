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

namespace DichVu
{
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }
        KetNoiDuLieu kn = new KetNoiDuLieu();
       
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                kn.Myconn();
                Load_GR();
                dgvDichVu.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Kết nối CSDL");
                throw;
            }
        }

        private void Load_GR()
        {
            string sqlDichVu = "select * from DichVu";
            string sqlLoaiDichVu = "select * from LoaiDichVu";
            dgvDichVu.DataSource = kn.TaoBang(sqlDichVu);
            (dgvDichVu.Columns["MaLoaiDV"] as DataGridViewComboBoxColumn).DataSource = kn.TaoBang(sqlLoaiDichVu);
            (dgvDichVu.Columns["MaLoaiDV"] as DataGridViewComboBoxColumn).DisplayMember = "TenLoaiDV";
            (dgvDichVu.Columns["MaLoaiDV"] as DataGridViewComboBoxColumn).ValueMember = "MaLoaiDV";

        //    cmbTenTP.DataSource = kn.TaoBang(sqlThanhPho);
        //    cmbTenTP.DisplayMember = "TenTP";
        //    cmbTenTP.ValueMember = "MaTP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form fr = new frmttDichVu();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Load_GR();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvDichVu.CurrentCell.RowIndex;
            using (frmttDichVu frm = new frmttDichVu(dgvDichVu.Rows[r].Cells[0].Value.ToString(),
                dgvDichVu.Rows[r].Cells[1].Value.ToString(),
                dgvDichVu.Rows[r].Cells[2].Value.ToString(),
                dgvDichVu.Rows[r].Cells[3].Value.ToString(),
                dgvDichVu.Rows[r].Cells[4].Value.ToString()))

                frm.ShowDialog();
            Load_GR();
        }

        public void timkiem(DataGridView dgvDichVu, string tukhoa)
        {
            string chuoi = "select * from DichVu where TenDV like N'%" + tukhoa + "%'";
            dgvDichVu.DataSource = kn.TaoBang(chuoi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Phòng cần xóa!");
                return;
            }

            int madichvu = Convert.ToInt32(
                dgvDichVu.SelectedRows[0].Cells["MaDV"].Value
            );

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            string sql = "delete from DichVu where MaDV = @MaDV";

            SqlCommand cmd = new SqlCommand(sql, kn.conn);
            cmd.Parameters.AddWithValue("@MaDV", madichvu);
            cmd.ExecuteNonQuery();

            Load_GR();
            MessageBox.Show("Xóa thành công!");
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimkiem.Text;
            timkiem(dgvDichVu, tukhoa);
        }
    }
    
}
