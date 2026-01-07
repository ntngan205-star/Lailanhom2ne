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

namespace nhom2huongdan
{
    public partial class frmTTinPhong : Form
    {
        public frmTTinPhong()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn = new KetNoiDuLieu();
        SqlCommand cmd = null;

        public frmTTinPhong(string strgMa, string strgSo, string strgTang, string strgHang, string strgTT)
        {
            InitializeComponent();
            this.strgMa = strgMa;
            this.strgSo = strgSo;
            this.strgTang = strgTang;
            this.strgHang = strgHang;
            this.strgTT = strgTT;

        }

        public string strgMa { get; set; }

        public string strgSo { get; set; }
        public string strgTang { get; set; }
        public string strgHang { get; set; }
        public string strgTT { get; set; }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void frmTTinPhong_Load(object sender, EventArgs e)
        {
            kn.Myconn();

            //Phải cho txt sửa lên tren form_load vs sửa đc
            txtMaPhong.Text = strgMa;
            txtSoPhong.Text = strgSo;
            txtTang.Text = strgTang;
            txtHangPhong.Text = strgHang;
            txtTrangThai.Text = strgTT;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into Phong (MaPhong, SoPhong, Tang, MaHP, MaTT ) values (@MP,@SP,@Tang,@MHP,@MTT)";
                cmd = new SqlCommand(sqlThem, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MP", SqlDbType.Int).Value = txtMaPhong.Text.Trim();
                cmd.Parameters.Add("@SP", SqlDbType.Int).Value = txtSoPhong.Text.Trim();
                cmd.Parameters.Add("@Tang", SqlDbType.Int).Value = txtTang.Text.Trim();
                cmd.Parameters.Add("@MHP", SqlDbType.Char).Value = txtHangPhong.Text.Trim();
                cmd.Parameters.Add("@MTT", SqlDbType.Int).Value = txtTrangThai.Text.Trim();


                cmd.ExecuteNonQuery();

                MessageBox.Show("thêm thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("thêm thất bại");
                throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update Phong set MaPhong=@MP, SoPhong=@SP, Tang=@Tang,MaHP=@MHP, MaTT=@MTT  where MaPhong=@MP";

                cmd = new SqlCommand(sqlSua, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MP", SqlDbType.Int).Value = txtMaPhong.Text.Trim();
                cmd.Parameters.Add("@SP", SqlDbType.Int).Value = txtSoPhong.Text.Trim();
                cmd.Parameters.Add("@Tang", SqlDbType.Int).Value = txtTang.Text.Trim();
                cmd.Parameters.Add("@MHP", SqlDbType.Char).Value = txtHangPhong.Text.Trim();
                cmd.Parameters.Add("@MTT", SqlDbType.Int).Value = txtTrangThai.Text.Trim();


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
