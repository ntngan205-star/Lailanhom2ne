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

namespace qlks
{
    public partial class frmttNhanvien : Form
    {
        public frmttNhanvien()
        {
            InitializeComponent();
        }
        KetNoiDuLieu kn = new KetNoiDuLieu();
        SqlCommand cmd = null;

        
        public string StrgMa { get; set; }

        public string StrgTen { get; set; }

        public string StrgGT { get; set; }
        public string StrgNS { get; set; }
        public string StrgDC { get; set; }
        public string StrgSDT { get; set; }
        public string StrgNNV { get; set; }
        public string StrgTT { get; set; }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into NhanVien (MaNV, TenNV, GioiTinh ,NgaySinh,DiaChi,SoDienThoai ,NgayNhanViec, TrangThai ) values (@MNV,@TNV,@GT,@NS,@DC,@SDT,@NNV,@TT)";
                cmd = new SqlCommand(sqlThem, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MNV", SqlDbType.Int).Value = txtMaNhanVien.Text.Trim();
                cmd.Parameters.Add("@TNV", SqlDbType.NVarChar).Value = txtTenNhanVien.Text.Trim();
                cmd.Parameters.Add("@GT", SqlDbType.Int).Value = txtGoiTinh.Text.Trim();
                cmd.Parameters.Add("@NS", SqlDbType.Date).Value = dtpNgaySinh.Value;
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = txtSoDienThoai.Text.Trim();
                cmd.Parameters.Add("@NNV", SqlDbType.Date).Value = dtpNgayNhanViec.Value;
                cmd.Parameters.Add("@TT", SqlDbType.Bit).Value = txtTrangThai.Text.Trim();
                cmd.ExecuteNonQuery();

                MessageBox.Show("thêm thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("thêm thất bại");
                throw;
            }
        }
        public frmttNhanvien(string strgMa, string strgTen,string strgGT, string strgNS,  string strgDC, string strgSDT, string strNNV, string strTT)
        {
            InitializeComponent();
            this.StrgMa = strgMa;
            this.StrgTen = strgTen;
            this.StrgGT = strgGT;
            this.StrgNS = strgNS;
            this.StrgDC = strgDC;
            this.StrgSDT = strgSDT;
            this.StrgNNV = strNNV;
            this.StrgTT = strTT;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update NhanVien set MaNV=@MNV, TenNV=@TNV, GioiTinh=@GT,NgaySinh=@NS, DiaChi=@DC,SoDienThoai=@SDT ,NgayNhanViec=@NNV,TrangThai=@TT where MaNV=@MNV";

                cmd = new SqlCommand(sqlSua, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MNV", SqlDbType.Int).Value = txtMaNhanVien.Text.Trim();
                cmd.Parameters.Add("@TNV", SqlDbType.NVarChar).Value = txtTenNhanVien.Text.Trim();
                cmd.Parameters.Add("@GT", SqlDbType.Int).Value = txtGoiTinh.Text.Trim();
                cmd.Parameters.Add("@NS", SqlDbType.Date).Value = dtpNgaySinh.Value;
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = txtSoDienThoai.Text.Trim();
                cmd.Parameters.Add("@NNV", SqlDbType.Date).Value = dtpNgayNhanViec.Value;
                cmd.Parameters.Add("@TT", SqlDbType.Bit).Value = txtTrangThai.Text.Trim();
                cmd.ExecuteNonQuery();

                MessageBox.Show("sửa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("sửa thất bại");
                throw;
            }
        }

        private void frmttNhanvien_Load(object sender, EventArgs e)
        {
            kn.Myconn();

            //Phải cho txt sửa lên tren form_load vs sửa đc
            txtMaNhanVien.Text = StrgMa;
            txtTenNhanVien.Text = StrgTen;
            txtGoiTinh.Text = StrgGT;
            dtpNgaySinh.Text = StrgNS;
            txtDiaChi.Text = StrgDC;
            txtSoDienThoai.Text = StrgSDT;
            dtpNgayNhanViec.Text = StrgNNV;
            txtTrangThai.Text = StrgTT;
        }
    }
}
