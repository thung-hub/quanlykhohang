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
    class NhaCungCapMod
    {
        Connection conn = new Connection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            conn.OpenConn();
            string query = "select * from Nhacungcap";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return dt;
        }
        public bool AddData(NhacungcapObj nvObj)
        {
            string query = "Insert into Nhacungcap values (@Ma,@Ten,@Diachi,@Sdt,@GhiChu)";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            try
            {
                conn.OpenConn();
                cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = nvObj.Mancc;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = nvObj.Tencc;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nvObj.Diachi;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nvObj.Sdt;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = nvObj.Ghichu;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
        public bool DelData(string ma)
        {
            try
            {
                conn.OpenConn();
                string query = "Delete Nhacungcap Where MaNCC = '" + ma + "'";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);
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
        public bool UpdData(NhacungcapObj nvObj)
        {
            try
            {
                conn.OpenConn();
                string query = "Update Nhacungcap set TenNCC =  @Ten, GhiChu = @Ghichu, DiaChi = @Diachi,SDT = @Sdt  Where MaNCC = @Ma";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = nvObj.Mancc;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = nvObj.Tencc;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nvObj.Diachi;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nvObj.Sdt;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = nvObj.Ghichu;
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
