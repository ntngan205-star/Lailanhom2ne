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

namespace DichVu
{
    public partial class frmttDichVu : Form
    {
        public frmttDichVu()
        {
            InitializeComponent();
        }
        KetNoiDuLieu kn = new KetNoiDuLieu();
        SqlCommand cmd = null;
        public frmttDichVu(string strgMaDV, string strgTenDV, string strgMaLoaiDV, string strgDonGia, string strgMoTa)
        {
            InitializeComponent();
            this.strgMaDV = strgMaDV;
            this.strgTenDV = strgTenDV;
            this.strgMaLoaiDV = strgMaLoaiDV;
            this.strgDonGia = strgDonGia;
            this.strgMoTa = strgMoTa;
        }

        public string strgMaDV { get; set; }
        public string strgTenDV { get; set; }
        public string strgMaLoaiDV { get; set; }
        public string strgDonGia { get; set; }
        public string strgMoTa { get; set; }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
            string sqlThem = "insert into DichVu (MaDV, TenDV, MaLoaiDV, ĐonGia, MoTa ) values (@MaDV, @TenDV,@MaLoaiDV,@ĐonGia,@MoTa)";
            cmd = new SqlCommand(sqlThem, kn.conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@MaDV", SqlDbType.Int).Value = txtMaDV.Text.Trim();
            cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = txtTenDV.Text.Trim();
            cmd.Parameters.Add("@MaLoaiDV", SqlDbType.Char).Value = cmbMaLoaiDV.SelectedValue;
            cmd.Parameters.Add("@ĐonGia", SqlDbType.Int).Value = txtDonGia.Text.Trim();
            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = txtMoTa.Text.Trim();


            cmd.ExecuteNonQuery();

                MessageBox.Show("thêm thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("thêm thất bại");
               throw;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update DichVu set TenDV=@TenDV, MaLoaiDV=@MaLoaiDV, ĐonGia=@ĐonGia, MoTa=@MoTa  where MaDV=@MaDV";

                cmd = new SqlCommand(sqlSua, kn.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MaDV", SqlDbType.Int).Value = txtMaDV.Text.Trim();
                cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = txtTenDV.Text.Trim();
                cmd.Parameters.Add("@MaLoaiDV", SqlDbType.Char).Value = cmbMaLoaiDV.SelectedValue;
                cmd.Parameters.Add("@ĐonGia", SqlDbType.Int).Value = txtDonGia.Text.Trim();
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = txtMoTa.Text.Trim();

                if (kn.conn.State == ConnectionState.Closed) kn.conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("sửa thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("sửa thất bại");
                throw;
            }

           // txtMaDV.Enabled = false;
        }

        private void frmttDichVu_Load(object sender, EventArgs e)
        {
            kn.Myconn();

            string sqlLoaiDV = "select * from LoaiDichVu";
            cmbMaLoaiDV.DataSource = kn.TaoBang(sqlLoaiDV);
            cmbMaLoaiDV.DisplayMember = "TenLoaiDV";
            cmbMaLoaiDV.ValueMember = "MaLoaiDV";

            //Phải cho txt sửa lên tren form_load vs sửa đc
            txtMaDV.Text = strgMaDV;
            txtTenDV.Text = strgTenDV;
            //cmbMaLoaiDV.Text = strgMaLoaiDV;
            txtDonGia.Text = strgDonGia;
            txtMoTa.Text = strgMoTa;

            if (!string.IsNullOrEmpty(strgMaDV))
            {
                txtMaDV.Enabled = false; // Primary key should not be changed during Edit
            }
        }
    }   
    
}
