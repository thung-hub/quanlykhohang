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
    class KhachHangMod
    {
        Connection conn = new Connection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            conn.OpenConn();
            string query = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.CloseConn();
            return dt;
        }
        public bool AddData(KhachHangObj nvObj)
        {
            string query = "Insert into KhachHang values (@Ma,@Ten,@Sdt,@Diachi ,@Gioitinh,@Diem)";
            try
            {
                conn.OpenConn();
                SqlCommand cmd = new SqlCommand(query, conn.Connect);
                cmd.Parameters.Add("@Ma", SqlDbType.NVarChar).Value = nvObj.Ma;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = nvObj.Ten;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nvObj.Gioitinh;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nvObj.Diachi;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nvObj.Sdt;
                cmd.Parameters.Add("@Diem", SqlDbType.NVarChar).Value = nvObj.Diem;
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
        public bool DelData(string ma)
        {
            conn.OpenConn();
            string query = "Delete KhachHang Where MaKh = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            conn.CloseConn();
            return true;
        }
        public bool UpdData(KhachHangObj nvObj)
        {
            conn.OpenConn();
            string query = "Update KhachHang set TenKH =  @Ten, GT = @Gioitinh, DC = @Diachi,SoDT = @Sdt  Where MaKh = '" + nvObj.Ma + "'";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = nvObj.Ten;
            cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nvObj.Gioitinh;
            cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nvObj.Diachi;
            cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nvObj.Sdt;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            conn.CloseConn();
            return true;
        }
    }
}
