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
    public partial class XeForm : DevExpress.XtraEditors.XtraForm
    {
        bool isDangGhi, isDangSua;
        XeReponsitoty _reponsitory = new XeReponsitoty();
        CarUserReponsitoty _reponsitoryCarUser = new CarUserReponsitoty();
        HangXeReponsitoty _reponsitoryHang = new HangXeReponsitoty();
        LoaiXeReponsitoty _reponsitoryLoai = new LoaiXeReponsitoty();
        public XeForm()
        {
            InitializeComponent();
            LoadData();
            gcHienThi.Visible = false;
            btnUser.Enabled = btnLoai.Enabled = btnHang.Enabled = false;
            txtID.ReadOnly = txtMauXe.Enabled = txtSoXe.Enabled = false;
            txtIDLoai.ReadOnly = txtIDHang.ReadOnly = txtIDUser.ReadOnly = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtIDLoai.ReadOnly = txtIDHang.ReadOnly = txtIDUser.ReadOnly = false;
            btnUser.Enabled = btnLoai.Enabled = btnHang.Enabled = true;
            isDangGhi = true;
            txtSoXe.Enabled =txtMauXe.Enabled= true;
            txtSoXe.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("vui lòng chọn row cần xóa", "", MessageBoxButtons.OK);
                return;
            }
            var xe = new Xe();
            xe.ID = Convert.ToInt32(txtID.Text);
            _reponsitory.Delete(xe);
            MessageBox.Show("Đã Xóa", "", MessageBoxButtons.OK);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtIDLoai.ReadOnly = txtIDHang.ReadOnly = txtIDUser.ReadOnly = false;
            btnUser.Enabled = btnLoai.Enabled = btnHang.Enabled = true;
            isDangSua = true;
            txtSoXe.Enabled =txtMauXe.Enabled= true;
            txtSoXe.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtIDUser.Text.Trim() == "" || txtIDLoai.Text.Trim()==""|| txtIDHang.Text.Trim() == ""|| txtSoXe.Text.Trim() == ""|| txtMauXe.Text.Trim() == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "", MessageBoxButtons.OK);
                return;
            }
            else if (isDangGhi)
            {
                var xe = new Xe();
                xe.IDUser = Convert.ToInt32(txtIDUser.Text.ToString().Trim());
                xe.IDHang = Convert.ToInt32(txtIDHang.Text.ToString().Trim());
                xe.IDLoai = Convert.ToInt32(txtIDLoai.Text.ToString().Trim());
                xe.SoXe = txtSoXe.Text.ToString().Trim();
                xe.MauXe = txtMauXe.Text.ToString().Trim();
                _reponsitory.Add(xe);
                MessageBox.Show("Thêm Thành Công", "", MessageBoxButtons.OK);
                isDangGhi = false;
            }
            else if (isDangSua)
            {
                var xe = new Xe();
                xe.ID = Convert.ToInt32(txtID.Text.ToString().Trim());
                xe.IDUser = Convert.ToInt32(txtIDUser.Text.ToString().Trim());
                xe.IDHang = Convert.ToInt32(txtIDHang.Text.ToString().Trim());
                xe.IDLoai = Convert.ToInt32(txtIDLoai.Text.ToString().Trim());
                xe.SoXe = txtSoXe.Text.ToString().Trim();
                xe.MauXe = txtMauXe.Text.ToString().Trim();
                _reponsitory.Update(xe);
                MessageBox.Show("Sửa Thành Công", "", MessageBoxButtons.OK);
                isDangSua = false;
            }
        }

        private void gcXe_Click(object sender, EventArgs e)
        {
            txtIDUser.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "IDUser").ToString().Trim();
            txtID.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "ID").ToString().Trim();
            txtIDLoai.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "IDLoai").ToString().Trim();
            txtIDHang.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "IDHang").ToString().Trim();
            txtSoXe.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "SoXe").ToString().Trim();
            txtMauXe.Text = gvXe.GetRowCellValue(gvXe.FocusedRowHandle, "MauXe").ToString().Trim();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            gcHienThi.Visible = true;
            gcHangXe.Visible = true;
            gcLoaiXe.Visible = false;
            gcCarUser.Visible = false;
            gcHangXe.Dock = DockStyle.Fill;
        }

        private void gcHangXe_Click(object sender, EventArgs e)
        {
            txtIDHang.Text = gvHangXe.GetRowCellValue(gvHangXe.FocusedRowHandle, "ID").ToString().Trim();
        }

        private void gcLoaiXe_Click(object sender, EventArgs e)
        {
            txtIDLoai.Text = gvLoaiXe.GetRowCellValue(gvLoaiXe.FocusedRowHandle, "ID").ToString().Trim();

        }

        private void gcCarUser_Click(object sender, EventArgs e)
        {
            txtIDUser.Text = gvCarUser.GetRowCellValue(gvCarUser.FocusedRowHandle, "ID").ToString().Trim();

        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            gcHienThi.Visible = true;
            gcHangXe.Visible = false;
            gcLoaiXe.Visible = true;
            gcCarUser.Visible = false;
            gcLoaiXe.Dock = DockStyle.Fill;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            gcHienThi.Visible = true;
            gcHangXe.Visible = false;
            gcLoaiXe.Visible = false;
            gcCarUser.Visible = true;
            gcCarUser.Dock = DockStyle.Fill;
        }

        private async void LoadData()
        {
            var list = await _reponsitory.GetList();
            var listU = await _reponsitoryCarUser.GetList();
            var listH = await _reponsitoryHang.GetList();
            var listL = await _reponsitoryLoai.GetList();

            gcXe.DataSource = list;
            gcHangXe.DataSource = listH;
            gcLoaiXe.DataSource = listL;
            gcCarUser.DataSource = listU;

        }
    }
}