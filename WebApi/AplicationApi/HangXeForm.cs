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
    public partial class HangXeForm : DevExpress.XtraEditors.XtraForm
    {
        bool isDangGhi, isDangSua;
        HangXeReponsitoty _reponsitory = new HangXeReponsitoty();
        public HangXeForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangGhi = true;
            txtHang.Enabled = true;
            txtHang.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("vui lòng chọn row cần xóa", "", MessageBoxButtons.OK);
                return;
            }
            var HangXe = new HangXe();
            HangXe.ID = Convert.ToInt32(txtID.Text);
            _reponsitory.Delete(HangXe);
            MessageBox.Show("Đã Xóa", "", MessageBoxButtons.OK);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangSua = true;
            txtHang.Enabled = true;
            txtHang.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtHang.Text.Trim() == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "", MessageBoxButtons.OK);
                return;
            }
            else if (isDangGhi)
            {
                var HangXe = new HangXe();
                HangXe.Hang = txtHang.Text.ToString().Trim();
                _reponsitory.Add(HangXe);
                MessageBox.Show("Thêm Thành Công", "", MessageBoxButtons.OK);
                isDangGhi = false;
            }
            else if (isDangSua)
            {
                var HangXe = new HangXe();
                HangXe.ID = Convert.ToInt32(txtID.Text);
                HangXe.Hang = txtHang.Text.ToString().Trim();
                _reponsitory.Update(HangXe);
                MessageBox.Show("Sửa Thành Công", "", MessageBoxButtons.OK);
                isDangSua = false;
            }
        }

        private void gcHangXe_Click(object sender, EventArgs e)
        {
            txtHang.Text = gvHangXe.GetRowCellValue(gvHangXe.FocusedRowHandle, "Hang").ToString().Trim();
            txtID.Text = gvHangXe.GetRowCellValue(gvHangXe.FocusedRowHandle, "ID").ToString().Trim();

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var list = await _reponsitory.GetList();
            gcHangXe.DataSource = list;
        }
    }
}