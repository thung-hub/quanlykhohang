using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Object;
using QuanLyKho.Control;
namespace QuanLyKho.Views
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        KhachHangCtrl khCtrl = new KhachHangCtrl();
        KhachHangObj khObj = new KhachHangObj();
        private void loadCMB()
        {
            cbb_gt.Items.Clear();
            cbb_gt.Items.Add("Nam");
            cbb_gt.Items.Add("Nữ");
        }
        private void clearData()
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_dc.Text = "";
            txt_sdt.Text = "";
            loadCMB();
        }
        private void addData(KhachHangObj nv)
        {
            nv.Ma = txt_ma.Text;
            if (cbb_gt.SelectedIndex == 0)
            {
                nv.Gioitinh = "Nam";
            }
            else
                nv.Gioitinh = "Nữ";
            nv.Diachi = txt_dc.Text;
            nv.Sdt = Int32.Parse(txt_sdt.Text);
            nv.Ten = txt_ten.Text;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtnv = new DataTable();
            dtnv = khCtrl.GetData();
            DanhSachKH.DataSource = dtnv;
            loadCMB();
        }

        private void bt_adds_Click(object sender, EventArgs e)
        {
            addData(khObj);
            if (khCtrl.AddData(khObj))
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            KhachHang_Load(sender,e);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            addData(khObj);
            if (khCtrl.UpdData(khObj))
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            KhachHang_Load(sender, e);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khCtrl.DelData(txt_ma.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
            KhachHang_Load(sender, e);
        }

        private void bt_fill_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = DanhSachKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten.Text = DanhSachKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_sdt.Text = DanhSachKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_dc.Text = DanhSachKH.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
