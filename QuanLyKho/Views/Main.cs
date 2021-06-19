using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Views;
using QuanLyKho.Object;
using System.Data.SqlClient;
namespace QuanLyKho
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string strNhan;
        public Main(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
        }
        Connection conn = new Connection();
        string cvs;
        string name;
        public void checkcv(string cv)
        {
            DataTable dtas = new DataTable();
            conn.OpenConn();
            string query = "select ChucVu,MaNhanVien from TaiKhoan Where Taikhoan ='" + cv + "' ";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtas);
            conn.CloseConn();
            name = dtas.Rows[0][1].ToString();
            cvs = Convert.ToString(dtas.Rows[0][0].ToString());
            if(cvs == "NV")
            {
                bt_quanly.Enabled = false;
                bt_thongke.Enabled = false;
            }
            else
            {
                bt_quanly.Enabled = true;
                bt_thongke.Enabled = true;
            }
        }
        public void loadname(string name)
        {
            DataTable dtas = new DataTable();
            conn.OpenConn();
            string query = "select TenNV from NhanVien Where MaNV ='" + name + "' ";
            SqlCommand cmd = new SqlCommand(query, conn.Connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtas);
            //lb_nv.Text = dtas.Rows[0][0].ToString();
            conn.CloseConn();
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                DangNhap form = new DangNhap();
                form.Show();
            }
            
        }
        private void addform(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            pMain.Controls.Add(f);
            f.Show();
        }
        private void hiden()
        {
            bt_nhanvien.Hide();
            bt_ncc.Hide();
        }
        private void shows()
        {
            bt_nhanvien.Show();
            bt_ncc.Show();
        }
        private Form currentChildForm;
        private void openCF(Form Cform)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = Cform;
            Cform.TopLevel = false;
            Cform.FormBorderStyle = FormBorderStyle.None;
            Cform.Dock = DockStyle.Fill;
            pMain.Controls.Add(Cform);
            pMain.Tag = Cform;
            Cform.BringToFront();
            Cform.Show();
            lb_namecf.Text = Cform.Text;
        }
        private void bt_kho_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            openCF(new Kho());
            hiden();

        }
        public delegate void delPassData(TextBox text);
        private void Main_Load(object sender, EventArgs e)
        {
            hiden();
            checkcv(strNhan);
            loadname(name);
        }

        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            openCF(new NhanVien());
        }

        private void bt_ncc_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            openCF(new NhaCungCap());
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            openCF(new ThongKe());
            hiden();
        }

        private void bt_quanly_Click(object sender, EventArgs e)
        {
            shows();
            lb_namecf.Text = "Quan Ly";
            bt_nhanvien_Click(sender, e);
        }

        private void bt_khachhang_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            openCF(new KhachHang());
            hiden();
        }

        private void bt_main_Click(object sender, EventArgs e)
        {

        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                DangNhap form = new DangNhap();
                form.Show();
            }
        }
    }
}
