using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Control;
using QuanLyKho.Object;
namespace QuanLyKho.Views
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        void dis_en(bool e)
        {
            txt_ma.Enabled = e;
            txt_ten.Enabled = e;
            txt_sdt.Enabled = e;
            txt_dc.Enabled = e;
            cbb_gt.Enabled = e;
            ns.Enabled = e;
            bt_adds.Enabled = e;
            bt_delete.Enabled = e;
            bt_update.Enabled = e;
        }
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
            ns.Value = DateTime.Now.Date;
            loadCMB();
        }
        private void addData(NhanVienObj nv)
        {
            nv.Ma = txt_ma.Text;
            if (cbb_gt.SelectedIndex == 0)
            {
                nv.Gioitinh = "Nam";
            }
            else
                nv.Gioitinh = "Nữ";
            nv.Diachi = txt_dc.Text;
            nv.Sdt = txt_sdt.Text;
            nv.Ten = txt_ten.Text;
            nv.Namsinh = ns.Value.ToShortDateString();
        }
        NhanVienCtrl nvCtr = new NhanVienCtrl();
        NhanVienObj nvObj = new NhanVienObj();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtnv = new DataTable();
            dtnv = nvCtr.GetData();
            DanhSachNV.DataSource = dtnv;
            loadCMB();
            dis_en(true);
        }

        private void bt_adds_Click(object sender, EventArgs e)
        {
            addData(nvObj);
            if (nvCtr.AddData(nvObj))
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            NhanVien_Load(sender, e);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            addData(nvObj);
            if (nvCtr.UpdData(nvObj))
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            NhanVien_Load(sender, e);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtr.DelData(txt_ma.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
            NhanVien_Load(sender, e);
        }

        private void DanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = DanhSachNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten.Text = DanhSachNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_sdt.Text = DanhSachNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_dc.Text = DanhSachNV.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
