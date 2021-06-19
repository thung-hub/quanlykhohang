using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.Object;
using QuanLyKho.Models;
namespace QuanLyKho.Models
{
    class NhanVienMod
    {
        Connection conn = new Connection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien";
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
        public bool AddData(NhanVienObj nvObj)
        {
            string query = "Insert into NhanVien values (@Ma,@Ten,@Gioitinh,@Diachi,@Sdt,@Namsinh)";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            try
            {
                conn.OpenConn();
                cmd.Parameters.Add("@Ma", SqlDbType.NVarChar).Value = nvObj.Ma;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = nvObj.Ten;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nvObj.Gioitinh;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nvObj.Diachi;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nvObj.Sdt;
                cmd.Parameters.Add("@Namsinh", SqlDbType.NVarChar).Value = nvObj.Namsinh;
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
                string query = "Delete NhanVien Where MaNV = '" + ma + "'";
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
        public bool UpdData(NhanVienObj nvObj)
        {
            try
            {
                conn.OpenConn();
                string query = "Update NhanVien set TenNV =  N'" + nvObj.Ten + "', GioiTinh = N'" + nvObj.Gioitinh + "', NamSinh ='" + nvObj.Namsinh + "', DiaChi = N'" + nvObj.Diachi + "',SDT = '" + nvObj.Sdt + "' Where MaNV = '" + nvObj.Ma + "'";
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
    }
}
