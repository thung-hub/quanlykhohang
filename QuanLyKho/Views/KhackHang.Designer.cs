namespace QuanLyKho.Views
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DanhSachKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fill = new Guna.UI2.WinForms.Guna2Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.bt_delete = new Guna.UI2.WinForms.Guna2Button();
            this.bt_update = new Guna.UI2.WinForms.Guna2Button();
            this.bt_adds = new Guna.UI2.WinForms.Guna2Button();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_gt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ma
            // 
            this.txt_ma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ma.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_ma.Location = new System.Drawing.Point(200, 25);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(186, 29);
            this.txt_ma.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(40, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 21);
            this.label10.TabIndex = 115;
            this.label10.Text = "Mã khách hàng:";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.DanhSachKH);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 300);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(900, 450);
            this.guna2CustomGradientPanel1.TabIndex = 113;
            // 
            // DanhSachKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DanhSachKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DanhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhSachKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DanhSachKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DanhSachKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DanhSachKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhSachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DanhSachKH.ColumnHeadersHeight = 36;
            this.DanhSachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SoDT,
            this.DiaChi,
            this.GioiTinh,
            this.Diem});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DanhSachKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.DanhSachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhSachKH.EnableHeadersVisualStyles = false;
            this.DanhSachKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DanhSachKH.Location = new System.Drawing.Point(0, 0);
            this.DanhSachKH.Name = "DanhSachKH";
            this.DanhSachKH.RowHeadersVisible = false;
            this.DanhSachKH.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachKH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DanhSachKH.RowTemplate.Height = 24;
            this.DanhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DanhSachKH.Size = new System.Drawing.Size(900, 450);
            this.DanhSachKH.TabIndex = 1;
            this.DanhSachKH.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DanhSachKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DanhSachKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DanhSachKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DanhSachKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DanhSachKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DanhSachKH.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DanhSachKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DanhSachKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DanhSachKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DanhSachKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.DanhSachKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DanhSachKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DanhSachKH.ThemeStyle.HeaderStyle.Height = 36;
            this.DanhSachKH.ThemeStyle.ReadOnly = false;
            this.DanhSachKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DanhSachKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DanhSachKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.DanhSachKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DanhSachKH.ThemeStyle.RowsStyle.Height = 24;
            this.DanhSachKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DanhSachKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DanhSachKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachKH_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số Điện Thoại";
            this.SoDT.Name = "SoDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "ĐIểm";
            this.Diem.Name = "Diem";
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
            this.panel1.TabIndex = 112;
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
            this.txt_find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_find.Location = new System.Drawing.Point(210, 8);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(450, 29);
            this.txt_find.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
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
            this.guna2Button1.Location = new System.Drawing.Point(651, 183);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(150, 45);
            this.guna2Button1.TabIndex = 111;
            this.guna2Button1.Text = "Xuất File";
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
            this.bt_delete.Location = new System.Drawing.Point(452, 183);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.ShadowDecoration.Parent = this.bt_delete;
            this.bt_delete.Size = new System.Drawing.Size(150, 45);
            this.bt_delete.TabIndex = 110;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.BorderRadius = 20;
            this.bt_update.CheckedState.Parent = this.bt_update;
            this.bt_update.CustomImages.Parent = this.bt_update;
            this.bt_update.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.HoverState.Parent = this.bt_update;
            this.bt_update.Location = new System.Drawing.Point(252, 183);
            this.bt_update.Name = "bt_update";
            this.bt_update.ShadowDecoration.Parent = this.bt_update;
            this.bt_update.Size = new System.Drawing.Size(150, 45);
            this.bt_update.TabIndex = 109;
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
            this.bt_adds.Location = new System.Drawing.Point(53, 183);
            this.bt_adds.Name = "bt_adds";
            this.bt_adds.ShadowDecoration.Parent = this.bt_adds;
            this.bt_adds.Size = new System.Drawing.Size(150, 45);
            this.bt_adds.TabIndex = 108;
            this.bt_adds.Text = "Thêm";
            this.bt_adds.Click += new System.EventHandler(this.bt_adds_Click);
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_dc.Location = new System.Drawing.Point(200, 74);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(186, 29);
            this.txt_dc.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(40, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 106;
            this.label7.Text = "Dịa chỉ:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_sdt.Location = new System.Drawing.Point(200, 123);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(186, 29);
            this.txt_sdt.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 104;
            this.label3.Text = "Số điện thoại:";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_ten.Location = new System.Drawing.Point(592, 23);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(209, 29);
            this.txt_ten.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(435, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tên khách hàng:";
            // 
            // cbb_gt
            // 
            this.cbb_gt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbb_gt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gt.FormattingEnabled = true;
            this.cbb_gt.Location = new System.Drawing.Point(592, 74);
            this.cbb_gt.Name = "cbb_gt";
            this.cbb_gt.Size = new System.Drawing.Size(209, 29);
            this.cbb_gt.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(435, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 117;
            this.label9.Text = "Giới tính:";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.cbb_gt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_adds);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView DanhSachKH;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button bt_fill;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button bt_delete;
        private Guna.UI2.WinForms.Guna2Button bt_update;
        private Guna.UI2.WinForms.Guna2Button bt_adds;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_gt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    }
}