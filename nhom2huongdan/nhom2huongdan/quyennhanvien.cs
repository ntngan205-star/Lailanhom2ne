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
    public partial class frmUserNhanVien : Form
    {
        public frmUserNhanVien()
        {
            InitializeComponent();
        }

        private void frmUserNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            usercontrolkhachhang ucKhachHang = new usercontrolkhachhang();
            ucKhachHang.Dock = DockStyle.Fill;
            ucKhachHang.AnCacNutChucNang();
            panelMain.Controls.Add(ucKhachHang);
        }
    }
}
