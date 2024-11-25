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
using static HANACANPC._03_Master.frmLocationMaster;

namespace HANACANPC._03_Master
{
    public partial class frmLocationMasterUPDATE : DevExpress.XtraEditors.XtraForm
    {
        public frmLocationMasterUPDATE()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmLocationMasterUPDATE_Load(object sender, EventArgs e)
        {
            LocationFormStart();
        }

        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// 

        //Hàm load dữ liệu khi load form
        private void LocationFormStart()
        {
            txtManagementCode.Text = GloUserMaster.MCode;
            txtLocationName.Text = GloUserMaster.LName;
            txtSecurityBoxIP.Text = GloUserMaster.SAddress;
            if (GloUserMaster.TierType == "000100000006010603E8000A")
            {
                rdoTwoTier.Checked = true;
            }
            else if (GloUserMaster.TierType == "00010000000601060000000A")
            {
                rdoOneTier.Checked = true;
            }
            else
            {
                rdoOneTier.Checked = false;
                rdoTwoTier.Checked = false;
            }
        }

        //Hàm Update bản ghi được chọn và sửa trên Grid Control
        string UpdateTierType;
        private void UdateLocationMaster()
        {
            //Gắn dữ liệu sau khi check radio tầng
            if (rdoTwoTier.Checked == true)
            {
                UpdateTierType = "000100000006010603E8000A";
            }
            else if (rdoOneTier.Checked == true)
            {
                UpdateTierType = "00010000000601060000000A";
            }
            else
            {
                UpdateTierType = "";
            }

            //Vào hàm insert
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                conn.Open();
                //SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "Update MasterCase set Location = N'" + txtLocationName.Text + "',SecurityAddress = N'" + txtSecurityBoxIP.Text + "',TierType = N'" + UpdateTierType + "' where Code = N'" + GloUserMaster.MCode + "'";
                cmd2.ExecuteNonQuery();
                conn.Close();

                //Đóng form design update
                this.Close();
                //Thông báo cập nhật thành công
                MessageBox.Show("Mã " + txtManagementCode.Text + " cập nhật thành công ( Code " + txtManagementCode.Text + " updated successfully ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocationName.Text) || string.IsNullOrEmpty(txtSecurityBoxIP.Text) || (rdoOneTier.Checked == false && rdoTwoTier.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đủ tên location, địa chỉ box và Loại tầng ( Please enter the full location name, box IP address and Tier type ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                UdateLocationMaster();            
            }
        }
    }
}