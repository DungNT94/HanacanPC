using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANACANPC._03_Master
{
    public partial class frmMasterMaintenance : DevExpress.XtraEditors.XtraForm
    {
        public frmMasterMaintenance()
        {
            InitializeComponent();
        }

        //Hàm kiểm tra xem có form con đang được mở không
        private void OpenMdiform(Type typeform)
        {
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm.GetType() == typeform)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeform);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        //Mở form UserMaster sau khi click
        private void btnUserMaster_Click(object sender, EventArgs e)
        {
            OpenMdiform(typeof(frmUserMaster));
            this.Close();
        }

        //Mở form DesignMaster sau khi click
        private void btnDesignMaster_Click(object sender, EventArgs e)
        {
            OpenMdiform(typeof(frmDesignMaster));
            this.Close();
        }

        //Mở form LocationMaster sau khi click
        private void btnLocationMaster_Click(object sender, EventArgs e)
        {
            OpenMdiform(typeof(frmLocationMaster));
            this.Close();
        }
    }
}