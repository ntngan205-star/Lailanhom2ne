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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn=new KetNoiDuLieu();

        public void Load_GR()
        {
            string sqlPhong = "select * from Phong";
            dgvPhong.DataSource = kn.TaoBang(sqlPhong);
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            try
            {
                kn.Myconn();
                Load_GR();
                dgvPhong.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối dữ liệu thất bại, ktra lại kết nối");
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Form fr = new frmThongTinPhong();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Load_GR();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int r = dgvPhong.CurrentCell.RowIndex;
            using (frmThongTinPhong frm = new frmThongTinPhong(dgvPhong.Rows[r].Cells[0].Value.ToString(), 
                dgvPhong.Rows[r].Cells[1].Value.ToString(),
                dgvPhong.Rows[r].Cells[2].Value.ToString(),
                dgvPhong.Rows[r].Cells[3].Value.ToString(), 
                dgvPhong.Rows[r].Cells[4].Value.ToString()))
               
                frm.ShowDialog();
            Load_GR();
        }

        
        public void timkiem(DataGridView dgvPhong, string tukhoa)
        {
            string chuoi = "select * from Phong where SoPhong like N'%" + tukhoa + "%'";
            dgvPhong.DataSource = kn.TaoBang(chuoi);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            timkiem(dgvPhong, tukhoa);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
       

        
    }
}
