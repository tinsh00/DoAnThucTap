using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace AplicationApi
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(UserForm));
            if (frm != null) frm.Activate();
            else
            {
                UserForm f = new UserForm();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnLoaiXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(LoaiXeForm));
            if (frm != null) frm.Activate();
            else
            {
                LoaiXeForm f = new LoaiXeForm();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnHangXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(HangXeForm));
            if (frm != null) frm.Activate();
            else
            {
                HangXeForm f = new HangXeForm();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(XeForm));
            if (frm != null) frm.Activate();
            else
            {
                XeForm f = new XeForm();
                f.MdiParent = this;
                f.Show();

            }
        }
    }
}