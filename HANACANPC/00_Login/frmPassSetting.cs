using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HANACANPC._04_Setting;
using System.Windows.Forms;

namespace HANACANPC._00_Login
{
    public partial class frmPassSetting : DevExpress.XtraEditors.XtraForm
    {
        public frmPassSetting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (FileConfig.ReadPassConfig())
            {
                if (txtPassSetting.Text == GlobalVariables.PassOpenSetting)
                {
                    frmSystemSetting frmSystemSetting = new frmSystemSetting(this,true,"LoginForm");
                    frmSystemSetting.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu chính xác (please enter the correct password).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
        }

        private void frmPassSetting_Load(object sender, EventArgs e)
        {
            txtPassSetting.Select();
        }

        private void txtPassSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FileConfig.ReadPassConfig())
                {
                    if (txtPassSetting.Text == GlobalVariables.PassOpenSetting)
                    {
                        frmSystemSetting frmSystemSetting = new frmSystemSetting(this, true, "LoginForm");
                        frmSystemSetting.ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu chính xác (please enter the correct password).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
               
        }
    }
}