using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom2huongdan
{
    public partial class frmTTinKhachHang : Form
    {
        public frmTTinKhachHang()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn = new KetNoiDuLieu();
        SqlCommand cmd = null;

        private void frmTTinKhachHang_Load(object sender, EventArgs e)
        {
            kn.Myconn();

            //Phải cho txt sửa lên tren form_load vs sửa đc
            txtMaKhachHang.Text = StrgMa;
            txtTenKhachHang.Text = StrgTen;
            txtCCCD.Text = StrgCCCD;
            txtGioiTinh.Text = StrgGT;
            txtDiaChi.Text = StrgDC;
            txtSoDienThoai.Text = StrgSDT;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into KhachHang (MaKH, TenKH, CCCD,GioiTinh,DiaChi,SoDienThoai ) values (@MKH,@TKH,@CCCD,@GT,@DC,@SDT)";
                cmd = new SqlCommand(sqlThem, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MKH", SqlDbType.Int).Value = txtMaKhachHang.Text.Trim();
                cmd.Parameters.Add("@TKH", SqlDbType.NVarChar).Value = txtTenKhachHang.Text.Trim();
                cmd.Parameters.Add("@CCCD", SqlDbType.Int).Value = txtCCCD.Text.Trim();
                cmd.Parameters.Add("@GT", SqlDbType.Int).Value = txtGioiTinh.Text.Trim();
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = txtSoDienThoai.Text.Trim();

                cmd.ExecuteNonQuery();

                MessageBox.Show("thêm thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("thêm thất bại");
                throw;
            }
            
        }

        public frmTTinKhachHang(string strgMa, string strgTen, string strgCCCD, string strgGT, string strgDC, string strgSDT)
        {
            InitializeComponent();
            this.StrgMa = strgMa;
            this.StrgTen = strgTen;
            this.StrgCCCD = strgCCCD;
            this.StrgGT = strgGT;
            this.StrgDC = strgDC;
            this.StrgSDT = strgSDT;
        }

        public string StrgMa { get; set; }

        public string StrgTen { get; set; }
        
        public string StrgCCCD { get; set; }
        public string StrgGT { get; set; }
        public string StrgDC { get; set; }
        public string StrgSDT { get; set; }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update KhachHang set MaKH=@MKH, TenKH=@TKH, CCCD=@CCCD,GioiTinh=@GT, DiaChi=@DC,SoDienThoai=@SDT  where MaKH=@MKH";

                cmd = new SqlCommand(sqlSua, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MKH", SqlDbType.Int).Value = txtMaKhachHang.Text.Trim();
                cmd.Parameters.Add("@TKH", SqlDbType.NVarChar).Value = txtTenKhachHang.Text.Trim();
                cmd.Parameters.Add("@CCCD", SqlDbType.Int).Value = txtCCCD.Text.Trim();
                cmd.Parameters.Add("@GT", SqlDbType.Int).Value = txtGioiTinh.Text.Trim();
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = txtSoDienThoai.Text.Trim();

                cmd.ExecuteNonQuery();

                MessageBox.Show("sửa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("sửa thất bại");
                throw;
            }
            
        }
    }
}
