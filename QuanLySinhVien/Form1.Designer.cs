namespace QuanLySinhVien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.searchInput = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnBoSung = new System.Windows.Forms.ToolStripDropDownButton();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbDiem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbGioiTinh = new System.Windows.Forms.CheckBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcDiemChiTiet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVanHD = new System.Windows.Forms.TextBox();
            this.txtVanCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtVatLyDien = new System.Windows.Forms.TextBox();
            this.txtVatLyCo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtCnttAlgor = new System.Windows.Forms.TextBox();
            this.txtCnttCoding = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.tcDiemChiTiet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCapNhat,
            this.btnXoa,
            this.searchInput,
            this.btnSearch,
            this.btnBoSung});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCapNhat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(59, 22);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // searchInput
            // 
            this.searchInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(330, 25);
            this.searchInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchInput_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBoSung
            // 
            this.btnBoSung.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBoSung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBoSung.Image = ((System.Drawing.Image)(resources.GetObject("btnBoSung.Image")));
            this.btnBoSung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoSung.Name = "btnBoSung";
            this.btnBoSung.Size = new System.Drawing.Size(63, 22);
            this.btnBoSung.Text = "Bổ sung";
            this.btnBoSung.Click += new System.EventHandler(this.btnBoSung_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.dtpNgaySinh);
            this.gbThongTin.Controls.Add(this.lbDiem);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.chkbGioiTinh);
            this.gbThongTin.Controls.Add(this.txtHoVaTen);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.tcDiemChiTiet);
            this.gbThongTin.Location = new System.Drawing.Point(372, 31);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(416, 407);
            this.gbThongTin.TabIndex = 2;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin chi tiết:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(10, 131);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 10;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Location = new System.Drawing.Point(43, 380);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(0, 13);
            this.lbDiem.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ĐTB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh:";
            // 
            // chkbGioiTinh
            // 
            this.chkbGioiTinh.AutoSize = true;
            this.chkbGioiTinh.Location = new System.Drawing.Point(10, 75);
            this.chkbGioiTinh.Name = "chkbGioiTinh";
            this.chkbGioiTinh.Size = new System.Drawing.Size(89, 17);
            this.chkbGioiTinh.TabIndex = 6;
            this.chkbGioiTinh.Text = "Giới tính nam";
            this.chkbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(10, 49);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(396, 20);
            this.txtHoVaTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ tên:";
            // 
            // tcDiemChiTiet
            // 
            this.tcDiemChiTiet.Controls.Add(this.tabPage1);
            this.tcDiemChiTiet.Controls.Add(this.tabPage2);
            this.tcDiemChiTiet.Controls.Add(this.tabPage3);
            this.tcDiemChiTiet.Location = new System.Drawing.Point(6, 179);
            this.tcDiemChiTiet.Name = "tcDiemChiTiet";
            this.tcDiemChiTiet.SelectedIndex = 0;
            this.tcDiemChiTiet.Size = new System.Drawing.Size(404, 194);
            this.tcDiemChiTiet.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtVanHD);
            this.tabPage1.Controls.Add(this.txtVanCD);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Văn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtVanHD
            // 
            this.txtVanHD.Location = new System.Drawing.Point(122, 92);
            this.txtVanHD.Name = "txtVanHD";
            this.txtVanHD.Size = new System.Drawing.Size(231, 20);
            this.txtVanHD.TabIndex = 11;
            // 
            // txtVanCD
            // 
            this.txtVanCD.Location = new System.Drawing.Point(122, 56);
            this.txtVanCD.Name = "txtVanCD";
            this.txtVanCD.Size = new System.Drawing.Size(231, 20);
            this.txtVanCD.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Văn học HĐ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Văn học CĐ: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtVatLyDien);
            this.tabPage2.Controls.Add(this.txtVatLyCo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vật lý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtVatLyDien
            // 
            this.txtVatLyDien.Location = new System.Drawing.Point(122, 92);
            this.txtVatLyDien.Name = "txtVatLyDien";
            this.txtVatLyDien.Size = new System.Drawing.Size(231, 20);
            this.txtVatLyDien.TabIndex = 7;
            // 
            // txtVatLyCo
            // 
            this.txtVatLyCo.Location = new System.Drawing.Point(122, 56);
            this.txtVatLyCo.Name = "txtVatLyCo";
            this.txtVatLyCo.Size = new System.Drawing.Size(231, 20);
            this.txtVatLyCo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vật lý điện: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Vật lý cơ: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCnttAlgor);
            this.tabPage3.Controls.Add(this.txtCnttCoding);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(396, 168);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CNTT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtCnttAlgor
            // 
            this.txtCnttAlgor.Location = new System.Drawing.Point(122, 92);
            this.txtCnttAlgor.Name = "txtCnttAlgor";
            this.txtCnttAlgor.Size = new System.Drawing.Size(231, 20);
            this.txtCnttAlgor.TabIndex = 7;
            // 
            // txtCnttCoding
            // 
            this.txtCnttCoding.Location = new System.Drawing.Point(122, 56);
            this.txtCnttCoding.Name = "txtCnttCoding";
            this.txtCnttCoding.Size = new System.Drawing.Size(231, 20);
            this.txtCnttCoding.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Thuật toán: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Lập trình: ";
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.Location = new System.Drawing.Point(12, 31);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(354, 407);
            this.lstSinhVien.TabIndex = 3;
            this.lstSinhVien.Click += new System.EventHandler(this.lstSinhVien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.tcDiemChiTiet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripTextBox searchInput;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TabControl tcDiemChiTiet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.ToolStripDropDownButton btnBoSung;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbGioiTinh;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtVatLyDien;
        private System.Windows.Forms.TextBox txtVatLyCo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCnttAlgor;
        private System.Windows.Forms.TextBox txtCnttCoding;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVanHD;
        private System.Windows.Forms.TextBox txtVanCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

