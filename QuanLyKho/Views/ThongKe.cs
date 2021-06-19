using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKho.Control;
using QuanLyKho.Object;
namespace QuanLyKho.Views
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        int daymonth = 0;
        Connection conn = new Connection();
        public void sophieunhap(string day)
        {
            string query;
            if (daymonth == 0)
            {
                query = "select count (*) from PhieuNhap WHERE DAY(Ngaylap) = '" + day + "'";
            }
            else
            {
                query = "select count (*) from PhieuNhap WHERE MONTH(Ngaylap) = '" + day + "'";
            }
            conn.OpenConn();
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            int sol = int.Parse(cmd.ExecuteScalar().ToString());
            conn.CloseConn();
            lb_sophieunhap.Text = sol.ToString();

        }
        public void sophieuxuat(string day)
        {
            string query;
            if (daymonth == 0)
            {
                query = "select count (*) from PhieuXuat WHERE DAY(Ngaylap) = '" + day + "'";
            }
            else
            {
                query = "select count (*) from PhieuXuat WHERE MONTH(Ngaylap) = '" + day + "'";
            }
            conn.OpenConn();
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            int sol = int.Parse(cmd.ExecuteScalar().ToString());
            conn.CloseConn();
            lb_sophieuxuat.Text = sol.ToString();
        }
        public void doanhthu()
        {
            if (dgv_dspx.Rows.Count > 1)
            {
                int tong = 0;
                for (int i = 0; i < dgv_dspx.Rows.Count; i++)
                {
                    if (dgv_dspx.Rows[i].Cells[4].Value != null)
                        tong = tong + Convert.ToInt32(dgv_dspx.Rows[i].Cells[4].Value.ToString());
                }
                lb_doanhthu.Text = tong.ToString();
            }
            else
            {
                lb_doanhthu.Text = "0";
            }
        }
        public void load()
        {
            string d = dtp_thongke.Value.Day.ToString();
            if (daymonth == 0)
            {
                d = dtp_thongke.Value.Day.ToString();
            }
            else
            {
                d = dtp_thongke.Value.Month.ToString();
            }
            sophieunhap(d);
            sophieuxuat(d);
            loaddata(d);
            doanhthu();
        }
        public void loaddata(string day)
        {
            string query;
            if (daymonth == 0)
            {
                query = "select * from PhieuXuat WHERE DAY(Ngaylap) = '" + day + "'";
            }
            else
            {
                query = "select * from PhieuXuat WHERE MONTH(Ngaylap) = '" + day + "'";
            }
            DataTable dt = new DataTable();
            conn.OpenConn();
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.CloseConn();
            dgv_dspx.DataSource = dt;
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            load();
        }

        private void rc_day_CheckedChanged(object sender, EventArgs e)
        {
            daymonth = 0;
            load();
        }

        private void rc_month_CheckedChanged(object sender, EventArgs e)
        {
            daymonth = 1;
            load();
        }

        private void dtp_thongke_ValueChanged(object sender, EventArgs e)
        {
            load();
        }
        int dem = 0;
        private void dgv_dspx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgv_dspx.Rows[e.RowIndex].Cells[0].Value.ToString();
            string query;
            if (dem == 0)
            {
                query = "select * from CTPX WHERE MaPX = '" + ma + "'";
            }
            else
            {
                query = "select * from CTPN WHERE MaPN = '" + ma + "'";
            }
            
            DataTable dt = new DataTable();
            conn.OpenConn();
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.CloseConn();
            dgv_ct.DataSource = dt;
        }
    }
}
