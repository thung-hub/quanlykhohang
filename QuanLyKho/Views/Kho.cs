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
using QuanLyKho.Models;

namespace QuanLyKho.Views
{
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        KhoCtrl kctrl = new KhoCtrl();
        private void addData(KhoObj hh)
        {
            hh.Mahang = txt_ma.Text;
            hh.Tenhang = txt_ten.Text;
            hh.Donvi = txt_dv.Text;
            hh.Nhacc = cbb_ncc.SelectedValue.ToString();
            hh.Solg = Int32.Parse(txt_sl.Text);
            hh.Dongia = Int32.Parse(txt_dg.Text);
        }
        public void loadcbbkh()
        {
            NhacungcapCtrl nccctrl = new NhacungcapCtrl();
            cbb_ncc.DisplayMember = "TenNCC";
            cbb_ncc.ValueMember = "MaNCC";
            cbb_ncc.DataSource = nccctrl.GetData();
        }
        private void Kho_Load(object sender, EventArgs e)
        {
            DataTable dtk = new DataTable();
            dtk = kctrl.GetData();
            DanhSachHH.DataSource = dtk;
            loadcbbkh();

        }
        string str;
        public Kho(string giatrinhan) : this()
        {
            str = giatrinhan;
            label1.Text = str;
        }
        private void DanhSachHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = DanhSachHH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten.Text = DanhSachHH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_dg.Text = DanhSachHH.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_sl.Text = DanhSachHH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_dv.Text = DanhSachHH.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbb_ncc.Text = DanhSachHH.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        KhoObj kho = new KhoObj();
        private void bt_update_Click(object sender, EventArgs e)
        {
            
            addData(kho);
            if (kctrl.UpdData(kho))
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            Kho_Load(sender, e);
        }
        
        private void bt_nhaphang_Click(object sender, EventArgs e)
        {
            NhapHang form = new NhapHang();
            form.Hide();
            form.Show();
        }

        private void bt_xuathang_Click(object sender, EventArgs e)
        {
            XuatHang form = new XuatHang();
            form.Hide();
            form.Show();
        }
        private void clearData()
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_sl.Text = "";
            txt_dg.Text = "";
            txt_dv.Text = "";
        }
        private void bt_adds_Click(object sender, EventArgs e)
        {
            addData(kho);
            if (kctrl.AddData(kho))
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearData();
            Kho_Load(sender, e);
        }

        private void bt_fill_Click(object sender, EventArgs e)
        {
            string mafind = txt_find.Text;
            DataTable dtkfind = new DataTable();
            dtkfind = kctrl.Finddata(mafind);
            DanhSachHH.DataSource = dtkfind;
        }

        private void bt_delete_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (kctrl.DelData(txt_ma.Text))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
            Kho_Load(sender, e);
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            string mafind = txt_find.Text;
            DataTable dtkfind = new DataTable();
            dtkfind = kctrl.Finddata(mafind);
            DanhSachHH.DataSource = dtkfind;
        }

        private void txt_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
