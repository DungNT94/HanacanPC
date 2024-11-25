using HANACANPC;
using HANACANPC._00_Login;
using HANACANPC._04_Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardManagement.Forms
{
    public partial class frmLogin : Form
    {
        // Gọi kết nối
        SQLConnection objConnection = new SQLConnection();

        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Load form Login
        private void Login_Load(object sender, EventArgs e)
        {
            //Hàm xóa file trong thư mục export QR
            string directoryPath = Application.StartupPath + "//Export";// Đường dẫn đến thư mục
            try
            {
                // Lấy tất cả các tệp trong thư mục
                string[] files = Directory.GetFiles(directoryPath);

                foreach (string file in files)
                {
                    File.Delete(file); // Xóa từng tệp
                    Console.WriteLine($"Đã xóa tệp: {file}");
                }

                Console.WriteLine("Đã xóa tất cả các tệp trong thư mục.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPasswordLogin.Text))
            {
                MessageBox.Show("Vui lòng nhập password (please enter password).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Hàm check nhận data pass
                string Pass;
                string cmdText = "Select Password from Password";
                Pass = objConnection.ExcuteCommandReturnString(cmdText);

                //Login nếu pass tồn tại và nhập đúng pass
                if (!string.IsNullOrEmpty(Pass.Trim()))
                {
                    if (txtPasswordLogin.Text != Pass)
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu chính xác (please enter the correct password).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        frmMain FrmMain = new frmMain();
                        FrmMain.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu chưa được khai báo, vui lòng liên hệ quản trị viên (password has not been declared, please contact administrator).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Nhấn Icon vào setup
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmPassSetting frmPassSetting = new frmPassSetting();
            frmPassSetting.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtPasswordLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtPasswordLogin.Text))
                {
                    MessageBox.Show("Vui lòng nhập password (please enter password).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Hàm check nhận data pass
                    string Pass;
                    string cmdText = "Select Password from Password";
                    Pass = objConnection.ExcuteCommandReturnString(cmdText);

                    //Login nếu pass tồn tại và nhập đúng pass
                    if (!string.IsNullOrEmpty(Pass.Trim()))
                    {
                        if (txtPasswordLogin.Text != Pass)
                        {
                            MessageBox.Show("Vui lòng nhập mật khẩu chính xác (please enter the correct password).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            frmMain FrmMain = new frmMain();
                            FrmMain.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu chưa được khai báo, vui lòng liên hệ quản trị viên (password has not been declared, please contact administrator).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}
