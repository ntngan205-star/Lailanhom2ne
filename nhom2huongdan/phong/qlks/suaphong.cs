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
    public partial class frmSuaPhong : Form
    {
        public frmSuaPhong()
        {
            InitializeComponent();
        }

        public frmSuaPhong(string strgMa, string strgSo,string strgTang,string strgHang, string strgTT )
        {
            InitializeComponent();
           this. StrgMa = strgMa;
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
        //public string Strg { get; set; }


        //public string getValueMa
        //{
        //    get
        //    {
        //        return txtMaPhong.Text ;
        //        //return txtSoPhong.Text;
        //        //return txtTang.Text;
        //        //return txtHangPhong.Text;
        //        //return txtTrangThai.Text;
        //        //return txtSoPhong.Text;
        //    }
        //}

        //public string getValueSo
        //{
        //    get
        //    {
        //        return txtMaPhong.Text;
        //        //return txtSoPhong.Text;
        //        //return txtTang.Text;
        //        //return txtHangPhong.Text;
        //        //return txtTrangThai.Text;
        //        //return txtSoPhong.Text;
        //    }
        //}
        //public string getValueTang
        //{
        //    get
        //    {
        //        return txtMaPhong.Text;
        //        //return txtSoPhong.Text;
        //        //return txtTang.Text;
        //        //return txtHangPhong.Text;
        //        //return txtTrangThai.Text;
        //        //return txtSoPhong.Text;
        //    }
        //}
        //public string getValueHang
        //{
        //    get
        //    {
        //        return txtMaPhong.Text;
        //        //return txtSoPhong.Text;
        //        //return txtTang.Text;
        //        //return txtHangPhong.Text;
        //        //return txtTrangThai.Text;
        //        //return txtSoPhong.Text;
        //    }
        //}
        //public string getValueTT
        //{
        //    get
        //    {
        //        return txtMaPhong.Text;
        //        //return txtSoPhong.Text;
        //        //return txtTang.Text;
        //        //return txtHangPhong.Text;
        //        //return txtTrangThai.Text;
        //        //return txtSoPhong.Text;
        //    }
        //}
        //public string getValue
        //{
        //    get
        //    {
        //        return txtMaPhong.Text;
        //        //return txtSoPhong.Text;
        //        //return txtTang.Text;
        //        //return txtHangPhong.Text;
        //        //return txtTrangThai.Text;
        //        //return txtSoPhong.Text;
        //    }
        //}
        private void frmSuaPhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.Text = StrgMa;
            txtSoPhong.Text = StrgSo;
            txtTang.Text = StrgTang;
            txtHangPhong.Text= StrgHang;
            txtTrangThai.Text=StrgTT;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
