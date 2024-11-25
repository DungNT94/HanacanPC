using DevExpress.XtraBars;
using HANACANPC._01_LogData;
using HANACANPC._02_Print;
using HANACANPC._03_Master;
using HANACANPC._04_Setting;
using StandardManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANACANPC._00_Login
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        //Hàm kiểm tra xem có form con đang được mở không

        //Hàm mở form System tách ra do cần truyền tham số chính xác là This
        private void OpenMdiformSystem(Type typeform)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeform)
                {
                    frm.Activate();
                    return;
                }
            }

            Form f;

            // Kiểm tra nếu form là frmSystemSetting thì khởi tạo với tham số form cha
            if (typeform == typeof(frmSystemSetting))
            {
                f = new frmSystemSetting(this,false, "Mainform"); // Truyền form hiện tại (this) làm form cha
            }
            else
            {
                f = (Form)Activator.CreateInstance(typeform); // Cho các form khác không cần tham số
            }

            f.MdiParent = this;
            f.Show();
        }

        //Mở form CheckingWorkProgress sau khi click
        private void barBtnWorkProgress_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMdiformSystem(typeof(frmWorkProgress));
        }

        //Mở form CompensationLogData sau khi click
        private void barBtnCompensationLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMdiformSystem(typeof(frmCompensationLog));
        }

        //Mở form ResortingLogData sau khi click
        private void barBtnResortingLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMdiformSystem(typeof(frmResortingLog));
        }

        //Mở form PrintQR sau khi click
        private void barBtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMdiformSystem(typeof(frmPrintQR));
        }

        //Mở form MasterMaintenance sau khi click
        private void barBtnMasterMaintenance_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMdiformSystem(typeof(frmMasterMaintenance));
        }

        //Mở form SystemSetting sau khi click
        private void barBtnSystemSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMdiformSystem(typeof(frmSystemSetting));
        }

        //Biến flag đánh dấu nếu nhấn vào logOut thì không đóng Application.Exit khi FormClosed
        int flag = 0;
        private void barBtnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            flag = 1;
            this.Close();
        }

        //Load form mặc định hiển thị Checking work progress
        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenMdiformSystem(typeof(frmWorkProgress));
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag == 0)
            {
                Application.Exit();
            }
            
        }
    }
}