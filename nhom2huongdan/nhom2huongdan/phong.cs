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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn = new KetNoiDuLieu();

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
            Form fr = new frmTTinPhong();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Load_GR();
            }
        }
    }
}
