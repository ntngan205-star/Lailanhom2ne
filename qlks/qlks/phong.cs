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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn=new KetNoiDuLieu();


        public void Load_GR()
        {

            string sqlPhong = "select Phong.MaPhong, Phong.SoPhong,Phong.Tang, HangPhong.MaHP,LoaiPhong.TenLP ,KieuPhong.TenKP, TrangThai.TenTT from Phong \r\ninner join HangPhong on HangPhong.MaHP= Phong.MaHP\r\ninner join KieuPhong on HangPhong.MaKP=KieuPhong.MaKP\r\ninner join LoaiPhong on HangPhong.MaLP=LoaiPhong.MaLP\r\ninner join TrangThai on Phong.MaTT=TrangThai.MaTT";
            //string sqlPhong = "select * from Phong";
            //string sqlTinhTrang = "select * from TinhTrang";
            dgvPhong.DataSource = kn.TaoBang(sqlPhong);

            //string sqlHLK = "select HangPhong.MaHP,LoaiPhong.TenLP,KieuPhong.TenKP from HangPhong \r\ninner join KieuPhong on HangPhong.MaKP=KieuPhong.MaKP\r\ninner join LoaiPhong on HangPhong.MaLP=LoaiPhong.MaLP";

            //(dgvPhong.Columns["MaLP"] as DataGridViewComboBoxColumn).DataSource = kn.TaoBang(sqlHLK);
            //(dgvPhong.Columns["MaLP"] as DataGridViewComboBoxColumn).DisplayMember = "LoaiPhong.TenLP";
            //(dgvPhong.Columns["MaLP"] as DataGridViewComboBoxColumn).ValueMember = "MaLP";
            //Load ThanhPho lên Combobox
            //cmbDanhMuc.DataSource = kn.TaoBang(sqlDanhMuc);
            //cmbDanhMuc.DisplayMember = "TenDM";
            //cmbDanhMuc.ValueMember = "MaDM";

            //dgvPhong.DataSource = kn.TaoBang(sqlPhong);
            //Tro_Chuot();
        }

        private void Load_Data()
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            //txtMaKhachHang.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            //txtTenCongTy.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            //txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            //txtDienThoai.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            //cmbTenThanhPho.SelectedValue = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            //cmbTenThanhPho.Text = dgvKhachHang.SelectedItems[0].
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            kn.Myconn();
            Load_GR();
            //Them_or_Sua = "0";
        }

        public static string Them_or_Sua = null;

        private void btnThem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form fr = new frmThongTinPhong();
            fr.ShowDialog();
            //fr.Show();

            Them_or_Sua = "0";

            Load_GR();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            using (frmThongTinPhong frm = new frmThongTinPhong(dgvPhong.Rows[r].Cells[0].Value.ToString(), dgvPhong.Rows[r].Cells[1].Value.ToString(),
                dgvPhong.Rows[r].Cells[2].Value.ToString(), dgvPhong.Rows[r].Cells[3].Value.ToString(), dgvPhong.Rows[r].Cells[6].Value.ToString()))
            //{
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        //dgvPhong.Rows[r].Cells[0].Value.ToString() = frm.getValue;
            //        frm.Strg = dgvPhong.Rows[r].Cells[0].Value.ToString();
            //    }
            //}
            //Form fr = new frmSuaPhong();
            frm.ShowDialog();
            //fr.Show();
            //Load_Data();
            

            Them_or_Sua = "1";
            Load_GR();
        }
    }
}
