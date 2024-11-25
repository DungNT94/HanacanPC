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
using static HANACANPC._03_Master.frmUserMaster;

namespace HANACANPC._03_Master
{
    public partial class frmUserMasterUPDATE : DevExpress.XtraEditors.XtraForm
    {
        public frmUserMasterUPDATE()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void frmUserMasterUPDATE_Load(object sender, EventArgs e)
        {
            UserFormStart();
        }

        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// 

        //Hàm load dữ liệu khi load form
        private void UserFormStart()
        {
            txtUserCode.Text = GloUserMaster.Code;
            txtUserName.Text = GloUserMaster.Name;
        }

        //Hàm Update bản ghi được chọn và sửa trên Grid Control
        private void UdateUserMaster()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                conn.Open();
                //SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "Update MasterUser set Name = N'" + txtUserName.Text + "'where Code = N'" + GloUserMaster.Code + "'";
                cmd2.ExecuteNonQuery();
                conn.Close();

                //Đóng form design update
                this.Close();
                //Thông báo cập nhật thành công
                MessageBox.Show("Mã " + txtUserCode.Text + " cập nhật thành công ( Code " + txtUserCode.Text + " updated successfully ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Nhấn Cancel, đóng popup update Location
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Nhấn Save để lưu thay đổi

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ tên người dùng( Please enter the full user name).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                UdateUserMaster();
            }
        }
    }
}