using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANACANPC._04_Setting
{
    public partial class frmSystemSetting : DevExpress.XtraEditors.XtraForm
    {
        private Form parentForm; // Biến để lưu trữ tham chiếu form cha
        private string parentFormName;// Biến để lưu trữ tham chiếu Tên form cha
        public frmSystemSetting(Form parent,bool ShowButton, string parentName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            parentForm = parent; // Lưu tham chiếu đến form cha
            parentFormName = parentName;
            btnSave.Visible = ShowButton;
            btnExit.Visible= ShowButton;

        }
        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //Hàm thay đổi PassLogin
        private void SavePassLogin()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                if (!string.IsNullOrEmpty(txtPassLogin.Text))
                {
                    cmd.CommandText = "update Password set Password = N'" + txtPassLogin.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập password (please enter password).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm thay đổi Thông tin kết nối Database
        private void SaveDataConfig()
        {
            bool ok1 = FileConfig.WriteConfig(txtServerName.Text.Trim(), txtDatabaseName.Text.Trim(), txtUserDB.Text.Trim(), txtPassDB.Text.Trim());
            if (ok1)
            {
                MessageBox.Show("Save sucessfully");
                return;
            }

            MessageBox.Show("Save error!!!!");
            
        }

        //Test connection Database
        private void btnTestConnectDB_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "server=" + txtServerName.Text + "; database=" + txtDatabaseName.Text + ";User Id=" + txtUserDB.Text + ";pwd=" + txtPassDB.Text + ";Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Connect succesfully");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Kết nối không thành công, vui lòng thay đổi kết nối Thông tin cơ sở dữ liệu (Connection Fail, Please change connection Database information)");
            }
            finally
            {
                conn.Close();
            }
        }

        //Load mở form setting 
        private void frmSystemSetting_Load(object sender, EventArgs e)
        {

            if (FileConfig.ReadSqlConfig())
            {
                txtServerName.Text = GlobalVariables.ServerName;
                txtUserDB.Text = GlobalVariables.UserDB;
                txtPassDB.Text = GlobalVariables.PassDB;
                txtDatabaseName.Text = GlobalVariables.DatabaseName;
            }
            if (FileConfig.ReadPassLoginConfig())
            {
                txtPassLogin.Text = GlobalVariables.PassLogin;
            }
            else
            {
                txtPassLogin.Text = "";
            }
        }

        //Nhấn exit đóng form, form passSetting cũng đóng luôn
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Đóng form cha
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        //Nhấn nút 'X' đóng form, form passSetting cũng đóng luôn
        private void frmSystemSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Đóng form cha
            if (parentForm != null && parentFormName == "LoginForm")
            {
                parentForm.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDataConfig();
                if (FileConfig.ReadSqlConfig())
                {
                    SavePassLogin();
                    txtServerName.Text = GlobalVariables.ServerName;
                    txtUserDB.Text = GlobalVariables.UserDB;
                    txtPassDB.Text = GlobalVariables.PassDB;
                    txtDatabaseName.Text = GlobalVariables.DatabaseName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if (FileConfig.ReadPassLoginConfig())
            //{
            //    txtPassLogin.Text = GlobalVariables.PassLogin;
            //}
        }

        private void txtPassLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ cái, số và các ký tự đặc biệt bên dưới
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '!' && e.KeyChar != '@' && e.KeyChar != '#' && e.KeyChar != '$' && e.KeyChar != '%' && e.KeyChar != '&' && e.KeyChar != '*' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được thêm vào TextBox
            }

        }
    }
}