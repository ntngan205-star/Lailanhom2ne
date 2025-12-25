using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlks
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn=new KetNoiDuLieu();

        public void Load_GR()
        {

            //string sqlPhong = "select Phong.MaPhong, Phong.SoPhong,Phong.Tang, HangPhong.MaHP,LoaiPhong.TenLP ,KieuPhong.TenKP, TrangThai.TenTT from Phong \r\ninner join HangPhong on HangPhong.MaHP= Phong.MaHP\r\ninner join KieuPhong on HangPhong.MaKP=KieuPhong.MaKP\r\ninner join LoaiPhong on HangPhong.MaLP=LoaiPhong.MaLP\r\ninner join TrangThai on Phong.MaTT=TrangThai.MaTT";

            string sqlKhachHang = "select * from KhachHang";
            dgvKhachHang.DataSource = kn.TaoBang(sqlKhachHang);

            
        }

        //public static void Load_GRKhachHang(DataTable )
        //{

        //    //string sqlPhong = "select Phong.MaPhong, Phong.SoPhong,Phong.Tang, HangPhong.MaHP,LoaiPhong.TenLP ,KieuPhong.TenKP, TrangThai.TenTT from Phong \r\ninner join HangPhong on HangPhong.MaHP= Phong.MaHP\r\ninner join KieuPhong on HangPhong.MaKP=KieuPhong.MaKP\r\ninner join LoaiPhong on HangPhong.MaLP=LoaiPhong.MaLP\r\ninner join TrangThai on Phong.MaTT=TrangThai.MaTT";

        //    string sqlKhachHang = "select * from KhachHang";
        //    dgvKhachHang.DataSource = kn.TaoBang(sqlKhachHang);


        //}
        //public static void timkiem(DataGridView dgvKhachHang, string tukhoa, KetNoiDuLieu kn)
        //{
        //    string chuoi = "select * from KhachHang where MaKH like N'%" + tukhoa + "%'";
        //    dgvKhachHang.DataSource = kn.TaoBang(chuoi);
        //}

        public void Load_GR_KhachHang(DataGridView dgvKhachHang, KetNoiDuLieu kn)
        {
            string sqlKhachHang = "select * from KhachHang";
            dgvKhachHang.DataSource = kn.TaoBang(sqlKhachHang);
        }


        //void Load_GR_KhachHang(DataGridView dgvKhachHang, KetNoiDuLieu kn)=frmKhachHang.Load_GR_KhachHang(DataGridView dgvKhachHang, KetNoiDuLieu kn)
        // IDU = frmLogin.IDU;

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                kn.Myconn();
                Load_GR();
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối dữ liệu thất bại, ktra lại kết nối");
                throw;
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ShowAddForm();
            Form fr = new frmThemKhachHang();
            fr.ShowDialog();
            fr.Show();
            Load_GR();

            //PopUpForm form = new PopUpForm(this);
            //form.Show();
        }
    }
}
