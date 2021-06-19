using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Object;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKho.Models
{
    class PhieuNhapMod
    {
        Connection conn = new Connection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            conn.OpenConn();
            string query = "select * from PhieuNhap";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.CloseConn();
            return dt;
        }
        public bool AddData(PhieuNhapObj KhoObj)
        {
            try
            {
                conn.OpenConn();
                string query = "Insert into PhieuNhap values (@MaPn,@TenNV,@KhachHang,@Ngaylap,@TongTien)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);
                cmd.Parameters.Add("@MaPN", SqlDbType.Int).Value = KhoObj.Mapn;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = KhoObj.Tennv;
                cmd.Parameters.Add("@KhachHang", SqlDbType.Int).Value = KhoObj.Ncc;
                cmd.Parameters.Add("@Ngaylap", SqlDbType.NVarChar).Value = KhoObj.Ngaylap;
                cmd.Parameters.Add("@TongTien", SqlDbType.Int).Value = KhoObj.Tong;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
    }
}
