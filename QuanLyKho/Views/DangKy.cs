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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        NhanVienCtrl ncCtrl = new NhanVienCtrl();
        Connection conn = new Connection();
        public void loadcbbnv()
        {
            cbb_nhanvien.DisplayMember = "TenNV";
            cbb_nhanvien.ValueMember = "MaNV";
            cbb_nhanvien.DataSource = ncCtrl.GetData();
        }
        private void loadCMB()
        {
            cbb_cv.Items.Clear();
            cbb_cv.Items.Add("Quản Lý");
            cbb_cv.Items.Add("Nhân Viên");
        }
        private void DangKy_Load(object sender, EventArgs e)
        {
            loadcbbnv();
            loadCMB();
        }
        public bool AddData()
        {
            string query = "Insert into TaiKhoan values (@tk,@mk,@cv,@nv)";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            try
            {
                conn.OpenConn();
                cmd.Parameters.Add("@tk", SqlDbType.NVarChar).Value = txt_tk.Text;
                cmd.Parameters.Add("@mk", SqlDbType.NVarChar).Value = txt_mk.Text;
                cmd.Parameters.Add("@nv", SqlDbType.NVarChar).Value = cbb_nhanvien.SelectedValue.ToString();
                if(cbb_cv.SelectedIndex == 0)
                {
                    cmd.Parameters.Add("@cv", SqlDbType.NVarChar).Value = "QL";
                }
                else
                {
                    cmd.Parameters.Add("@cv", SqlDbType.NVarChar).Value = "NV";
                }
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
        private void bt_dn_Click(object sender, EventArgs e)
        {
            if (AddData())
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool check()
        {
            if(txt_mk.Text != txt_mk2.Text){
                lb_tb.Text = "Mật khẩu không trùng khớp!!";
                return true;
            }
            else
            {
                lb_tb.Text = "Mật khẩu trùng khớp!!";
                return false;
            }
        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txt_mk2_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void bt_dk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbb_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
