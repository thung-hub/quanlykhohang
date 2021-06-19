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
    class KhoMod
    {
        Connection conn = new Connection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            conn.OpenConn();
            string query = "select * from Kho";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.CloseConn();
            return dt;
        }
        public DataTable GetData(string dieukien)
        {
            DataTable dtk = new DataTable();
            conn.OpenConn();
            string query = "select * from Kho where MaHang = @dk or TenHang = @dk";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            cmd.Parameters.Add("@dk", SqlDbType.NVarChar).Value = dieukien;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtk);
            conn.CloseConn();
            return dtk;
        }
        public bool AddData(KhoObj KhoObj)
        {
            conn.OpenConn();
            string query = "Insert into Kho values (@MaHang,@TenHH,@DonGia,@SoLuong,@DonVi,@Nhacc)";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            cmd.Parameters.Add("@MaHang", SqlDbType.NVarChar).Value = KhoObj.Mahang;
            cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = KhoObj.Tenhang;
            cmd.Parameters.Add("@DonGia", SqlDbType.NVarChar).Value = KhoObj.Dongia;
            cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = KhoObj.Solg;
            cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar).Value = KhoObj.Donvi;
            cmd.Parameters.Add("@Nhacc", SqlDbType.Int).Value = KhoObj.Nhacc;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            conn.CloseConn();
            return true;

        }
        public bool UpdSL(string mahh, int SL)
        {
            conn.OpenConn();
            string query = "Update Kho set  SoLuong = " + SL + " Where MaHang = '" + mahh + "'";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            conn.CloseConn();
            return true;
        }
        public bool DelData(string ma)
        {
            conn.OpenConn();
            string query = "Delete Kho Where MaHang = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            conn.CloseConn();
            return true;
        }
        public bool UpdData(KhoObj KhoObj)
        {
            conn.OpenConn();
            string query = "Update Kho set TenHang =  @TenHH, SoLuong =@SoLuong, DonGia = @DonGia, DonVi =@DonVi,MaNCC =@MaNCC Where MaHang = @MaHang";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            cmd.Parameters.Add("@MaHang", SqlDbType.NVarChar).Value = KhoObj.Mahang;
            cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = KhoObj.Tenhang;
            cmd.Parameters.Add("@DonGia", SqlDbType.NVarChar).Value = KhoObj.Dongia;
            cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = KhoObj.Solg;
            cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar).Value = KhoObj.Donvi;
            cmd.Parameters.Add("@MaNCC", SqlDbType.Int).Value = KhoObj.Nhacc;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            conn.CloseConn();
            return true;

        }
        public DataTable finddata(string ma)
        {
            DataTable dtf = new DataTable();
            conn.OpenConn();
            string query = "select * from Kho WHERE MaHang LIKE  '%" + ma + "%' or TenHang LIKE  '%" + ma + "%' ";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtf);
            conn.CloseConn();
            return dtf;
        }
    }
}
