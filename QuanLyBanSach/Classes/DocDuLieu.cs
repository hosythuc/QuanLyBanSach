using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanSach.Classes
{
    class DocDuLieu
    {
        private static String sql = "Data Source=HOTHUC;DataBase=BaiTapLonLTTQ;Integrated Security=true";
        private static SqlConnection conn = null;
        private static void MoKetNoi()
        {
            conn = new SqlConnection(sql);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        private static void DongKetNoi()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Dispose();
        }
        //Phương thức đọc dữ liệu rồi trả về 1 datatable
        public static DataTable DocBang(String sql1)
        {
            DataTable dtBang = new DataTable();
            MoKetNoi();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sql1, conn);
            DataAdapter.Fill(dtBang);
            DongKetNoi();
            return dtBang;
        }
        //Phương thức thực hiện các cậu lênh insert, update, delete trong cơ sở dữ liệu
        public static void ThucHienLenh(string sql1)
        {
            MoKetNoi();
            SqlCommand SqlComand = new SqlCommand();
            SqlComand.Connection = conn;
            SqlComand.CommandText = sql1;
            SqlComand.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
