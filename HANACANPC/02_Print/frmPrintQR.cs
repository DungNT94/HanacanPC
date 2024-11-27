using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using System.Runtime.InteropServices;
using System.Management;

namespace HANACANPC._02_Print
{
    public partial class frmPrintQR : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        // Biến public
            public static string GManagementCode;
            public static string GLocationName;
       // private List<string> printerNames; // List to store available printer names

        public frmPrintQR()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Get available printer names using System.Printing
            //printerNames = System.Printing.LocalPrintServer.GetInstalledPrinters().Select(p => p.PrinterName).ToList();

            // Add printer names to the ComboBox
            //CbxPrinter.DataSource = printerNames;
        }

        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// 
        //Hàm show tên Laction
        private void ShowLocation()
        {
            string query = "select * from MasterCase";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl2.DataSource = dttb;
        }

        //Thêm Cột Đánh STT tự động
        private void gridViewPrintQR_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicatorErrorResort(e);
        }

        //Load form
        private void frmPrintQR_Load(object sender, EventArgs e)
        {
            ShowLocation();
            gridViewPrintQR.IndicatorWidth = 40;
            gridViewPrintQR.ClearSelection();
            gridViewPrintQR.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewPrintQR.OptionsSelection.EnableAppearanceFocusedRow = false;
            //Reset lại biến chọn địa điểm
            GManagementCode = "";
            GLocationName = "";
            //LoadPrinters();
        }

        //Sự kiện click row gán giá trị cho biến
        private void gridControl2_Click(object sender, EventArgs e)
        {

            GManagementCode = gridViewPrintQR.GetFocusedRowCellValue("Code").ToString();
            GLocationName = gridViewPrintQR.GetFocusedRowCellValue("Location").ToString().Trim();
            gridViewPrintQR.OptionsSelection.EnableAppearanceFocusedCell = true;
            gridViewPrintQR.OptionsSelection.EnableAppearanceFocusedRow = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /// CODE TH1
            // Lấy hàng đang được focus
            if (GManagementCode != "")
            {

                // var Path = String.Concat(DLfolder.Text, @"\");    

                string source_filename = Application.StartupPath + "\\Template\\LayoutQR.xlsx";
                string desitnation = Application.StartupPath + "\\Export\\" + String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + ".xlsx";

                File.Copy(source_filename, desitnation);
                FileInfo fileInfo = new FileInfo(desitnation);
                ExcelPackage excel = new ExcelPackage(fileInfo);

                var workSheet = excel.Workbook.Worksheets["Sheet1"];
                //Tạo Mã QR case Label
                // Tạo file tạm thời để lưu hình ảnh QR
                string tempPath1 = Path.GetTempFileName() + ".png";
                DotNetBarcode QR1 = new DotNetBarcode();
                var QRCodeContent1 = "C" + GManagementCode;
                QR1.Type = DotNetBarcode.Types.QRCode;
                QR1.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
                QR1.Save(QRCodeContent1, tempPath1, 775, 206);

                //using (Image image1 = Image.FromFile(tempPath1))
                //{

                //    //Image image1 = Image.FromStream(ms1);
                //    var picture1 = workSheet.Drawings.AddPicture("XX1",image1);
                //    picture1.SetPosition(6, 8, 6, 1);
                //    picture1.SetSize(250, 250);
                //}
                //// Thêm hình ảnh QR Code vào file Excel
                var picture1 = workSheet.Drawings.AddPicture("XX1", new FileInfo(tempPath1));
                picture1.SetPosition(6, 8, 6, 1);
                picture1.SetSize(250, 250);
                //Code cho case Label
                workSheet.Cells["H3"].Value = GManagementCode;
                workSheet.Cells["H4"].Value = GLocationName;


                //Tạo Mã QR Drawer Label
                string tempPath2 = Path.GetTempFileName() + ".png";
                DotNetBarcode QR2 = new DotNetBarcode();
                var QRCodeContent2 = "D" + GManagementCode;
                QR2.Type = DotNetBarcode.Types.QRCode;
                QR2.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
                QR2.Save(QRCodeContent2, tempPath2, 775, 206);

                //using (Image image2 = Image.FromFile(tempPath2))
                //{

                //    //Image image1 = Image.FromStream(ms1);
                //    var picture2 = workSheet.Drawings.AddPicture("XX2", image2);
                //    picture2.SetPosition(27, 8, 6, 1);
                //    picture2.SetSize(250, 250);
                //}

                // Thêm hình ảnh QR Code vào file Excel
                var picture2 = workSheet.Drawings.AddPicture("XX2", new FileInfo(tempPath2));
                picture2.SetPosition(27, 8, 6, 1);
                picture2.SetSize(250, 250);
                //Code cho Drawer Label
                workSheet.Cells["H24"].Value = GManagementCode;
                workSheet.Cells["H25"].Value = GLocationName;

                ////đoạn này là khóa lại các chức năng
                //workSheet.Protection.IsProtected = true;
                //workSheet.Protection.SetPassword("yosato");

                //// Các quyền hạn được tùy chỉnh (có thể thay đổi tùy theo nhu cầu)
                //workSheet.Protection.AllowSelectLockedCells = true; // Cho phép chọn ô khóa
                //workSheet.Protection.AllowSelectUnlockedCells = true; // Cho phép chọn ô không khóa
                //workSheet.Protection.AllowFormatCells = false; // Không cho phép định dạng lại ô
                //workSheet.Protection.AllowEditObject = false; // Không cho phép chỉnh sửa object
                //workSheet.Protection.AllowInsertColumns = false; // Không cho phép thêm cột
                //workSheet.Protection.AllowInsertRows = false; // Không cho phép thêm hàng     


                // Lưu file
                excel.Save();
                //Process.Start(desitnation);

                // In trực tiếp
                //PrintExcelFile(desitnation);
                Task.Run(() => PrintExcelFile(desitnation));


            }
            else
            {
                MessageBox.Show("Vui lòng chọn Location trước khi in (please select Location before printing).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /// CODE TH2
            // Lấy danh sách các dòng được chọn
            //int[] selectedRows = gridViewPrintQR.GetSelectedRows();

            //if (selectedRows.Length == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn ít nhất một dòng trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Duyệt qua từng dòng được chọn
            //foreach (int rowHandle in selectedRows)
            //{
            //    if (rowHandle >= 0)
            //    {
            //        string managementCode = gridViewPrintQR.GetRowCellValue(rowHandle, "Code").ToString();
            //        string locationName = gridViewPrintQR.GetRowCellValue(rowHandle, "Location").ToString().Trim();

            //        // Thực hiện in từng dòng
            //        PrintRow(managementCode, locationName);
            //    }
            //}

            /// CODE TH3
            //// Lấy danh sách các dòng được chọn
            //int[] selectedRows = gridViewPrintQR.GetSelectedRows();

            //if (selectedRows.Length == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn ít nhất một dòng trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Tạo danh sách chứa thông tin các dòng được chọn
            //List<(string managementCode, string locationName)> rowsToPrint = new List<(string managementCode, string locationName)>();

            //foreach (int rowHandle in selectedRows)
            //{
            //    if (rowHandle >= 0)
            //    {
            //        string managementCode = gridViewPrintQR.GetRowCellValue(rowHandle, "Code").ToString();
            //        string locationName = gridViewPrintQR.GetRowCellValue(rowHandle, "Location").ToString().Trim();

            //        // Thêm vào danh sách
            //        rowsToPrint.Add((managementCode, locationName));
            //    }
            //}

            //// Gọi hàm PrintRows để in tất cả các dòng
            //if (rowsToPrint.Count > 0)
            //{
            //    PrintRows(rowsToPrint);
            //}
            //else
            //{
            //    MessageBox.Show("Không có dòng nào hợp lệ để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        //Lấy cổng printer
        private string GetPrinterPort(string printerName)
        {
            try
            {
                // Truy vấn thông tin máy in từ WMI
                string query = $"SELECT * FROM Win32_Printer WHERE Name = '{printerName.Replace("\\", "\\\\")}'";
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject printer in searcher.Get())
                    {
                        // Lấy cổng máy in (PortName)
                        return printer["PortName"]?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving printer port: {ex.Message}");
            }
            return null; // Không tìm thấy cổng
        }

        private void SetActivePrinterForExcel(string selectedPrinter, Microsoft.Office.Interop.Excel.Application excelApp)
        {
            string printerPort = GetPrinterPort(selectedPrinter);
            if (!string.IsNullOrEmpty(printerPort))
            {
                try
                {
                    // Gán ActivePrinter với tên máy in và cổng
                    excelApp.ActivePrinter = $"{selectedPrinter} trên {printerPort}";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error setting ActivePrinter: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy cổng máy in. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////Hàm chọn máy in
        //private void LoadPrinters()
        //{
        //    CbxPrinter.Items.Clear();
        //    foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
        //    {
        //        CbxPrinter.Items.Add(printer);
        //    }

        //    // Chọn máy in mặc định hiện tại
        //    var defaultPrinter = new System.Drawing.Printing.PrinterSettings().PrinterName;
        //    if (CbxPrinter.Items.Contains(defaultPrinter))
        //    {
        //        CbxPrinter.SelectedItem = defaultPrinter;
        //    }
        //}

       // private string selectedPrinter;
        //private void CbxPrinter_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //selectedPrinter = CbxPrinter.SelectedItem.ToString();
        //}


        /// CODE TH3 Hàm print row
        private void PrintRows(List<(string managementCode, string locationName)> selectedRows)
        {
            //string sourceFilename = Application.StartupPath + "\\Template\\LayoutQR.xlsx";
            //string exportFolder = Application.StartupPath + "\\Export\\";

            //var excelApp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbooks workbooks = null;

            //try
            //{
            //    // Khởi tạo ứng dụng Excel
            //    excelApp.Visible = false; // Không hiển thị giao diện
            //    workbooks = excelApp.Workbooks;

            //    foreach (var row in selectedRows)
            //    {
            //        string destination = exportFolder + String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + "_" + row.managementCode + ".xlsx";

            //        // Sao chép file mẫu
            //        File.Copy(sourceFilename, destination);
            //        FileInfo fileInfo = new FileInfo(destination);
            //        using (ExcelPackage excel = new ExcelPackage(fileInfo))
            //        {
            //            var workSheet = excel.Workbook.Worksheets["Sheet1"];

            //            // Tạo QR Code
            //            string tempPath1 = Path.GetTempFileName() + ".png";
            //            DotNetBarcode QR1 = new DotNetBarcode();
            //            var QRCodeContent1 = "C" + row.managementCode;
            //            QR1.Type = DotNetBarcode.Types.QRCode;
            //            QR1.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
            //            QR1.Save(QRCodeContent1, tempPath1, 775, 206);

            //            var picture1 = workSheet.Drawings.AddPicture("XX1", new FileInfo(tempPath1));
            //            picture1.SetPosition(6, 8, 6, 1);
            //            picture1.SetSize(250, 250);

            //            workSheet.Cells["H3"].Value = row.managementCode;
            //            workSheet.Cells["H4"].Value = row.locationName;


            //            //Tạo Mã QR Drawer Label
            //            string tempPath2 = Path.GetTempFileName() + ".png";
            //            DotNetBarcode QR2 = new DotNetBarcode();
            //            var QRCodeContent2 = "D" + row.managementCode;
            //            QR2.Type = DotNetBarcode.Types.QRCode;
            //            QR2.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
            //            QR2.Save(QRCodeContent2, tempPath2, 775, 206);

            //            //using (Image image2 = Image.FromFile(tempPath2))
            //            //{

            //            //    //Image image1 = Image.FromStream(ms1);
            //            //    var picture2 = workSheet.Drawings.AddPicture("XX2", image2);
            //            //    picture2.SetPosition(27, 8, 6, 1);
            //            //    picture2.SetSize(250, 250);
            //            //}

            //            // Thêm hình ảnh QR Code vào file Excel
            //            var picture2 = workSheet.Drawings.AddPicture("XX2", new FileInfo(tempPath2));
            //            picture2.SetPosition(27, 8, 6, 1);
            //            picture2.SetSize(250, 250);
            //            //Code cho Drawer Label
            //            workSheet.Cells["H24"].Value = row.managementCode;
            //            workSheet.Cells["H25"].Value = row.locationName;

            //            // Lưu file Excel
            //            excel.Save();
            //        }

            //        // Mở file Excel trong danh sách in
            //        var workbook = workbooks.Open(destination, ReadOnly: true);
            //    }

            //    // Hiển thị hộp thoại in duy nhất cho tất cả các workbook
            //    excelApp.Dialogs[Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogPrint].Show();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi khi in tệp Excel: {ex.Message}");
            //}
            //finally
            //{
            //    // Đóng tất cả workbook và dọn dẹp
            //    if (workbooks != null)
            //    {
            //        workbooks.Close();
            //        Marshal.ReleaseComObject(workbooks);
            //    }
            //    excelApp.Quit();
            //    Marshal.ReleaseComObject(excelApp);
            //}
            //string sourceFilename = Application.StartupPath + "\\Template\\LayoutQR.xlsx";
            //string exportFolder = Application.StartupPath + "\\Export\\";

            //var excelApp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbooks workbooks = excelApp.Workbooks;
            //try
            //{


            //    List<string> createdWorkbooks = new List<string>();

            //    // Tạo từng file Excel từ các dòng đã chọn
            //    foreach (var row in selectedRows)
            //    {
            //        string destination = exportFolder + String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + "_" + row.managementCode + ".xlsx";

            //        // Sao chép file mẫu
            //        File.Copy(sourceFilename, destination);
            //        FileInfo fileInfo = new FileInfo(destination);
            //        List<string> generatedFiles = new List<string>();

            //        using (ExcelPackage excel = new ExcelPackage(fileInfo))
            //        {
            //            var workSheet = excel.Workbook.Worksheets["Sheet1"];

            //            // Tạo QR Code
            //            string tempPath1 = Path.GetTempFileName() + ".png";
            //            DotNetBarcode QR1 = new DotNetBarcode();
            //            var QRCodeContent1 = "C" + row.managementCode;
            //            QR1.Type = DotNetBarcode.Types.QRCode;
            //            QR1.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
            //            QR1.Save(QRCodeContent1, tempPath1, 775, 206);

            //            var picture1 = workSheet.Drawings.AddPicture("XX1", new FileInfo(tempPath1));
            //            picture1.SetPosition(6, 8, 6, 1);
            //            picture1.SetSize(250, 250);

            //            workSheet.Cells["H3"].Value = row.managementCode;
            //            workSheet.Cells["H4"].Value = row.locationName;

            //            //Tạo Mã QR Drawer Label
            //            string tempPath2 = Path.GetTempFileName() + ".png";
            //            DotNetBarcode QR2 = new DotNetBarcode();
            //            var QRCodeContent2 = "D" + row.managementCode;
            //            QR2.Type = DotNetBarcode.Types.QRCode;
            //            QR2.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
            //            QR2.Save(QRCodeContent2, tempPath2, 775, 206);

            //            //using (Image image2 = Image.FromFile(tempPath2))
            //            //{

            //            //    //Image image1 = Image.FromStream(ms1);
            //            //    var picture2 = workSheet.Drawings.AddPicture("XX2", image2);
            //            //    picture2.SetPosition(27, 8, 6, 1);
            //            //    picture2.SetSize(250, 250);
            //            //}

            //            // Thêm hình ảnh QR Code vào file Excel
            //            var picture2 = workSheet.Drawings.AddPicture("XX2", new FileInfo(tempPath2));
            //            picture2.SetPosition(27, 8, 6, 1);
            //            picture2.SetSize(250, 250);
            //            //Code cho Drawer Label
            //            workSheet.Cells["H24"].Value = row.managementCode;
            //            workSheet.Cells["H25"].Value = row.locationName;

            //            excel.Save();
            //        }

            //        // Lưu lại đường dẫn của workbook vừa tạo
            //        createdWorkbooks.Add(destination);
            //    }

            //    // In từng workbook đã tạo
            //    foreach (var workbookPath in createdWorkbooks)
            //    {
            //        var workbook = workbooks.Open(workbookPath, ReadOnly: true);
            //        //Thiết lập máy in combobox
            //        try
            //        {
            //            if (!string.IsNullOrEmpty(selectedPrinter))
            //            {
            //                SetActivePrinterForExcel(selectedPrinter, excelApp);
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine($"Error setting ActivePrinter: {ex.Message}");
            //        }

            //        //In workbook này(in trực tiếp không cần hiển thị hộp thoại)
            //        workbook.PrintOut();
            //        workbook.Close(false); // Đóng sau khi in
            //        gridViewPrintQR.ClearSelection();
            //    }
            //    // Xóa tất cả các file trong thư mục Export
            //    foreach (string file in createdWorkbooks)
            //    {
            //        if (File.Exists(file))
            //        {
            //            File.Delete(file);
            //        }
            //    }

            //    MessageBox.Show("In tất cả các thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi khi in tệp Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    // Đảm bảo Excel được giải phóng tài nguyên
            //    if (excelApp != null)
            //    {
            //        excelApp.Quit();
            //        Marshal.ReleaseComObject(excelApp);
            //    }
            //}

        }


        ////Hàm in từng dòng
        private void PrintRow(string managementCode, string locationName)
        {
            string sourceFilename = Application.StartupPath + "\\Template\\LayoutQR.xlsx";
            string destination = Application.StartupPath + "\\Export\\" + String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + ".xlsx";

            File.Copy(sourceFilename, destination);
            FileInfo fileInfo = new FileInfo(destination);
            ExcelPackage excel = new ExcelPackage(fileInfo);

            var workSheet = excel.Workbook.Worksheets["Sheet1"];

            // Tạo QR Code và thêm vào file Excel
            string tempPath1 = Path.GetTempFileName() + ".png";
            DotNetBarcode QR1 = new DotNetBarcode();
            var QRCodeContent1 = "C" + managementCode;
            QR1.Type = DotNetBarcode.Types.QRCode;
            QR1.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
            QR1.Save(QRCodeContent1, tempPath1, 775, 206);

            var picture1 = workSheet.Drawings.AddPicture("XX1", new FileInfo(tempPath1));
            picture1.SetPosition(6, 8, 6, 1);
            picture1.SetSize(250, 250);

            // Code cho Case Label
            workSheet.Cells["H3"].Value = managementCode;
            workSheet.Cells["H4"].Value = locationName;

            //Tạo Mã QR Drawer Label
            string tempPath2 = Path.GetTempFileName() + ".png";
            DotNetBarcode QR2 = new DotNetBarcode();
            var QRCodeContent2 = "D" + managementCode;
            QR2.Type = DotNetBarcode.Types.QRCode;
            QR2.SaveFileType = DotNetBarcode.SaveFileTypes.Png;
            QR2.Save(QRCodeContent2, tempPath2, 775, 206);

            //using (Image image2 = Image.FromFile(tempPath2))
            //{

            //    //Image image1 = Image.FromStream(ms1);
            //    var picture2 = workSheet.Drawings.AddPicture("XX2", image2);
            //    picture2.SetPosition(27, 8, 6, 1);
            //    picture2.SetSize(250, 250);
            //}

            // Thêm hình ảnh QR Code vào file Excel
            var picture2 = workSheet.Drawings.AddPicture("XX2", new FileInfo(tempPath2));
            picture2.SetPosition(27, 8, 6, 1);
            picture2.SetSize(250, 250);
            //Code cho Drawer Label
            workSheet.Cells["H24"].Value = managementCode;
            workSheet.Cells["H25"].Value = locationName;

            // Lưu file Excel
            excel.Save();

            // In file Excel
            //Task.Run(() => PrintExcelFile(destination));
            PrintExcelFile(destination);
        }

        private void PrintExcelFile(string filePath)
        {
            // Khởi tạo đối tượng Excel
            //var excelApp = new Microsoft.Office.Interop.Excel.Application();
            //var workbook = excelApp.Workbooks.Open(filePath);
            //excelApp.Visible = true; // Ẩn Excel

            //// Mở hộp thoại in của Excel**
            //excelApp.Dialogs[Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogPrint].Show();

            //// Đóng workbook mà không lưu thay đổi
            //workbook.Close(false);
            //excelApp.Quit();


            var excelApp = new Microsoft.Office.Interop.Excel.Application();

            try
            {
                // Ẩn Excel để không hiển thị giao diện
                excelApp.Visible = true;

                // Mở workbook nhưng không hiển thị
                var workbook = excelApp.Workbooks.Open(filePath, ReadOnly: true);

                // Mở trực tiếp hộp thoại in
                excelApp.Dialogs[Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogPrint].Show();

                // Đóng workbook mà không lưu thay đổi
                workbook.Close(false);
                // Xóa file
                File.Delete(filePath);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in tệp Excel: {ex.Message}");
            }
            finally
            {
                // Đảm bảo Excel được thoát hoàn toàn để giải phóng tài nguyên
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp); // Giải phóng đối tượng COM
            }
        }

        //Nhấn Refresh để load dữ liệu form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowLocation();
            gridViewPrintQR.IndicatorWidth = 40;
            gridViewPrintQR.ClearSelection();
            gridViewPrintQR.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewPrintQR.OptionsSelection.EnableAppearanceFocusedRow = false;
            //Reset lại biến chọn địa điểm
            GManagementCode = "";
            GLocationName = "";
        }


    }
}