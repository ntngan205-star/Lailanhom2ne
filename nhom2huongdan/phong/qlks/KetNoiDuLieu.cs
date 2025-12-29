using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlks
{
    public class KetNoiDuLieu
    {
        string strconn = "Data Source=NTNGAN-205;Initial Catalog=KHACHSAN;Integrated Security=True";
        public SqlConnection conn = null;
        public DataTable dt = null;

        public void Myconn()
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }

        public void MyClose()
        {
            if (conn != null || conn.State == ConnectionState.Open) conn.Close();
        }
        //Hàm có dữ liệu trả về phải có return

        public DataTable TaoBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void ThucThi(string sql, params SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
