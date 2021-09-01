namespace AplicationApi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bienSoLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label trangThaiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiuXeThang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcInfo = new System.Windows.Forms.GroupBox();
            this.cmbTT = new System.Windows.Forms.ComboBox();
            this.bdsBienSoXe = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.xeTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcBienSoXe = new DevExpress.XtraGrid.GridControl();
            this.gvBienSoXe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBienSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            bienSoLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            trangThaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBienSoXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBienSoXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBienSoXe)).BeginInit();
            this.SuspendLayout();
            // 
            // bienSoLabel
            // 
            bienSoLabel.AutoSize = true;
            bienSoLabel.Location = new System.Drawing.Point(207, 35);
            bienSoLabel.Name = "bienSoLabel";
            bienSoLabel.Size = new System.Drawing.Size(42, 13);
            bienSoLabel.TabIndex = 0;
            bienSoLabel.Text = "Biển Số";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(637, 37);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(35, 13);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Ngày ";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(32, 32);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(22, 13);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Location = new System.Drawing.Point(401, 36);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Size = new System.Drawing.Size(58, 13);
            trangThaiLabel.TabIndex = 6;
            trangThaiLabel.Text = "Trạng Thái";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnThoat,
            this.btnReload,
            this.btnGiuXeThang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(894, 158);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnGiuXeThang
            // 
            this.btnGiuXeThang.Caption = "Giữ Xe Tháng";
            this.btnGiuXeThang.Id = 7;
            this.btnGiuXeThang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiuXeThang.ImageOptions.SvgImage")));
            this.btnGiuXeThang.Name = "btnGiuXeThang";
            this.btnGiuXeThang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiuXeThang_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Giữ Xe Ngày";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReload);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGiuXeThang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(trangThaiLabel);
            this.gcInfo.Controls.Add(this.cmbTT);
            this.gcInfo.Controls.Add(iDLabel);
            this.gcInfo.Controls.Add(this.txtID);
            this.gcInfo.Controls.Add(dateLabel);
            this.gcInfo.Controls.Add(this.dtpNgay);
            this.gcInfo.Controls.Add(bienSoLabel);
            this.gcInfo.Controls.Add(this.txtBienSo);
            this.gcInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcInfo.Location = new System.Drawing.Point(0, 467);
            this.gcInfo.Name = "gcInfo";
            this.gcInfo.Size = new System.Drawing.Size(894, 489);
            this.gcInfo.TabIndex = 5;
            this.gcInfo.TabStop = false;
            // 
            // cmbTT
            // 
            this.cmbTT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBienSoXe, "TrangThai", true));
            this.cmbTT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBienSoXe, "TrangThai", true));
            this.cmbTT.FormattingEnabled = true;
            this.cmbTT.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbTT.Location = new System.Drawing.Point(469, 33);
            this.cmbTT.Name = "cmbTT";
            this.cmbTT.Size = new System.Drawing.Size(121, 21);
            this.cmbTT.TabIndex = 7;
            // 
            // bdsBienSoXe
            // 
            this.bdsBienSoXe.DataSource = typeof(WebApi.Models.BienSoXe);
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBienSoXe, "ID", true));
            this.txtID.Location = new System.Drawing.Point(60, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 5;
            // 
            // dtpNgay
            // 
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBienSoXe, "date", true));
            this.dtpNgay.EditValue = null;
            this.dtpNgay.Location = new System.Drawing.Point(676, 34);
            this.dtpNgay.MenuManager = this.ribbonControl1;
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpNgay.TabIndex = 3;
            // 
            // txtBienSo
            // 
            this.txtBienSo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBienSoXe, "BienSo", true));
            this.txtBienSo.Location = new System.Drawing.Point(259, 32);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(100, 21);
            this.txtBienSo.TabIndex = 1;
            // 
            // xeTheoNgayBindingSource
            // 
            this.xeTheoNgayBindingSource.DataSource = typeof(WebApi.Models.XeTheoNgay);
            // 
            // gcBienSoXe
            // 
            this.gcBienSoXe.DataSource = this.xeTheoNgayBindingSource;
            this.gcBienSoXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBienSoXe.Location = new System.Drawing.Point(0, 158);
            this.gcBienSoXe.MainView = this.gvBienSoXe;
            this.gcBienSoXe.MenuManager = this.ribbonControl1;
            this.gcBienSoXe.Name = "gcBienSoXe";
            this.gcBienSoXe.Size = new System.Drawing.Size(894, 309);
            this.gcBienSoXe.TabIndex = 9;
            this.gcBienSoXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBienSoXe});
            this.gcBienSoXe.Click += new System.EventHandler(this.gcBienSoXe_Click_1);
            // 
            // gvBienSoXe
            // 
            this.gvBienSoXe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colBienSo,
            this.colThoiGian,
            this.colTrangThai});
            this.gvBienSoXe.GridControl = this.gcBienSoXe;
            this.gvBienSoXe.Name = "gvBienSoXe";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colBienSo
            // 
            this.colBienSo.Caption = "Biển Số";
            this.colBienSo.FieldName = "BienSo";
            this.colBienSo.Name = "colBienSo";
            this.colBienSo.Visible = true;
            this.colBienSo.VisibleIndex = 1;
            // 
            // colThoiGian
            // 
            this.colThoiGian.Caption = "Thời Gian";
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 2;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(911, 605);
            this.Controls.Add(this.gcBienSoXe);
            this.Controls.Add(this.gcInfo);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBienSoXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBienSoXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBienSoXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private System.Windows.Forms.GroupBox gcInfo;
        private System.Windows.Forms.BindingSource bdsBienSoXe;
		private System.Windows.Forms.ComboBox cmbTT;
		private System.Windows.Forms.TextBox txtID;
		private DevExpress.XtraEditors.DateEdit dtpNgay;
		private System.Windows.Forms.TextBox txtBienSo;
        private DevExpress.XtraBars.BarButtonItem btnGiuXeThang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource xeTheoNgayBindingSource;
        private DevExpress.XtraGrid.GridControl gcBienSoXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBienSoXe;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBienSo;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
    }
}

