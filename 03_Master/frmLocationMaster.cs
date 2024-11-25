using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace HANACANPC._03_Master
{
    public partial class frmLocationMaster : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        // Biến public
        public static class GloUserMaster
        {
            public static String MCode;
            public static String LName;
            public static String SAddress;
            public static String TierType;
        }
        public frmLocationMaster()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmLocationMaster_Load(object sender, EventArgs e)
        {
            ShowLocationMaster();
            //Tăng chiều rộng cột STT
            gridView1.IndicatorWidth = 40; 
            gridView1.ClearSelection();
        }

        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// 
        //Hàm reset trường trên form UserMaster
        private void ResetLocationForm()
        {
            txtManagementCode.Text = "";
            txtLocationName.Text = "";
            txtSecurityAddress.Text = "";
            rdoTwoTier.Checked = false;
            rdoOneTier.Checked = false;
        }

        // Hàm hiển thị dữ liệu Location/Drawer/Case trên gridControl
        private void ShowLocationMaster()
        {

            string query = "select * from MasterCase";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl1.DataSource = dttb;

        }

        //Thêm Cột Đánh STT tự động
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicator(e);
            
        }

        //Hàm lấy dữ liệu sau khi click cell
        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            GloUserMaster.MCode = gridView1.GetFocusedRowCellValue("Code").ToString().Trim();
            txtManagementCode.Text = GloUserMaster.MCode;

            GloUserMaster.LName = gridView1.GetFocusedRowCellValue("Location").ToString();
            txtLocationName.Text = GloUserMaster.LName;

            GloUserMaster.SAddress = gridView1.GetFocusedRowCellValue("SecurityAddress").ToString();
            txtSecurityAddress.Text = GloUserMaster.SAddress;

            GloUserMaster.TierType = gridView1.GetFocusedRowCellValue("TierType").ToString();
            if(GloUserMaster.TierType== "000100000006010603E8000A")
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
        private void UdateUser()
        {
            int[] SelectRows = gridView1.GetSelectedRows();
            if (SelectRows.Length == 1)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    if (txtManagementCode.Text != GloUserMaster.MCode)
                    {
                        MessageBox.Show("Vui lòng không chỉnh sửa mã quản lý ( Please do not edit the management code ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        cmd2.Connection = conn;
                        cmd2.CommandText = "Update MasterCase set Location = N'" + txtLocationName.Text + "',SecurityAddress= N'" + txtSecurityAddress.Text + "' where Code = N'" + GloUserMaster.MCode + "'";
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        ResetLocationForm();
                        ShowLocationMaster();
                        gridView1.ClearSelection();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một mã để cập nhật ( Please select only one code to update ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridView1.ClearSelection();
                return;
            }

        }

        //Hàm xóa bản ghi được chọn trên Grid Control
        private void DleteLocation()
        {
            //Tạo mảng chỉ số các dòng được chọn trong GridView
            int[] SelectRows = gridView1.GetSelectedRows();

            //Khai báo List UserCodes ứng với các dòng được chọn
            List<string> UserCodes = new List<string>();

            //Vòng duyệt các chỉ số trong mảng chỉ số được chọn
            foreach (int RowIndex in SelectRows)
            {
                //Lấy giá trị Usercode ứng với chỉ số dòng chọn
                var UserCode = gridView1.GetRowCellValue(RowIndex, "Code").ToString().Trim();

                //Thêm giá trị dòng vào List UserCodes
                UserCodes.Add("N'" + UserCode + "'");
            }

            //Tạo lại định dạng list ngăn cách nhau bằng dấu phẩy
            string Codes = "";
            UserCodes.ToList().ForEach(k => Codes += k + ",");
            // Loại bỏ dấu phẩy cuối cùng
            Codes = Codes.Trim(',');

            if (Codes != "")
            {
                DialogResult dialog = MessageBox.Show("Có chắc chắn muốn xóa người dùng đã chọn? ( Are you sure you want to delete the selected user? ).", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                        SqlCommand cmd2 = new SqlCommand();
                        conn.Open();
                        cmd2.Connection = conn;
                        cmd2.CommandText = "Delete from MasterCase where Code IN (" + Codes + ")";
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        ResetLocationForm();
                        ShowLocationMaster();
                        gridView1.ClearSelection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng click chọn mã cần xóa (Please select the code to delete).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

               
        }

        //Check tồn tại bản ghi và insert
        string IsertTierType;

        private void CheckInsert()
        {
            //Gắn dữ liệu sau khi check radio tầng
            if (rdoTwoTier.Checked == true)
            {
                IsertTierType = "000100000006010603E8000A";
            }
            else if (rdoOneTier.Checked == true)
            {
                IsertTierType = "00010000000601060000000A";
            }
            else
            {
                IsertTierType = "";
            }

            //vào hàm insert
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                conn.Open();
                cmd1.Connection = conn;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "MasterCaseP";
                cmd1.Parameters.AddWithValue("@MCode", txtManagementCode.Text);
                object rs = cmd1.ExecuteScalar();
                int kq = Convert.ToInt32(rs);
                if (kq == 1)
                {
                    MessageBox.Show("Mã quản lý đã tồn tại ( management code already exists ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }
                else
                {
                    cmd2.Connection = conn;
                    cmd2.CommandText = "insert into MasterCase (Code,Location,SecurityAddress,TierType) values (N'" + txtManagementCode.Text + "', N'" + txtLocationName.Text + "', N'" + txtSecurityAddress.Text + "',N'"+ IsertTierType + "')";
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    ResetLocationForm();
                    ShowLocationMaster();
                    gridView1.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Sự kiện nhập khác ký tự cho phép
        private void txtManagementCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ cái, số và dấu gạch dưới
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được thêm vào TextBox
            }
        }

        //Nhấn Add để insert bản ghi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManagementCode.Text) || string.IsNullOrEmpty(txtLocationName.Text) || string.IsNullOrEmpty(txtSecurityAddress.Text)||(rdoOneTier.Checked==false && rdoTwoTier.Checked==false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường thông tin ( please fill in all information fields ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Check vượt quá số ký tự cho phép
                if (txtManagementCode.Text.Length > 9)
                {
                    MessageBox.Show("Vui lòng nhập tối đa 9 ký tự chữ hoặc số ( please enter up to 10 alphanumeric characters ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    CheckInsert();
                }

            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            int[] SelectRows = gridView1.GetSelectedRows();
            if (SelectRows.Length == 1)
            {
                frmLocationMasterUPDATE frmLocationMasterUPDATE = new frmLocationMasterUPDATE();
                frmLocationMasterUPDATE.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã để nhấn cập nhật ( Please select one code to update ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridView1.ClearSelection();
                ResetLocationForm();
                return;
            }
            ShowLocationMaster();
            ResetLocationForm();
            ////Check phải chọn bản ghi mới được update
            //if (gridView1.SelectedRowsCount > 0)
            //{
            //    //Check null trường name và update
            //    if (string.IsNullOrEmpty(txtManagementCode.Text) || string.IsNullOrEmpty(txtLocationName.Text) || string.IsNullOrEmpty(txtSecurityAddress.Text))
            //    {
            //        MessageBox.Show("Vui lòng nhập đầy đủ các trường thông tin ( please fill in all information fields ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    else
            //    {
            //        UdateUser();
            //    }
            //}
            //else
            //{
            //    return;
            //}
        }

        //Nhấn để Delete Người dùng
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DleteLocation();
        }

        //Nhấn nút Refresh để load dữ liệu form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowLocationMaster();
            //Tăng chiều rộng cột STT
            gridView1.IndicatorWidth = 40;
            gridView1.ClearSelection();
        }
    }
}