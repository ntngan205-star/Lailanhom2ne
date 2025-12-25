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
    public partial class frmThongTinPhong : Form
    {
        public frmThongTinPhong()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn = new KetNoiDuLieu();
        SqlCommand cmd = null;

        string Them_or_Sua = frmPhong.Them_or_Sua;

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ;
                string sqlThem = "insert into Phong (MaPhong, SoPhong, Tang, MaHP, MaTT ) values (@MP,@SP,@Tang,@MHP,@MTT)";
                cmd = new SqlCommand(sqlThem, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MP", SqlDbType.Int).Value = txtMaPhong.Text.Trim();
                cmd.Parameters.Add("@SP", SqlDbType.NVarChar).Value = txtSoPhong.Text.Trim();
                cmd.Parameters.Add("@Tang", SqlDbType.Int).Value = txtTang.Text.Trim();
                cmd.Parameters.Add("@MHP", SqlDbType.Int).Value = txtHangPhong.Text.Trim();
                cmd.Parameters.Add("@MTT", SqlDbType.NVarChar).Value = txtTrangThai.Text.Trim();
                //cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = txtSoDienThoai.Text.Trim();

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("không thành công");
            }

            
        }


        public frmThongTinPhong(string strgMa, string strgSo, string strgTang, string strgHang, string strgTT)
        {
            InitializeComponent();
            this.StrgMa = strgMa;
            this.StrgSo = strgSo;
            this.StrgTang = strgTang;
            this.StrgHang = strgHang;
            this.StrgTT = strgTT;
        }

        public string StrgMa { get; set; }

        public string StrgSo { get; set; }
        public string StrgTang { get; set; }
        public string StrgHang { get; set; }
        public string StrgTT { get; set; }






        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = StrgMa;
            txtSoPhong.Text = StrgSo;
            txtTang.Text = StrgTang;
            txtHangPhong.Text = StrgHang;
            txtTrangThai.Text = StrgTT;
        }

        private void frmThongTinPhong_Load(object sender, EventArgs e)
        {
            kn.Myconn();
            if (Them_or_Sua == "1")
            {
                btnSua.Enabled = false;
                btnThem.Enabled = true;
            }
            else
            {
                btnSua.Enabled = true;
                btnThem.Enabled = false;
            }

           
        }
    }
}
