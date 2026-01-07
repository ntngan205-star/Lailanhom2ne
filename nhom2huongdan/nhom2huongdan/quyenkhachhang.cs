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
    public partial class frmUserKhachHang : Form
    {
        public frmUserKhachHang()
        {
            InitializeComponent();
        }

        usercontroldatphong ucDatPhong = new usercontroldatphong();



        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            
            //ucDatPhong.AnCacNutChucNang();
            //panelMain.Controls.Add(ucDatPhong);

            ucDatPhong.BringToFront();
        }

        private void frmUserKhachHang_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Add(ucDatPhong);
            ucDatPhong.Dock = DockStyle.Fill;
        }
    }
}
