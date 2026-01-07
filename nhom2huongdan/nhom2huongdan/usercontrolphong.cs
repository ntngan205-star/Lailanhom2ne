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
    public partial class usercontrolphong : UserControl
    {
       

        public usercontrolphong()
        {
            InitializeComponent();
        }


        KetNoiDuLieu kn = new KetNoiDuLieu();

        public void Load_GR()
        {
            string sqlPhong = "select * from Phong";
            dgvPhong.DataSource = kn.TaoBang(sqlPhong);
        }

        private void usercontrolphong_Load(object sender, EventArgs e)
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
            Form fr = new frmTTinPhong();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Load_GR();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            using (frmTTinPhong frm = new frmTTinPhong(dgvPhong.Rows[r].Cells[0].Value.ToString(),
                dgvPhong.Rows[r].Cells[1].Value.ToString(),
                dgvPhong.Rows[r].Cells[2].Value.ToString(),
                dgvPhong.Rows[r].Cells[3].Value.ToString(),
                dgvPhong.Rows[r].Cells[4].Value.ToString()))

                frm.ShowDialog();
            Load_GR();
        }
    }
}
