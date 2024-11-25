using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
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
using static HANACANPC._01_LogData.frmResortingLog;

namespace HANACANPC._01_LogData
{
    public partial class frmErrorResorting : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        public frmErrorResorting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Load mở form
        private void frmErrorResorting_Load(object sender, EventArgs e)
        {
            ShowErrorResorting();
            //Tăng kích thước cột STT
            gridViewErrorResorting.IndicatorWidth = 40;

        }

        //Hàm Show  Error Resorting
        public void ShowErrorResorting()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = new SqlCommand();
            try
            {
                conn.Open();
                da.SelectCommand.Connection = conn;
                da.SelectCommand.CommandText = "select*from ErrorResorting where OriginTicketQR =N'" + GloResortingLog.OrTicketQR + "' Order by ErrorTime Desc;";
                da.Fill(dt);
                gridControl2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Đánh STT trên bảng Error Compensation
        private void gridViewErrorCompensation_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicatorErrorResort(e);

        }

        //Nhấn Close để đóng form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////Nhấn Export ra danh sách lỗi
        private void btnExportCSVError_Click(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;
            // Định dạng ngày tháng năm: dd/MM/yyyy
            string ExportTime = currentTime.ToString("dd_MM_yyyy_HHmmss");
            string filePath = "..\\..\\..\\..\\Export\\ResortingLogErrorDataExport\\" + ExportTime + "_ResortingLogErrorSubsetData.csv";

            // Tạo đối tượng ExportToCsvOptions để tùy chỉnh quá trình export
            CsvExportOptions options = new CsvExportOptions();
            options.TextExportMode = TextExportMode.Value; // Chỉ xuất giá trị ô
            options.Encoding = Encoding.UTF8;

            // Export dữ liệu
            gridControl2.ExportToCsv(filePath, options);
            MessageBox.Show("Export thành công (Export successful)!");
        }
    }
}