using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhom2huongdan
{
    public class KetNoiDuLieu
    {
        string strconn = "Data Source=NGUYENTHILINH10;Initial Catalog=KHACHSAN;Integrated Security=True;";
        public SqlDataAdapter da = null;
        public SqlCommand cmd = null;
        public SqlConnection conn = null;
        public DataTable dt = null;

        public void Myconn()
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }

        public void MyClose()
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
        }
        //Hàm có dữ liệu trả về phải có return

        public DataTable TaoBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //thêm để đề xuất phòng

    }
}
