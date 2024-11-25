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

namespace HANACANPC._01_LogData
{
    public partial class frmWorkProgress : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        public frmWorkProgress()
        {
            InitializeComponent();

        }

        /// <summary>
        /// HÀM CHUNG 
        /// </summary>
        // Hàm hiển thị dữ liệu lên gridControl Compensation work
        public void ShowCompensationWork()
        {

            string query = "select TOP 20 * from LogCompensation ORDER BY WorkingTime DESC ;";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl2.DataSource = dttb;
            //gridView1.ClearSelection();
        }

        // Hàm hiển thị dữ liệu lên gridControl Resorting work
        public void ShowResortingWork()
        {

            string query = "select TOP 1 * from LogResorting ORDER BY WorkingTime DESC ;";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl1.DataSource = dttb;
            //gridView1.ClearSelection();
        }

        //Đánh STT cho các bản ghi của 2 bảng
        private void gridViewCompensation_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicator(e);
            gridViewCompensation.IndicatorWidth = 40; //Tăng kích thước cột STT
        }

        private void gridViewResorting_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicator(e);
            gridViewResorting.IndicatorWidth = 40; //Tăng kích thước cột STT
        }


        //Load lên mở form
        private void frmWorkProgress_Load(object sender, EventArgs e)
        {
            ShowCompensationWork();
            ShowResortingWork();
        }

        private void btnUnlockHT_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Có chắc chắn muốn mở khóa Handy đang dùng? ( Are you sure you want to unlock the Handy you are using? )","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == rs)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                SqlCommand cmd = new SqlCommand();
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "Truncate table HTLock;";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        //Nhấn nút Refresh để load dữ liệu form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowCompensationWork();
            ShowResortingWork();
        }
    }
}