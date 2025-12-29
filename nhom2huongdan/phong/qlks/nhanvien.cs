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

            //string sqlPhong = "select Phong.MaPhong, Phong.SoPhong,Phong.Tang, HangPhong.MaHP,LoaiPhong.TenLP ,KieuPhong.TenKP, TrangThai.TenTT from Phong \r\ninner join HangPhong on HangPhong.MaHP= Phong.MaHP\r\ninner join KieuPhong on HangPhong.MaKP=KieuPhong.MaKP\r\ninner join LoaiPhong on HangPhong.MaLP=LoaiPhong.MaLP\r\ninner join TrangThai on Phong.MaTT=TrangThai.MaTT";

            string sqlNhanVien = "select * from NhanVien";
            dgvNhanVien.DataSource = kn.TaoBang(sqlNhanVien);


        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            kn.Myconn();
            Load_GR();
        }
    }
}
