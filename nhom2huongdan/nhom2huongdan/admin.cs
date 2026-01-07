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
    public partial class frmAdmin : Form
    {

        
        public frmAdmin()
        {
            InitializeComponent();
        }

        usercontrolkhachhang ucKhachHang = new usercontrolkhachhang();
        usercontrolphong ucPhong = new usercontrolphong();
        usercontrolnhanvien ucNhanVien= new usercontrolnhanvien();



        private void frmAdmin_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Add(ucKhachHang);
            panelMain.Controls.Add(ucPhong);
            panelMain.Controls.Add(ucNhanVien);

            ucKhachHang.Dock = DockStyle.Fill;
            ucPhong.Dock = DockStyle.Fill;
            ucNhanVien.Dock = DockStyle.Fill;

            ucPhong.BringToFront();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ucKhachHang.BringToFront();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ucPhong.BringToFront();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ucNhanVien.BringToFront();
        }
    }
}
