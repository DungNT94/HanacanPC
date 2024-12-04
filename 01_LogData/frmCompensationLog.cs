using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Export;
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
using System.IO;

namespace HANACANPC._01_LogData
{
    public partial class frmCompensationLog : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        // Biến public
        public static class GloCompensationLog
        {
            public static String ECode;
            public static String CTicketQR;
        }
        public frmCompensationLog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox mtb = sender as MaskedTextBox;
            if (mtb != null)
            {
                // Kiểm tra phần "dd"
                if (mtb.Text.Length == 2 && mtb.SelectionStart == 2)
                {
                    mtb.SelectionStart = 3; // Di chuyển con trỏ qua phần "MM"
                }
                // Kiểm tra phần "MM"
                else if (mtb.Text.Length == 5 && mtb.SelectionStart == 5)
                {
                    mtb.SelectionStart = 6; // Di chuyển con trỏ qua phần "yyyy"
                }
                // Kiểm tra phần "yyyy"
                else if (mtb.Text.Length == 10 && mtb.SelectionStart == 10)
                {
                    mtb.SelectionStart = 11; // Di chuyển con trỏ qua phần "HH"
                }
                // Kiểm tra phần "HH"
                else if (mtb.Text.Length == 13 && mtb.SelectionStart == 13)
                {
                    mtb.SelectionStart = 14; // Di chuyển con trỏ qua phần "mm"
                }
            }
        }
        //Load mở form
        private void frmCompensationLog_Load(object sender, EventArgs e)
        {
            ShowCompensationWork();
            //Tăng kích thước cột STT
            gridViewCompensation.IndicatorWidth = 40; 

            //Mặc định định dạng hiển thị thời gian và cho phép chọn cả giờ phút
            txtDateWorkTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
            txtDateWorkTimeStart.Value = txtDateWorkTimeStart.Value.Date;

            txtDateWorkTimeEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            txtDateWorkTimeEnd.Value = txtDateWorkTimeEnd.Value.Date.AddHours(23).AddMinutes(59);

            //txtDateWorkTimeStart.Mask = "00/00/0000 00:00";
            //maskedTextBox1.ValidatingType = typeof(DateTime);
            txtDateWorkTimeStart.TextChanged += new EventHandler(maskedTextBox1_TextChanged);
        }


        /// <summary>
        /// HÀM CHUNG 
        /// </summary>
        /// 

        //Hàm ngăn chặn nhập ký tự khác số trong trường tìm kiếm Error count
        private void txtErrorStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập Số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được thêm vào TextBox
            }
        }

        private void txtErrorEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập Số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được thêm vào TextBox
            }
        }


        // Hàm hiển thị dữ liệu lên gridControl Compensation work
        public void ShowCompensationWork()
        {

            string query = "select * from LogCompensation ORDER BY UpdateTime DESC";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl2.DataSource = dttb;
            //gridView1.ClearSelection();
        }

        //Hàm đánh STT trên gridControl Compensation
        private void gridViewCompensation_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                string query = "SELECT * FROM LogCompensation WHERE 1=1";
                //Nếu Design Code ko empty
                if (!string.IsNullOrEmpty(txtDesignCode.Text))
                {
                    query += " and DesignCode LIKE N'%" + txtDesignCode.Text + "%'";
                }
                //Nếu Location ko empty
                if (!string.IsNullOrEmpty(txtLocation.Text))
                {
                    query += " and Location LIKE N'%" + txtLocation.Text + "%'";
                }
                //Thiết lập bộ lọc tìm kiếm WrongCount
                if (!string.IsNullOrEmpty(txtErrorStart.Text)&& !string.IsNullOrEmpty(txtErrorEnd.Text))
                {
                    query += " and (WrongCount>="+txtErrorStart.Text+" and WrongCount<="+txtErrorEnd.Text+")";
                }

                if (!string.IsNullOrEmpty(txtErrorStart.Text) && string.IsNullOrEmpty(txtErrorEnd.Text))
                {
                    query += " and WrongCount>=" + txtErrorStart.Text + "";
                }

                if (string.IsNullOrEmpty(txtErrorStart.Text) && !string.IsNullOrEmpty(txtErrorEnd.Text))
                {
                    query += " and (WrongCount>=0" + txtErrorStart.Text + " and WrongCount<=" + txtErrorEnd.Text + ")";
                }

                //Thiết lập bộ lọc tìm kiếm WorkingTime
                string TimeStart = txtDateWorkTimeStart.Value.ToString("yyyyMMdd HH:mm");
                string TimeEnd = txtDateWorkTimeEnd.Value.ToString("yyyyMMdd HH:mm");
                query += " and WorkingTime BETWEEN '" + TimeStart + "' and '"+ TimeEnd + "'";

                //Sắp xếp bảng theo UpdateTime
                query += " ORDER BY UpdateTime DESC";


                da.SelectCommand.CommandText = query;
                da.SelectCommand.Connection = conn;
                da.Fill(dt);
                gridControl2.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        //Hàm lấy dữ liệu từ gridView sau lọc làm điều kiện tạo lên dataTable error
        DataTable DtErrorComPensation;
        private void ErrorComPensationTable()
        {
            // Tạo một danh sách để chứa các giá trị cột TicketQR
            List<string> TickQRList = new List<string>();

            // Gán giá trị cột TicketQR vào List

            for (int i=0; i < gridViewCompensation.RowCount; i++)
            {
                 var GridViewTicketQR = gridViewCompensation.GetRowCellValue(i, "TicketQR").ToString().Trim();
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
                DtErrorComPensation = new DataTable();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                conn.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = conn;
                da.SelectCommand.CommandText = "select*from ErrorCompensation where TicketQR in (" + TicketQRs + ")";
                da.Fill(DtErrorComPensation);
            }
            catch(Exception ex)
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCompensationWork();
        }


        //Sự kiện thay đổi thời gian tìm kiếm
        private DateTime previousTimeStart,previousTimeEnd;
        private void txtDateWorkTimeEnd_ValueChanged(object sender, EventArgs e)
        {

            previousTimeEnd = txtDateWorkTimeEnd.Value;
            if (txtDateWorkTimeEnd.Value< txtDateWorkTimeStart.Value)
            {
                txtDateWorkTimeStart.Value = previousTimeEnd;
                return;

            }
        }

        private void txtDateWorkTimeStart_ValueChanged(object sender, EventArgs e)
        {
            previousTimeStart = txtDateWorkTimeStart.Value;
            if (txtDateWorkTimeStart.Value > txtDateWorkTimeEnd.Value)
            {
                txtDateWorkTimeEnd.Value = previousTimeStart;
                return;

            }
        }


        //Nhấn click vào Error Count để mở form Error
        private void gridViewCompensation_Click(object sender, EventArgs e)
        {
            //GridView View = sender as GridView;
            ////Lấy giá trị EAN Code, CTicketQR sau khi click
            //GloCompensationLog.ECode = View.GetFocusedRowCellValue("EANCode").ToString().Trim();
            //GloCompensationLog.CTicketQR = View.GetFocusedRowCellValue("TicketQR").ToString().Trim();
            ////GloCompensationLog.CTicketQR = View.GetFocusedRowCellValue("TicketQR").ToString().Trim();
            //if (View.FocusedColumn.FieldName == "WrongCount")
            //{
            //    frmErrorCompensation frmErrorCompensation = new frmErrorCompensation();
            //    frmErrorCompensation.ShowDialog();
            //}
            //else
            //{
            //    return;
            //}

        }
        //Nhấn click vào Error Count để mở form Error
        private void gridViewCompensation_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView View = sender as GridView;
            //Lấy giá trị EAN Code, CTicketQR sau khi click
            GloCompensationLog.ECode = View.GetFocusedRowCellValue("EANCode").ToString().Trim();
            GloCompensationLog.CTicketQR = View.GetFocusedRowCellValue("TicketQR").ToString().Trim();
            //GloCompensationLog.CTicketQR = View.GetFocusedRowCellValue("TicketQR").ToString().Trim();
            if (View.FocusedColumn.FieldName == "WrongCount")
            {
                frmErrorCompensation frmErrorCompensation = new frmErrorCompensation();
                frmErrorCompensation.ShowDialog();
            }
            else
            {
                return;
            }
        }


        //Nhấn expot CSV để export toàn bộ bảng Compesation
        
        private void btnExportCSVMain_Click(object sender, EventArgs e)
        {
            //// Lấy thời gian hiện tại
            //DateTime currentTime = DateTime.Now;
            //// Định dạng ngày tháng năm: dd/MM/yyyy
            //string ExportTime = currentTime.ToString("dd_MM_yyyy_HHmmss");
            //string filePath = "..\\..\\..\\..\\Export\\CompesationLogDataExport\\" + ExportTime + "_CompesationLogData.csv";
            //// Tạo đối tượng ExportToCsvOptions để tùy chỉnh quá trình export
            //CsvExportOptions options = new CsvExportOptions();
            //options.TextExportMode = TextExportMode.Value; // Chỉ xuất giá trị ô
            //options.Encoding = Encoding.UTF8;

            //// Export dữ liệu
            //gridControl2.ExportToCsv(filePath, options);
            //MessageBox.Show("Export thành công (Export successful)!");
            // Sử dụng SaveFileDialog để lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv"; // Chỉ cho phép lưu file CSV
            saveFileDialog.Title = "Export File";
            saveFileDialog.FileName = $"CompensationLog_{DateTime.Now:dd_MM_yyyy_HHmmss}.csv"; // Đặt tên file mặc định

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng nhấn Save
            {
                string filePath = saveFileDialog.FileName;

                // Tạo đối tượng ExportToCsvOptions để tùy chỉnh quá trình export
                CsvExportOptions options = new CsvExportOptions();
                options.TextExportMode = TextExportMode.Value; // Chỉ xuất giá trị ô
                options.Encoding = Encoding.UTF8;

                try
                {
                    // Export dữ liệu
                    gridControl2.ExportToCsv(filePath, options);
                    MessageBox.Show("Export thành công (Export successful)!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed: {ex.Message}");
                }
            }
        }



        //Nhấn expot ExportCSVError để export toàn bộ bảng Compesation Error
        private void btnExportCSVError_Click(object sender, EventArgs e)
        {
            if (gridViewCompensation.RowCount != 0)
            {
                //// Lấy thời gian hiện tại
                //DateTime currentTime = DateTime.Now;
                //// Định dạng ngày tháng năm: dd/MM/yyyy
                //string ExportTime = currentTime.ToString("dd_MM_yyyy_HHmmss");
                //string filePath = "..\\..\\..\\..\\Export\\CompesationLogErrorDataExport\\" + ExportTime + "_CompesationLogErrorALLData.csv";
                //ErrorComPensationTable();
                //ExporErrorTableToCSV(DtErrorComPensation, filePath);
                // Tạo SaveFileDialog để người dùng chọn thư mục
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog1.FileName = $"CompesationLogErrorALLData_{DateTime.Now:dd_MM_yyyy_HHmmss}.csv";
                saveFileDialog1.Title = "Export File";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    ErrorComPensationTable();
                    ExporErrorTableToCSV(DtErrorComPensation, filePath);
                }

            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất (No data to export).");
                return;
            }
        }

    }
}