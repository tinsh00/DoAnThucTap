using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AplicationApi.Models;

namespace AplicationApi
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        bool isDangGhi, isDangSua;
        CarUserReponsitoty _reponsitory = new CarUserReponsitoty();
        public UserForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            isDangGhi = true;
            txtHoTen.Enabled = txtEmail.Enabled = txtSDT.Enabled = true;
            cmbTT.Enabled = cmbGioiTinh.Enabled = true;
            dtpNgayDK.Enabled = dtpNgaySinh.Enabled = true;
            txtHoTen.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("vui lòng chọn row cần xóa", "", MessageBoxButtons.OK);
                return;
            }
            var U = new CarUser();
            U.ID = Convert.ToInt32(txtID.Text);
            _reponsitory.Delete(U);
            MessageBox.Show("Đã Xóa", "", MessageBoxButtons.OK);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangSua = true;
            txtHoTen.Enabled = txtEmail.Enabled = txtSDT.Enabled = true;
            cmbTT.Enabled = cmbGioiTinh.Enabled = true;
            dtpNgayDK.Enabled = dtpNgaySinh.Enabled = true;
            txtHoTen.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtSDT.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtEmail.Text.Trim() == "" )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "", MessageBoxButtons.OK);
                return;
            }
            else if (isDangGhi)
            {
                var U = new CarUser();
                U.GioiTinh = cmbGioiTinh.Text.ToString();
                U.HoTen = txtHoTen.Text.ToString().Trim();
                U.NgayDK = dtpNgayDK.Text.ToString();
                U.NgaySinh = dtpNgaySinh.Text.ToString();
                U.Email = txtEmail.Text.ToString().Trim();
                U.SDT = txtSDT.Text.ToString().Trim();
                U.TrangThai = Convert.ToInt32(cmbTT.Text.ToString());
                MessageBox.Show(U.ToString());
                _reponsitory.Add(U);
                MessageBox.Show("Thêm Thành Công", "", MessageBoxButtons.OK);
                isDangGhi = false;
            }
            else if (isDangSua)
            {
                var U = new CarUser();
                U.ID = Convert.ToInt32(txtID.Text.ToString());
                U.GioiTinh = cmbGioiTinh.Text.ToString();
                U.HoTen = txtHoTen.Text.ToString().Trim();
                U.NgayDK = dtpNgayDK.Text.ToString();
                U.NgaySinh = dtpNgaySinh.Text.ToString();
                U.Email = txtEmail.Text.ToString().Trim();
                U.SDT = txtSDT.Text.ToString().Trim();
                U.TrangThai = Convert.ToInt32(cmbTT.Text.ToString());
                _reponsitory.Update(U);
                MessageBox.Show("Sửa Thành Công", "", MessageBoxButtons.OK);
                isDangSua = false;
            }
        }

        private void gcUserCar_Click(object sender, EventArgs e)
        {
            //txtIDUser.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "IDUser").ToString().Trim();
            //txtID.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "ID").ToString().Trim();
            //txtIDLoai.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "IDLoai").ToString().Trim();
            //txtIDHang.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "IDHang").ToString().Trim();
            //txtSoXe.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "SoXe").ToString().Trim();
            //txtMauXe.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "MauXe").ToString().Trim();
            txtID.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "ID").ToString().Trim();
            txtHoTen.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "HoTen").ToString().Trim();
            txtEmail.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "Email").ToString().Trim();
            txtSDT.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "SDT").ToString().Trim();
            cmbGioiTinh.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "GioiTinh").ToString().Trim();
            cmbTT.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "TrangThai").ToString().Trim();
            dtpNgayDK.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "NgayDK").ToString().Trim();
            dtpNgaySinh.Text = gvUserCar.GetRowCellValue(gvUserCar.FocusedRowHandle, "NgaySinh").ToString().Trim();

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var listBSX = await _reponsitory.GetList();
            gcUserCar.DataSource = listBSX;

            txtID.Enabled = txtHoTen.Enabled = txtEmail.Enabled = txtSDT.Enabled =  false;
            cmbTT.Enabled = cmbGioiTinh.Enabled = false;
            dtpNgayDK.Enabled = dtpNgaySinh.Enabled = false;
        }
    }
}