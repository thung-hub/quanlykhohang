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
using QuanLyKho.Object;
namespace QuanLyKho.Views
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            conn.OpenConn();
            string query = "select count(*) from TaiKhoan Where Taikhoan ='"+txt_tk.Text+"' and MatKhau = '"+txt_mk.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            int sl = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.CloseConn();
            if (sl == 0)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!");
            }
            else
            {
                Main child = new Main(txt_tk.Text);
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                child.Show();
            }
        }

        private void bt_dk_Click(object sender, EventArgs e)
        {
            conn.OpenConn();
            string query = "select count(*) from TaiKhoan Where Taikhoan ='" + txt_tk.Text + "' and MatKhau = '" + txt_mk.Text + "' and ChucVu ='QL'";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            int sl = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.CloseConn();
            if (sl == 0)
            {
                MessageBox.Show("vui lòng nhập đúng tài khoản và mật khẩu của người quản lý!!");
            }
            else
            {
                DangKy form = new DangKy();
                form.Show();
            }
            
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }
    }
}
