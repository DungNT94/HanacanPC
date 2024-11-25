using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using NSubstitute.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace HANACANPC._03_Master
{
    public partial class frmUserMaster : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        // Biến public
        public static class GloUserMaster
        {
            public static String Code;
            public static String Name;
        }
        public frmUserMaster()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmUserMaster_Load(object sender, EventArgs e)
        {
            ShowUser();
            //Tăng chiều rộng cột STT
            gridView1.IndicatorWidth = 40; 
            gridView1.ClearSelection();
        }

        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// 
        //Hàm reset trường trên form UserMaster
        private void ResetUserForm()
        {
            txtUserCode.Text = "";
            txtUserName.Text = "";
        }

        // Hàm hiển thị dữ liệu User trên gridControl
        private void ShowUser()
        {

            string query = "select * from MasterUser";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl1.DataSource = dttb;

        }


        //Thêm Cột Đánh STT tự động
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicator(e);
            
        }

        //Hàm lấy dữ liệu sau khi click cell
        private void gridControl1_Click(object sender, EventArgs e)
        {
            GloUserMaster.Code = gridView1.GetFocusedRowCellValue("Code").ToString().Trim();
            txtUserCode.Text = GloUserMaster.Code;

            GloUserMaster.Name = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtUserName.Text = GloUserMaster.Name;
        }

        //Hàm Update bản ghi được chọn và sửa trên Grid Control
        private void UdateUser()
        {
            int [] SelectRows = gridView1.GetSelectedRows();
            if (SelectRows.Length == 1)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    if (txtUserCode.Text != GloUserMaster.Code)
                    {
                        MessageBox.Show("Vui lòng không chỉnh sửa mã người dùng ( Please do not edit the user code ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        cmd2.Connection = conn;
                        cmd2.CommandText = "Update MasterUser set Name = N'" + txtUserName.Text + "' where Code = N'" + GloUserMaster.Code + "'";
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        ResetUserForm();
                        ShowUser();
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
                MessageBox.Show("Vui lòng chỉ chọn một mã người dùng để cập nhật ( Please select only one user code to update ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridView1.ClearSelection();
                return;
            }
            
        }

        //Hàm xóa bản ghi được chọn trên Grid Control

        private void DleteUser()
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
                UserCodes.Add("N'"+UserCode+"'");
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
                        cmd2.CommandText = "Delete from MasterUser where Code IN (" + Codes + ")";
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        ResetUserForm();
                        ShowUser();
                        gridView1.ClearSelection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn mã cần xóa (Please select the code to delete).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        //Check tồn tại bản ghi và insert
        private void CheckInsert()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                conn.Open();
                cmd1.Connection = conn;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "MasterUserr";
                cmd1.Parameters.AddWithValue("@UserCode", txtUserCode.Text);
                object rs = cmd1.ExecuteScalar();
                int kq = Convert.ToInt32(rs);
                //int code = Convert.ToInt32(rs);

                if (kq == 1)
                {
                    MessageBox.Show("Mã user đã tồn tại ( user code already exists ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }
                else
                {
                    cmd2.Connection = conn;
                    cmd2.CommandText = "insert into MasterUser (Code,Name) values (N'" + txtUserCode.Text + "', N'" + txtUserName.Text + "')";
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    ResetUserForm();
                    ShowUser();
                    gridView1.ClearSelection();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Sự kiện nhập khác ký tự cho phép
        private void txtUserCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ cái, số và dấu gạch dưới
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được thêm vào TextBox
            }

        }


        //Nhấn tạo để insert
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtUserCode.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ mã người dùng và tên người dùng ( please enter full User code and User name ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Check vượt quá số ký tự cho phép
                if (txtUserCode.Text.Length > 10)
                {
                    MessageBox.Show("Vui lòng nhập tối đa 10 ký tự chữ hoặc số ( please enter up to 10 alphanumeric characters ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    CheckInsert();

                }
                    
            }
        }

        //Nhấn để Update người dùng
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int[] SelectRows = gridView1.GetSelectedRows();
            if (SelectRows.Length == 1)
            {
                frmUserMasterUPDATE frmUserMasterUPDATE = new frmUserMasterUPDATE();
                frmUserMasterUPDATE.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã để nhấn cập nhật ( Please select one code to update ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridView1.ClearSelection();
                ResetUserForm();
                return;
            }
            ShowUser();
            ResetUserForm();

            ////Check phải chọn bản ghi mới được update
            //if (gridView1.SelectedRowsCount > 0)
            //{
            //    //Check null trường name và update
            //    if (string.IsNullOrEmpty(txtUserCode.Text) || string.IsNullOrEmpty(txtUserName.Text))
            //    {
            //        MessageBox.Show("Vui lòng nhập đủ mã người dùng và tên người dùng ( please enter full User code and User name ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DleteUser();

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();
            Console.WriteLine($"Số dòng đã chọn: {selectedRows.Length}");
        }

        //Nhấn nút Refresh để load dữ liệu form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowUser();
            //Tăng chiều rộng cột STT
            gridView1.IndicatorWidth = 40;
            gridView1.ClearSelection();
        }
    }
}