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
using QuanLyKho.Models;
using QuanLyKho.Object;
namespace QuanLyKho.Views
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dtnv = new DataTable();
            dtnv = nccCtrl.GetData();
            DanhSachNCC.DataSource = dtnv;
            dis_en(true);
        }
        NhacungcapCtrl nccCtrl = new NhacungcapCtrl();
        NhacungcapObj nccObj = new NhacungcapObj();
        void dis_en(bool e)
        {
            txt_ma.Enabled = e;
            txt_ten.Enabled = e;
            txt_sdt.Enabled = e;
            txt_dc.Enabled = e;
            txt_ghichu.Enabled = e;
            bt_adds.Enabled = e;
            bt_delete.Enabled = e;
            bt_update.Enabled = e;
        }
        private void clearData()
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_dc.Text = "";
            txt_sdt.Text = "";
            txt_ghichu.Text = "";
            
        }
        private void addData(NhacungcapObj ncc)
        {
            ncc.Mancc = Int32.Parse(txt_ma.Text);
            ncc.Tencc = txt_ten.Text;
            ncc.Sdt = txt_sdt.Text;
            ncc.Diachi = txt_dc.Text;
            ncc.Ghichu = txt_ghichu.Text;
        }
        private void bt_adds_Click(object sender, EventArgs e)
        {
            addData(nccObj);
            if (nccCtrl.AddData(nccObj))
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            NhaCungCap_Load(sender, e);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            addData(nccObj);
            if (nccCtrl.UpdData(nccObj))
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            NhaCungCap_Load(sender, e);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nccCtrl.DelData(txt_ma.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
            NhaCungCap_Load(sender, e);
        }

        private void DanhSachNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = DanhSachNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten.Text = DanhSachNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_sdt.Text = DanhSachNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_dc.Text = DanhSachNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ghichu.Text = DanhSachNCC.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
    }
}
