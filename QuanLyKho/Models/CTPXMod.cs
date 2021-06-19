using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.Object;
namespace QuanLyKho.Models
{
    class CTPXMod
    {
        Connection conn = new Connection();
        public DataTable Getdata(string mahd)
        {
            DataTable dta = new DataTable();
            conn.OpenConn();
            string query = "select * from CTPX where MaPN = '" + mahd + "'";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            conn.CloseConn();
            return dta;
        }
        public bool AddData(string ma, DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                conn.OpenConn();
                string query = "Insert into CTPX values (@MaPX,@Mahang,@TenHH,@DonGia,@SoLuong,@Thanhtien)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);
                cmd.Parameters.Add("@MaPX", SqlDbType.Int).Value = Convert.ToInt32(ma);
                cmd.Parameters.Add("@Mahang", SqlDbType.NVarChar).Value = dt.Rows[i][0].ToString();
                cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = Convert.ToInt32(dt.Rows[i][2].ToString());
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(dt.Rows[i][3].ToString());
                cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = dt.Rows[i][1].ToString();
                cmd.Parameters.Add("@Thanhtien", SqlDbType.Int).Value = Convert.ToInt32(dt.Rows[i][4].ToString());
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.CloseConn();
            }
            return true;
        }
    }
}
