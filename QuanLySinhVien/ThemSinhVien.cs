using QuanLySinhVien.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class ThemSinhVien : Form
    {
        string maSinhVien;
        string hoVaTen;
        bool gioiTinhNam;
        DateTime ngaySinh;
        string maNganh;
        string maMonHoc1;
        string maMonHoc2;
        List<Nganh> nganh = Nganh.getNganh();
        public ThemSinhVien()
        {
            InitializeComponent();
            for (int i = 0; i < nganh.Count; i++)
            {
                cbNganh.Items.Add(nganh.ElementAt(i).TenNganh);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            maSinhVien = txtMaSinhVien.Text;
            hoVaTen = txtHoVaTen.Text;
            gioiTinhNam = chkbNam.Checked;
            ngaySinh = dtpNgaySinh.Value;
            maNganh = nganh.ElementAt(cbNganh.SelectedIndex).MaNganh;

            double diem1 = Convert.ToDouble(txtDiem1.Text);
            double diem2 = Convert.ToDouble(txtDiem2.Text);
            if ((diem1 >= 0 && diem1 <= 10) && (diem1 >= 0 && diem2 <= 10))
            {
                SinhVien sv = new SinhVien { MaNganh = maNganh, MaSinhVien = maSinhVien, HoVaTen = hoVaTen, GioiTinh = gioiTinhNam, NgaySinh = ngaySinh };
                SinhVien.themSinhVien(sv);
                DiemHocTap.themDiemHocTap(maSinhVien, maMonHoc1, txtMon1.Text, diem1, maMonHoc2, txtMon2.Text, diem2);
                MessageBox.Show("Đã thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin nhập vào không hợp lệ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = nganh.ElementAt(cbNganh.SelectedIndex).MaNganh;
            maMonHoc1 = "";
            maMonHoc2 = "";
            switch (temp)
            {
                case "cntt":
                    txtMon1.Text = "Lập trình";
                    maMonHoc1 = "cntt1";
                    txtMon2.Text = "Thuật toán";
                    maMonHoc2 = "cntt2";
                    break;
                case "vatly":
                    txtMon1.Text = "Vật lý cơ";
                    maMonHoc1 = "vatly1";
                    txtMon2.Text = "Vật lý điện";
                    maMonHoc2 = "vatly2";
                    break;
                case "van":
                    txtMon1.Text = "Văn học CĐ";
                    maMonHoc1 = "van1";
                    txtMon2.Text = "Văn học HĐ";
                    maMonHoc2 = "van2";
                    break;
            }
        }
    }
}
