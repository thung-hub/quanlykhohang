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
using System.Data.SqlClient;
namespace QuanLyKho.Views
{
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        SqlCommand cmd;
        DataTable dtDSHH = new System.Data.DataTable();
        KhachHangCtrl khctrl = new KhachHangCtrl();
        NhanVienCtrl nvCtrl = new NhanVienCtrl();
        PhieuXuatCtrl pxctrl = new PhieuXuatCtrl();
        KhoCtrl hhctrl = new KhoCtrl();
        CTPXCtrl ctctrl = new CTPXCtrl();
        int vitriclick = 0;
        public void addMaPN()
        {
            conn.OpenConn();
            string que = "select count (*) from PhieuXuat";
            cmd = new SqlCommand(que, conn.Connect);
            int sol = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            conn.CloseConn();
            var mapn = sol.ToString();
            txt_mapx.Text = mapn;
        }

        public void loadcbbkh()
        {
            KhachHangCtrl nccctrl = new KhachHangCtrl();
            cbb_kh.DisplayMember = "TenKH";
            cbb_kh.ValueMember = "MaKH";
            cbb_kh.DataSource = nccctrl.GetData();
        }
        public void loadcbbh()
        {
            cbb_tenhh.DisplayMember = "TenHang";
            cbb_tenhh.ValueMember = "MaHang";
            cbb_tenhh.DataSource = hhctrl.GetData();

        }
        public void loaddgv()
        {
            loadcbbnv();
            loadcbbkh();
            loadcbbh();
            dtDSHH.Columns.Add("MaHH");
            dtDSHH.Columns.Add("HangHoa");
            dtDSHH.Columns.Add("DonGia");
            dtDSHH.Columns.Add("SoLuong");
            dtDSHH.Columns.Add("ThanhTien");

        }
        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSHH.Rows.Count; i++)
                if (dtDSHH.Rows[i][0].ToString() == mahh)
                    return true;
            return false;
        }
        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSHH.Rows.Count; i++)
            {
                if (dtDSHH.Rows[i][0].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSHH.Rows[i][3].ToString()) + SL;
                    dtDSHH.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSHH.Rows[i][2].ToString());
                    dtDSHH.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nud_sl.Value) > 0)
            {
                if (!checktrung(cbb_tenhh.SelectedValue.ToString()))
                {
                    DataRow dr = dtDSHH.NewRow();
                    dr[0] = txt_mahh.Text.ToString();
                    dr[1] = cbb_tenhh.Text.ToString();
                    dr[2] = txt_dg.Text;
                    dr[3] = nud_sl.Value;
                    dr[4] = (Convert.ToInt32(nud_sl.Value) * int.Parse(txt_dg.Text)).ToString();
                    dtDSHH.Rows.Add(dr);
                }
                else
                {
                    capnhatSL(cbb_tenhh.SelectedValue.ToString(), (Convert.ToInt32(nud_sl.Value)));
                }
                DanhSachHH.DataSource = dtDSHH;
            }
            else
            {
                MessageBox.Show("Hãy chọn số lượng hàng hóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Tinhtong();
        }

        public void Tinhtong()
        {
            int tong = 0;
            for (int i = 0; i < dtDSHH.Rows.Count; i++)
            {
                tong = tong + Convert.ToInt32(dtDSHH.Rows[i][4].ToString());
            }
            lb_tongtien.Text = tong.ToString();
        }
        public void tinhtien()
        {
            int dongia = Convert.ToInt32(txt_dg.Text);
            int Soluong = Convert.ToInt32(nud_sl.Value);
            int thanhtien = dongia * Soluong;
            lb_thanhtien.Text = thanhtien.ToString();
        }
        int dem = 0;

        private void Dis_Enl(bool e)
        {

            bt_delete.Enabled = e;
            bt_adds.Enabled = e;
            bt_luu.Enabled = e;
            cbb_tenhh.Enabled = e;
            nud_sl.Enabled = e;
            txt_mahh.Enabled = e;
            bt_update.Enabled = e;
            bt_in.Enabled = e;
            bt_huy.Enabled = e;
            cbb_nhanvien.Enabled = e;
            cbb_kh.Enabled = e;
        }
        public void loadcbbnv()
        {
            cbb_nhanvien.DisplayMember = "TenNV";
            cbb_nhanvien.ValueMember = "MaNV";
            cbb_nhanvien.DataSource = nvCtrl.GetData();
        }
        private void add_data_hd(PhieuXuatObj pnObj)
        {
            pnObj.Mapx = txt_mapx.Text.Trim();
            pnObj.Ngaylap = dtp_ngaynhap.Value.ToShortDateString();
            pnObj.Tennv = cbb_nhanvien.SelectedValue.ToString();
            pnObj.Tenkh = cbb_kh.SelectedValue.ToString();
            pnObj.Tong = Int32.Parse(lb_tongtien.Text);
        }
        private void XuatHang_Load(object sender, EventArgs e)
        {
            DanhSachHH.DataSource = dtDSHH;
            addMaPN();
            Dis_Enl(false);
            dtp_ngaynhap.Value = DateTime.Now.Date;
        }

        private void cbb_tenhh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhctrl.GetData(cbb_tenhh.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][2].ToString());
                txt_mahh.Text = cbb_tenhh.SelectedValue.ToString();
                txt_dg.Text = (gia).ToString();
            }
            
        }

        private void bt_adds_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nud_sl.Value) > 0)
            {
                if (!checktrung(cbb_tenhh.SelectedValue.ToString()))
                {
                    DataRow dr = dtDSHH.NewRow();
                    dr[0] = txt_mahh.Text.ToString();
                    dr[1] = cbb_tenhh.Text.ToString();
                    dr[2] = txt_dg.Text;
                    dr[3] = nud_sl.Value;
                    dr[4] = (Convert.ToInt32(nud_sl.Value) * int.Parse(txt_dg.Text)).ToString();
                    dtDSHH.Rows.Add(dr);
                }
                else
                {
                    capnhatSL(cbb_tenhh.SelectedValue.ToString(), (Convert.ToInt32(nud_sl.Value)));
                }
                DanhSachHH.DataSource = dtDSHH;
            }
            else
            {
                MessageBox.Show("Hãy chọn số lượng hàng hóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Tinhtong();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSHH.Rows.Count && vitriclick >= 0)
            {
                dtDSHH.Rows.RemoveAt(vitriclick);
                DanhSachHH.DataSource = dtDSHH;
            }
            vitriclick = -1;
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            if (dem == 0)
            {
                Dis_Enl(true);
                loaddgv();
                dem++;
            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            dtDSHH.Rows.Clear();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            PhieuXuatObj hdObj = new PhieuXuatObj();
            add_data_hd(hdObj);
            if (pxctrl.AddData(hdObj))
            {
                if (ctctrl.AddData(txt_mapx.Text, dtDSHH) && hhctrl.DeldSL(dtDSHH))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtDSHH.Columns.Clear();
                XuatHang_Load(sender, e);
                dem = 0;
                this.Close();
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nud_sl_ValueChanged(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_ngaynhap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
