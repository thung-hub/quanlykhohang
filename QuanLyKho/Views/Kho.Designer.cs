namespace QuanLyKho.Views
{
    partial class Kho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kho));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DanhSachHH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_ncc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dg = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_delete = new Guna.UI2.WinForms.Guna2Button();
            this.bt_update = new Guna.UI2.WinForms.Guna2Button();
            this.bt_adds = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fill = new Guna.UI2.WinForms.Guna2Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_nhaphang = new Guna.UI2.WinForms.Guna2Button();
            this.bt_xuathang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachHH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.DanhSachHH);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 300);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(900, 300);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // DanhSachHH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DanhSachHH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DanhSachHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhSachHH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DanhSachHH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DanhSachHH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DanhSachHH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DanhSachHH.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DanhSachHH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhSachHH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DanhSachHH.ColumnHeadersHeight = 40;
            this.DanhSachHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.DonGia,
            this.SoLuong,
            this.DonVi,
            this.MaNCC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhSachHH.DefaultCellStyle = dataGridViewCellStyle3;
            this.DanhSachHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhSachHH.EnableHeadersVisualStyles = false;
            this.DanhSachHH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DanhSachHH.Location = new System.Drawing.Point(0, 0);
            this.DanhSachHH.Name = "DanhSachHH";
            this.DanhSachHH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DanhSachHH.RowHeadersVisible = false;
            this.DanhSachHH.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DanhSachHH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DanhSachHH.RowTemplate.Height = 50;
            this.DanhSachHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DanhSachHH.Size = new System.Drawing.Size(900, 300);
            this.DanhSachHH.TabIndex = 0;
            this.DanhSachHH.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DanhSachHH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DanhSachHH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DanhSachHH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DanhSachHH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DanhSachHH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DanhSachHH.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DanhSachHH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DanhSachHH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DanhSachHH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DanhSachHH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.DanhSachHH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DanhSachHH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DanhSachHH.ThemeStyle.HeaderStyle.Height = 40;
            this.DanhSachHH.ThemeStyle.ReadOnly = false;
            this.DanhSachHH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DanhSachHH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DanhSachHH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachHH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DanhSachHH.ThemeStyle.RowsStyle.Height = 50;
            this.DanhSachHH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DanhSachHH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DanhSachHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachHH_CellContentClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 8;
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.MinimumWidth = 8;
            this.TenHang.Name = "TenHang";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.MinimumWidth = 8;
            this.DonVi.Name = "DonVi";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            // 
            // cbb_ncc
            // 
            this.cbb_ncc.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ncc.FormattingEnabled = true;
            this.cbb_ncc.Location = new System.Drawing.Point(554, 135);
            this.cbb_ncc.Name = "cbb_ncc";
            this.cbb_ncc.Size = new System.Drawing.Size(257, 36);
            this.cbb_ncc.TabIndex = 58;
            this.cbb_ncc.SelectedIndexChanged += new System.EventHandler(this.cbb_ncc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(413, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nhà cung cấp:";
            // 
            // txt_dv
            // 
            this.txt_dv.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dv.Location = new System.Drawing.Point(199, 134);
            this.txt_dv.Name = "txt_dv";
            this.txt_dv.Size = new System.Drawing.Size(155, 35);
            this.txt_dv.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(56, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 32);
            this.label7.TabIndex = 55;
            this.label7.Text = "Đơn vị:";
            // 
            // txt_dg
            // 
            this.txt_dg.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dg.Location = new System.Drawing.Point(554, 81);
            this.txt_dg.Name = "txt_dg";
            this.txt_dg.Size = new System.Drawing.Size(176, 35);
            this.txt_dg.TabIndex = 54;
            // 
            // txt_sl
            // 
            this.txt_sl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sl.Location = new System.Drawing.Point(199, 80);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(155, 35);
            this.txt_sl.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(741, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 51;
            this.label5.Text = "( VND )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(413, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "Đơn giá:";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(554, 28);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(257, 35);
            this.txt_ten.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(413, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tên hàng hóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Số lượng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_ma
            // 
            this.txt_ma.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(199, 30);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(155, 35);
            this.txt_ma.TabIndex = 47;
            this.txt_ma.TextChanged += new System.EventHandler(this.txt_ma_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã hàng hóa:";
            // 
            // bt_delete
            // 
            this.bt_delete.BorderRadius = 20;
            this.bt_delete.CheckedState.Parent = this.bt_delete;
            this.bt_delete.CustomImages.Parent = this.bt_delete;
            this.bt_delete.FillColor = System.Drawing.Color.Red;
            this.bt_delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.White;
            this.bt_delete.HoverState.Parent = this.bt_delete;
            this.bt_delete.Location = new System.Drawing.Point(462, 191);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.ShadowDecoration.Parent = this.bt_delete;
            this.bt_delete.Size = new System.Drawing.Size(150, 45);
            this.bt_delete.TabIndex = 61;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click_1);
            // 
            // bt_update
            // 
            this.bt_update.BorderRadius = 20;
            this.bt_update.CheckedState.Parent = this.bt_update;
            this.bt_update.CustomImages.Parent = this.bt_update;
            this.bt_update.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.HoverState.Parent = this.bt_update;
            this.bt_update.Location = new System.Drawing.Point(262, 191);
            this.bt_update.Name = "bt_update";
            this.bt_update.ShadowDecoration.Parent = this.bt_update;
            this.bt_update.Size = new System.Drawing.Size(150, 45);
            this.bt_update.TabIndex = 60;
            this.bt_update.Text = "Sửa";
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_adds
            // 
            this.bt_adds.BorderRadius = 20;
            this.bt_adds.CheckedState.Parent = this.bt_adds;
            this.bt_adds.CustomImages.Parent = this.bt_adds;
            this.bt_adds.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.bt_adds.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_adds.ForeColor = System.Drawing.Color.White;
            this.bt_adds.HoverState.Parent = this.bt_adds;
            this.bt_adds.Location = new System.Drawing.Point(63, 191);
            this.bt_adds.Name = "bt_adds";
            this.bt_adds.ShadowDecoration.Parent = this.bt_adds;
            this.bt_adds.Size = new System.Drawing.Size(150, 45);
            this.bt_adds.TabIndex = 59;
            this.bt_adds.Text = "Thêm";
            this.bt_adds.Click += new System.EventHandler(this.bt_adds_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.bt_fill);
            this.panel1.Controls.Add(this.txt_find);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 50);
            this.panel1.TabIndex = 62;
            // 
            // bt_fill
            // 
            this.bt_fill.BorderRadius = 20;
            this.bt_fill.CheckedState.Parent = this.bt_fill;
            this.bt_fill.CustomImages.Parent = this.bt_fill;
            this.bt_fill.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bt_fill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fill.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bt_fill.HoverState.Parent = this.bt_fill;
            this.bt_fill.Image = ((System.Drawing.Image)(resources.GetObject("bt_fill.Image")));
            this.bt_fill.Location = new System.Drawing.Point(721, 5);
            this.bt_fill.Name = "bt_fill";
            this.bt_fill.ShadowDecoration.Parent = this.bt_fill;
            this.bt_fill.Size = new System.Drawing.Size(100, 40);
            this.bt_fill.TabIndex = 65;
            this.bt_fill.Text = "Fill";
            this.bt_fill.Click += new System.EventHandler(this.bt_fill_Click);
            // 
            // txt_find
            // 
            this.txt_find.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_find.Location = new System.Drawing.Point(210, 10);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(450, 35);
            this.txt_find.TabIndex = 64;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 38);
            this.label8.TabIndex = 63;
            this.label8.Text = "Tìm Kiếm:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Green;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(661, 191);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(150, 45);
            this.guna2Button1.TabIndex = 63;
            this.guna2Button1.Text = "Xuất File";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.bt_nhaphang);
            this.panel2.Controls.Add(this.bt_xuathang);
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 50);
            this.panel2.TabIndex = 64;
            // 
            // bt_nhaphang
            // 
            this.bt_nhaphang.BackColor = System.Drawing.Color.Transparent;
            this.bt_nhaphang.BorderRadius = 20;
            this.bt_nhaphang.CheckedState.Parent = this.bt_nhaphang;
            this.bt_nhaphang.CustomImages.Parent = this.bt_nhaphang;
            this.bt_nhaphang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhaphang.ForeColor = System.Drawing.Color.White;
            this.bt_nhaphang.HoverState.Parent = this.bt_nhaphang;
            this.bt_nhaphang.Image = ((System.Drawing.Image)(resources.GetObject("bt_nhaphang.Image")));
            this.bt_nhaphang.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_nhaphang.Location = new System.Drawing.Point(493, 3);
            this.bt_nhaphang.Name = "bt_nhaphang";
            this.bt_nhaphang.ShadowDecoration.Parent = this.bt_nhaphang;
            this.bt_nhaphang.Size = new System.Drawing.Size(200, 45);
            this.bt_nhaphang.TabIndex = 65;
            this.bt_nhaphang.Text = "Nhập Hàng";
            this.bt_nhaphang.Click += new System.EventHandler(this.bt_nhaphang_Click);
            // 
            // bt_xuathang
            // 
            this.bt_xuathang.BackColor = System.Drawing.Color.Transparent;
            this.bt_xuathang.BorderRadius = 20;
            this.bt_xuathang.CheckedState.Parent = this.bt_xuathang;
            this.bt_xuathang.CustomImages.Parent = this.bt_xuathang;
            this.bt_xuathang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xuathang.ForeColor = System.Drawing.Color.White;
            this.bt_xuathang.HoverState.Parent = this.bt_xuathang;
            this.bt_xuathang.Image = ((System.Drawing.Image)(resources.GetObject("bt_xuathang.Image")));
            this.bt_xuathang.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_xuathang.Location = new System.Drawing.Point(700, 3);
            this.bt_xuathang.Name = "bt_xuathang";
            this.bt_xuathang.ShadowDecoration.Parent = this.bt_xuathang;
            this.bt_xuathang.Size = new System.Drawing.Size(200, 45);
            this.bt_xuathang.TabIndex = 64;
            this.bt_xuathang.Text = "Xuất Hàng";
            this.bt_xuathang.Click += new System.EventHandler(this.bt_xuathang_Click);
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_adds);
            this.Controls.Add(this.cbb_ncc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_dv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dg);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kho";
            this.Text = "Kho Hàng";
            this.Load += new System.EventHandler(this.Kho_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachHH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView DanhSachHH;
        private System.Windows.Forms.ComboBox cbb_ncc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dg;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button bt_delete;
        private Guna.UI2.WinForms.Guna2Button bt_update;
        private Guna.UI2.WinForms.Guna2Button bt_adds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button bt_xuathang;
        private Guna.UI2.WinForms.Guna2Button bt_nhaphang;
        private Guna.UI2.WinForms.Guna2Button bt_fill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
    }
}