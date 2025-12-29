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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn=new KetNoiDuLieu();
        SqlCommand cmd = null;

        //void Load_GR_KhachHang(DataGridView dgvKhachHang, KetNoiDuLieu kn)=frmKhachHang.Load_GR_KhachHang(DataGridView dgvKhachHang, KetNoiDuLieu kn)


        private void themkhachhang_Load(object sender, EventArgs e)
        {
            kn.Myconn();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //cmd.Parameters.AddWithValue("@MHD", maHD);
                string sqlThem = "insert into KhachHang (MaKH, TenKH, CCCD,GioiTinh,DiaChi,SoDienThoai ) values (@MKH,@TKH,@CCCD,@GT,@DC,@SDT)";
                cmd = new SqlCommand(sqlThem, kn.conn);
                cmd.Parameters.Clear();//xóa sạch cmd để phòng trường hợp có dữ liệu cũ
                                       //cmd.Parameters.AddWithValue("@MKH", MaKH)= txtMaKhachHang.Text.Trim();
                cmd.Parameters.Add("@MKH", SqlDbType.Int).Value = txtMaKhachHang.Text.Trim();
                cmd.Parameters.Add("@TKH", SqlDbType.NVarChar).Value = txtTenKhachHang.Text.Trim();
                cmd.Parameters.Add("@CCCD", SqlDbType.Int).Value = txtCCCD.Text.Trim();
                cmd.Parameters.Add("@GT", SqlDbType.Int).Value = txtGioiTinh.Text.Trim();
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = txtSoDienThoai.Text.Trim();

                cmd.ExecuteNonQuery();
                //cmd.Parameters.Add("@MTP", SqlDbType.Int).Value = cmbTenThanhPho.SelectedValue;
                //cmd.Parameters.Add("@DT", SqlDbType.Int).Value = txtDienThoai.Text.Trim();
               // Load_GR_KhachHang(DataGridView dgvKhachHang, KetNoiDuLieu kn);
                MessageBox.Show("thêm thành công");
            }
            catch 
            {
                MessageBox.Show("không thành công");
            }


}

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
