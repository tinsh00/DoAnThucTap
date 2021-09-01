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
    public partial class LoaiXeForm : DevExpress.XtraEditors.XtraForm
    {
        bool isDangGhi, isDangSua;
        LoaiXeReponsitoty _reponsitory = new LoaiXeReponsitoty();
        public LoaiXeForm()
        {
            InitializeComponent();
            LoadData();
            txtID.Enabled = txtLoai.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangGhi = true;
            txtLoai.Enabled = true;
            txtLoai.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("vui lòng chọn row cần xóa", "", MessageBoxButtons.OK);
                return;
            }
            var LoaiXe = new LoaiXe();
            LoaiXe.ID = Convert.ToInt32(txtID.Text);
            _reponsitory.Delete(LoaiXe);
            MessageBox.Show("Đã Xóa", "", MessageBoxButtons.OK);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangSua = true;
            txtLoai.Enabled = true;
            txtLoai.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtLoai.Text.Trim() == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "", MessageBoxButtons.OK);
                return;
            }
            else if (isDangGhi)
            {
                var LoaiXe = new LoaiXe();
                LoaiXe.Loai = txtLoai.Text.ToString().Trim();
                _reponsitory.Add(LoaiXe);
                MessageBox.Show("Thêm Thành Công", "", MessageBoxButtons.OK);
                isDangGhi = false;
            }
            else if (isDangSua)
            {
                var LoaiXe = new LoaiXe();
                LoaiXe.ID = Convert.ToInt32(txtID.Text);
                LoaiXe.Loai = txtLoai.Text.ToString().Trim();
                _reponsitory.Update(LoaiXe);
                MessageBox.Show("Sửa Thành Công", "", MessageBoxButtons.OK);
                isDangSua = false;
            }
        }

        private void gcLoaiXe_Click(object sender, EventArgs e)
        {
            txtLoai.Text = gvLoaiXe.GetRowCellValue(gvLoaiXe.FocusedRowHandle, "Loai").ToString().Trim();
            txtID.Text = gvLoaiXe.GetRowCellValue(gvLoaiXe.FocusedRowHandle, "ID").ToString().Trim();

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void txtLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private async void LoadData()
        {
            var list = await _reponsitory.GetList();
            gcLoaiXe.DataSource = list;
        }
    }
}