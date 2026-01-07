using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom2huongdan
{
    public partial class datphong : Form
    {
        public datphong()
        {
            InitializeComponent();
        }

        KetNoiDuLieu kn = new KetNoiDuLieu();
        public void Load_GR()
        {
            string sqlDatPhong = "select * from DatPhong";
            dgvDatPhong.DataSource = kn.TaoBang(sqlDatPhong);



        }
        private void datphong_Load(object sender, EventArgs e)
        {
            kn.Myconn();
            Load_GR();
        }
    }
}
