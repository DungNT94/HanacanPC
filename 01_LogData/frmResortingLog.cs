using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANACANPC._01_LogData
{
    public partial class frmResortingLog : DevExpress.XtraEditors.XtraForm
    {
        //Đối tượng kết nối SQL Class dùng chung
        SQLConnection objConnection = new SQLConnection();

        //Biến public
        public static class GloResortingLog{
            public static String OrTicketQR;
        }
        public frmResortingLog()
        {
            InitializeComponent();
        }


        //Load mở form
        private void frmResortingLog_Load(object sender, EventArgs e)
        {
            ShowResortingWork();
            //Tăng kích thước cột STT
            gridViewResorting.IndicatorWidth = 40;

            //Mặc định định dạng hiển thị thời gian và cho phép chọn cả giờ phút
            txtDateWorkTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
            txtDateWorkTimeStart.Value = txtDateWorkTimeStart.Value.Date;

            txtDateWorkTimeEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            txtDateWorkTimeEnd.Value = txtDateWorkTimeEnd.Value.Date.AddHours(23).AddMinutes(59);
        }
        /// <summary>
        /// HÀM CHUNG 
        /// </summary>
        /// 

        //Hàm ngăn chặn nhập ký tự khác số trong trường tìm kiếm Error count

        private void txtErrorStart_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập Số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được thêm vào TextBox
            }
        }

        private void txtErrorEnd_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập Số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được thêm vào TextBox
            }
        }
        

        // Hàm hiển thị dữ liệu lên gridControl Resorting work
        public void ShowResortingWork()
        {

            string query = "select * from LogResorting ORDER BY UpdateTime DESC";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl1.DataSource = dttb;
            //gridView1.ClearSelection();
        }

        //Hàm đánh STT trên Resorting
        private void gridViewResorting_CustomDrawRowIndicator_1(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicator(e);
        }

        //Hàm tìm kiếm theo điều kiện lọc
        public void SearchCompensationWork()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                conn.Open();
                da.SelectCommand = new SqlCommand();

                // Xây dựng câu truy vấn động dựa trên các điều kiện tìm kiếm
                string query = "SELECT * FROM LogResorting WHERE 1=1";
                //Nếu Design Code ko empty
                if (!string.IsNullOrEmpty(txtDesignCode.Text))
                {
                    query += " and DesignCode LIKE N'%" + txtDesignCode.Text + "%'";
                }
                //Nếu ScanTicketQR ko empty
                if (!string.IsNullOrEmpty(txtOriginTicketQR.Text))
                {
                    query += " and OriginTicketQR LIKE N'%" + txtOriginTicketQR.Text + "%'";
                }
                //Nếu Error Count ko empty
                if (!string.IsNullOrEmpty(txtErrorStart.Text) && !string.IsNullOrEmpty(txtErrorEnd.Text))
                {
                    query += " and (ErrorCount>=" + txtErrorStart.Text + " and ErrorCount<=" + txtErrorEnd.Text + ")";
                }

                if (!string.IsNullOrEmpty(txtErrorStart.Text) && string.IsNullOrEmpty(txtErrorEnd.Text))
                {
                    query += " and ErrorCount>=" + txtErrorStart.Text + "";
                }

                if (string.IsNullOrEmpty(txtErrorStart.Text) && !string.IsNullOrEmpty(txtErrorEnd.Text))
                {
                    query += " and (ErrorCount>=0" + txtErrorStart.Text + " and ErrorCount<=" + txtErrorEnd.Text + ")";
                }

                //Thiết lập bộ lọc tìm kiếm WorkingTime
                string TimeStart = txtDateWorkTimeStart.Value.ToString("yyyyMMdd HH:mm");
                string TimeEnd = txtDateWorkTimeEnd.Value.ToString("yyyyMMdd HH:mm");
                query += " and WorkingTime BETWEEN '" + TimeStart + "' and '" + TimeEnd + "'";

                //Sắp xếp bảng theo UpdateTime
                query += " ORDER BY UpdateTime DESC";


                da.SelectCommand.CommandText = query;
                da.SelectCommand.Connection = conn;
                da.Fill(dt);
                gridControl1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm lấy dữ liệu từ gridView sau lọc làm điều kiện tạo lên dataTable error
        DataTable DtErrorResorting;
        private void ErrorResortingTable()
        {
            // Tạo một danh sách để chứa các giá trị cột TicketQR
            List<string> TickQRList = new List<string>();

            // Gán giá trị cột TicketQR vào List

            for (int i = 0; i < gridViewResorting.RowCount; i++)
            {
                var GridViewTicketQR = gridViewResorting.GetRowCellValue(i, "OriginTicketQR").ToString().Trim();
                TickQRList.Add("N'" + GridViewTicketQR + "'");
            }

            //Tạo lại định dạng list ngăn cách nhau bằng dấu phẩy
            string TicketQRs = "";
            TickQRList.ToList().ForEach(k => TicketQRs += k + ",");
            // Loại bỏ dấu phẩy cuối cùng
            TicketQRs = TicketQRs.Trim(',');

            //Tạo bảng dataTabel error
            try
            {
                SqlConnection conn = new SqlConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DtErrorResorting = new DataTable();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                conn.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = conn;
                da.SelectCommand.CommandText = "select*from ErrorResorting where OriginTicketQR in (" + TicketQRs + ")";
                da.Fill(DtErrorResorting);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Hàm Export từ datatable
        public void ExporErrorTableToCSV(DataTable dtb, string filePath)
        {
            StringBuilder csvContent = new StringBuilder();
            try
            {
                // Ghi tiêu đề cột (column headers)
                foreach (DataColumn column in dtb.Columns)
                {
                    csvContent.Append(column.ColumnName + ",");
                }
                csvContent.Length--; // Bỏ dấu phẩy cuối cùng
                csvContent.AppendLine();

                // Ghi dữ liệu từng dòng (rows)
                foreach (DataRow row in dtb.Rows)
                {
                    foreach (DataColumn column in dtb.Columns)
                    {
                        csvContent.Append(row[column].ToString() + ",");
                    }
                    csvContent.Length--; // Bỏ dấu phẩy cuối cùng
                    csvContent.AppendLine();
                }

                // Ghi nội dung vào file CSV
                File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
                MessageBox.Show("Export thành công (Export successful)!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //Nhấn tìm kiếm để tìm theo điều kiện lọc
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SearchCompensationWork();
        }

        //Sự kiện thay đổi thời gian tìm kiếm
        private DateTime previousTimeStart, previousTimeEnd;
        private void txtDateWorkTimeStart_ValueChanged(object sender, EventArgs e)
        {
            previousTimeStart = txtDateWorkTimeStart.Value;
            if (txtDateWorkTimeStart.Value > txtDateWorkTimeEnd.Value)
            {
                txtDateWorkTimeEnd.Value = previousTimeStart;
                return;

            }
        }

        private void txtDateWorkTimeEnd_ValueChanged(object sender, EventArgs e)
        {
           
            previousTimeEnd = txtDateWorkTimeEnd.Value;
            if (txtDateWorkTimeEnd.Value < txtDateWorkTimeStart.Value)
            {
                txtDateWorkTimeStart.Value = previousTimeEnd;
                return;

            }
        }
        

        ////Nhấn Export ra danh sách Main
        private void btnExportCSVMain_Click_1(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;
            // Định dạng ngày tháng năm: dd/MM/yyyy
            string ExportTime = currentTime.ToString("dd_MM_yyyy_HHmmss");
            string filePath = "..\\..\\..\\..\\Export\\ResortingLogDataExport\\" + ExportTime + "_ResortingLogData.csv";

            // Tạo đối tượng ExportToCsvOptions để tùy chỉnh quá trình export
            CsvExportOptions options = new CsvExportOptions();
            options.TextExportMode = TextExportMode.Value; // Chỉ xuất giá trị ô
            options.Encoding = Encoding.UTF8;

            // Export dữ liệu
            gridControl1.ExportToCsv(filePath, options);
            MessageBox.Show("Export thành công (Export successful)!");
        }


        //Nhấn click vào Error Count để mở form Error
        private void gridViewResorting_Click(object sender, EventArgs e)
        {
            //GridView View = sender as GridView;
            //GloResortingLog.OrTicketQR = View.GetFocusedRowCellValue("OriginTicketQR").ToString().Trim();
            //if (View.FocusedColumn.FieldName == "ErrorCount")
            //{
            //    frmErrorResorting frmErrorResorting = new frmErrorResorting();
            //    frmErrorResorting.ShowDialog();
            //}
            //else
            //{
            //    return;
            //}
        }

        //Nhấn click vào Error Count để mở form Error
        private void gridViewResorting_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView View = sender as GridView;
            GloResortingLog.OrTicketQR = View.GetFocusedRowCellValue("OriginTicketQR").ToString().Trim();
            if (View.FocusedColumn.FieldName == "ErrorCount")
            {
                frmErrorResorting frmErrorResorting = new frmErrorResorting();
                frmErrorResorting.ShowDialog();
            }
            else
            {
                return;
            }
        }




        //Nhấn Export ra danh sách ErrorResorting
        private void btnExportCSVError_Click_1(object sender, EventArgs e)
        {
            if (gridViewResorting.RowCount != 0)
            {
                // Lấy thời gian hiện tại
                DateTime currentTime = DateTime.Now;
                // Định dạng ngày tháng năm: dd/MM/yyyy
                string ExportTime = currentTime.ToString("dd_MM_yyyy_HHmmss");
                string filePath = "..\\..\\..\\..\\Export\\ResortingLogErrorDataExport\\" + ExportTime + "_ResortingErrorALLData.csv";
                ErrorResortingTable();
                ExporErrorTableToCSV(DtErrorResorting, filePath);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất (No data to export).");
                return;
            }
        }

    }

    
}