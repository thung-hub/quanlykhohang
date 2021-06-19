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
    class PhieuXuatMod
    {
        Connection conn = new Connection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            conn.OpenConn();
            string query = "select * from PhieuXuat";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.CloseConn();
            return dt;
        }
        public bool AddData(PhieuXuatObj KhoObj)
        {
            try
            {
                conn.OpenConn();
                string query = "Insert into PhieuXuat values (@MaPN,@TenNV,@KhachHang,'" + KhoObj.Ngaylap + "',@TongTien)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);
                cmd.Parameters.Add("@MaPN", SqlDbType.Int).Value = KhoObj.Mapx;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = KhoObj.Tennv;
                cmd.Parameters.Add("@KhachHang", SqlDbType.Int).Value = KhoObj.Tenkh;
                cmd.Parameters.Add("@TongTien", SqlDbType.Int).Value = KhoObj.Tong;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
