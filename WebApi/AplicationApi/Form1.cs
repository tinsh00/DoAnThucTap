using AplicationApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicationApi
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
		bool isDangGhi, isDangSua;
        XeTheoNgayReponsitory _reponsitory = new XeTheoNgayReponsitory();
        public Form1()
        {
            InitializeComponent();
            LoadData();

			txtID.Enabled = txtBienSo.Enabled = cmbTT.Enabled = dtpNgay.Enabled = false;
        }

        private async void LoadData()
        {
            var listBSX = await _reponsitory.GetList();
            gcBienSoXe.DataSource = listBSX;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			isDangGhi = true;
			txtBienSo.Text = "";
			txtBienSo.Enabled = cmbTT.Enabled =dtpNgay.Enabled= true;
			txtBienSo.Focus();
        }

		private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			isDangSua = true;
			txtBienSo.Enabled = cmbTT.Enabled = dtpNgay.Enabled=true;
			txtBienSo.Focus();
		}

		private void gcBienSoXe_Click(object sender, EventArgs e)
		{
			//FormDSDK.maLop = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "MALOP").ToString().Trim();
			txtBienSo.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "BienSo").ToString().Trim();
			txtID.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "ID").ToString().Trim();
            cmbTT.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "TrangThai").ToString().Trim();
            dtpNgay.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "ThoiGian").ToString().Trim();
        }

		private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var bsx = new XeTheoNgay();
			bsx.ID = Convert.ToInt32(gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "ID").ToString().Trim());
			_reponsitory.Delete(bsx);
			MessageBox.Show("Đã Xóa", "", MessageBoxButtons.OK);

		}

        private void btnGiuXeThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            FormMain frm = new FormMain();
            frm.Activate();
            frm.Show();

            this.Hide();

            
        }

        private void gcBienSoXe_Click_1(object sender, EventArgs e)
        {
            //FormDSDK.maLop = gvLop.GetRowCellValue(gvLop.FocusedRowHandle, "MALOP").ToString().Trim();
            txtBienSo.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "BienSo").ToString().Trim();
            txtID.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "ID").ToString().Trim();
            cmbTT.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "TrangThai").ToString().Trim();
            dtpNgay.Text = gvBienSoXe.GetRowCellValue(gvBienSoXe.FocusedRowHandle, "ThoiGian").ToString().Trim();

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(txtBienSo.Text=="" && cmbTT.SelectedText=="")
			{
				MessageBox.Show("Hãy nhập đầy đủ thông tin","",MessageBoxButtons.OK);
				return;
			}
			else if(isDangGhi)
			{
				var bsx = new XeTheoNgay();
				bsx.BienSo = txtBienSo.Text.ToString().Trim();
				bsx.TrangThai = Convert.ToInt32(cmbTT.Text.ToString());
                bsx.ThoiGian = dtpNgay.Text.ToString();
                _reponsitory.Add(bsx);
				MessageBox.Show("Thêm Thành Công", "", MessageBoxButtons.OK);
				isDangGhi = false;
			}
			else if(isDangSua)
			{
				var bsx = new XeTheoNgay();
				bsx.BienSo = txtBienSo.Text.ToString().Trim();;
				bsx.ID = Convert.ToInt32(txtID.Text.ToString().Trim());
				bsx.TrangThai = Convert.ToInt32(cmbTT.Text.ToString());
                bsx.ThoiGian = dtpNgay.Text.ToString();
                _reponsitory.Update(bsx);
				MessageBox.Show("Sửa Thành Công", "", MessageBoxButtons.OK);
				isDangSua = false;
			}
		}
	}
}
