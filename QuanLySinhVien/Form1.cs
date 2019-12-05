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
    public partial class Form1 : Form
    {
        List<SinhVien> listSinhVien = SinhVien.getListSinhVien();
        public Form1()
        {
            InitializeComponent();
            setListSinhVien();
        }

        public void setListSinhVien()
        {
            lstSinhVien.Items.Clear();
            //listSinhVien = SinhVien.getListSinhVien();
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                string temp = listSinhVien.ElementAt(i).GioiTinh == true ? "Anh " : "Chị ";
                temp += listSinhVien.ElementAt(i).HoVaTen;
                lstSinhVien.Items.Add(temp);
            }
            if (lstSinhVien.Items.Count > 0)
            {
                lstSinhVien.SelectedIndex = 0;
                setThongTin(0);
            }
        }

        public void setThongTin(int index)
        {
            var temp = listSinhVien.ElementAt(index);
            txtHoVaTen.Text = temp.HoVaTen;
            chkbGioiTinh.Checked = temp.GioiTinh;
            dtpNgaySinh.Value = temp.NgaySinh;
            switch (temp.MaNganh)
            {
                case "van":
                    txtVanCD.Text = temp.ListDiemHocTap.ElementAt(0).Diem.ToString();
                    txtVanHD.Text = temp.ListDiemHocTap.ElementAt(1).Diem.ToString();
                    tcDiemChiTiet.SelectedTab = tcDiemChiTiet.TabPages[0];
                    break;
                case "vatly":
                    txtVatLyCo.Text = temp.ListDiemHocTap.ElementAt(0).Diem.ToString();
                    txtVatLyDien.Text = temp.ListDiemHocTap.ElementAt(1).Diem.ToString();
                    tcDiemChiTiet.SelectedTab = tcDiemChiTiet.TabPages[1];
                    break;
                case "cntt":
                    txtCnttCoding.Text = temp.ListDiemHocTap.ElementAt(0).Diem.ToString();
                    txtCnttAlgor.Text = temp.ListDiemHocTap.ElementAt(1).Diem.ToString();
                    tcDiemChiTiet.SelectedTab = tcDiemChiTiet.TabPages[2];
                    break;
            }
            lbDiem.Text = ((temp.ListDiemHocTap.ElementAt(0).Diem + temp.ListDiemHocTap.ElementAt(1).Diem) / 2).ToString();
        }

        private void lstSinhVien_Click(object sender, EventArgs e)
        {
            int row = lstSinhVien.SelectedIndex;
            setThongTin(row);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = listSinhVien.ElementAt(lstSinhVien.SelectedIndex);
            string maSinhVien = sv.MaSinhVien;
            string maNganh = sv.MaNganh;
            string hoVaTen = txtHoVaTen.Text;
            bool gioiTinh = chkbGioiTinh.Checked;
            DateTime ngaySinh = dtpNgaySinh.Value;
            double diem1, diem2;
            if (maNganh == "van")
            {
                diem1 = Convert.ToDouble(txtVanCD.Text);
                diem2 = Convert.ToDouble(txtVanHD.Text);
            }
            else if (maNganh == "cntt")
            {
                diem1 = Convert.ToDouble(txtCnttCoding.Text);
                diem2 = Convert.ToDouble(txtCnttAlgor.Text);
            }
            else
            {
                diem1 = Convert.ToDouble(txtVatLyCo.Text);
                diem2 = Convert.ToDouble(txtVatLyDien.Text);
            }
            SinhVien.editSinhVien(maSinhVien, hoVaTen, gioiTinh, ngaySinh, diem1, diem2);
            DiemHocTap.editDiemHocTap(maSinhVien, diem1, diem2);
            listSinhVien = SinhVien.getListSinhVien();
            setListSinhVien();
            MessageBox.Show("Đã cập nhật thông tin");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSinhVien = listSinhVien.ElementAt(lstSinhVien.SelectedIndex).MaSinhVien;
            DiemHocTap.xoaDiemHocTap(maSinhVien);
            SinhVien.xoaSinhVien(maSinhVien);
            listSinhVien = SinhVien.getListSinhVien();
            setListSinhVien();
            MessageBox.Show("Đã xóa");
        }

        private void btnBoSung_Click(object sender, EventArgs e)
        {
            ThemSinhVien form = new ThemSinhVien();
            form.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listSinhVien = SinhVien.getListSinhVien();
            setListSinhVien();
        }

        private void searchInput_KeyUp(object sender, KeyEventArgs e)
        {
            listSinhVien = SinhVien.getListSinhVien();
            string keySearch = searchInput.Text;
            List<SinhVien> tempList = new List<SinhVien>();
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < listSinhVien.Count; i++)
                {
                    SinhVien temp = listSinhVien.ElementAt(i);
                    if (temp.HoVaTen.Contains(keySearch))
                    {
                        tempList.Add(temp);
                    }
                }
                listSinhVien = tempList;
                setListSinhVien();
            }
            if (searchInput.Text.Equals(""))
            {
                listSinhVien = SinhVien.getListSinhVien();
                setListSinhVien();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listSinhVien = SinhVien.getListSinhVien();
            string keySearch = searchInput.Text;
            List<SinhVien> tempList = new List<SinhVien>();
            if (searchInput.Text.Equals(""))
            {
                listSinhVien = SinhVien.getListSinhVien();
                setListSinhVien();
            }
            else
            {
                for (int i = 0; i < listSinhVien.Count; i++)
                {
                    SinhVien temp = listSinhVien.ElementAt(i);
                    if (temp.HoVaTen.Contains(keySearch))
                    {
                        tempList.Add(temp);
                    }
                }
                listSinhVien = tempList;
                setListSinhVien();
            }
        }
    }
}
