using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using System.Diagnostics;

namespace HANACANPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////OK 2 thư viện sau khi imprt xong

            //// var Path = String.Concat(DLfolder.Text, @"\");      //保存するパス名

            //string source_filename = Application.StartupPath + "\\Template\\LayoutQR.xlsx";
            //string desitnation = Application.StartupPath + "\\Export\\" + String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + ".xlsx";

            //File.Copy(source_filename, desitnation);
            //FileInfo fileInfo = new FileInfo(desitnation);
            //ExcelPackage excel = new ExcelPackage(fileInfo);
 
            //var workSheet = excel.Workbook.Worksheets["Sheet1"];
            ////Tạo Mã QR case Label
            //DotNetBarcode QR1 = new DotNetBarcode();
            //var QRCodeContent1 = "NOI DUNG QR";                         //作成するQRコード
            //QR1.Type = DotNetBarcode.Types.QRCode;               //QRコードを指定
            //QR1.SaveFileType = DotNetBarcode.SaveFileTypes.Png; //JPEGタイプで保存
            //string pathImage = Application.StartupPath + "\\Export\\";
            //string fileImage1 = String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + "1.png";
            //QR1.Save(QRCodeContent1, String.Concat(pathImage, fileImage1), 775, 206);
            //Image image1 = Image.FromFile(String.Concat(pathImage, fileImage1));
            //var picture1 = workSheet.Drawings.AddPicture("XX1", image1);
            //picture1.SetPosition(6, 8, 6, 1);
            //picture1.SetSize(250, 250);

            ////Tạo Mã QR Drawer Label
            //DotNetBarcode QR2 = new DotNetBarcode();
            //var QRCodeContent2 = "NOI DUNG QR";                         //作成するQRコード cũng có thể 1 giây nó ra 2 cái ảnh
            //QR2.Type = DotNetBarcode.Types.QRCode;               //QRコードを指定
            //QR2.SaveFileType = DotNetBarcode.SaveFileTypes.Png; //JPEGタイプで保存
            //string pathImage2 = Application.StartupPath + "\\Export\\";
            //string fileImage2 = String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + "2.png";
            //QR2.Save(QRCodeContent2, String.Concat(pathImage2, fileImage2), 775, 206);
            //Image image2 = Image.FromFile(String.Concat(pathImage2, fileImage2));
            //var picture2 = workSheet.Drawings.AddPicture("XX2", image2);
            //picture2.SetPosition(27, 8, 6, 1);
            //picture2.SetSize(250, 250);

            ////Code cho case Label
            //workSheet.Cells["H3"].Value = "Noi dung 1";
            //workSheet.Cells["H4"].Value = "Noi dung 2";

            ////Code cho Drawer Label
            //workSheet.Cells["H24"].Value = "Noi dung 3";
            //workSheet.Cells["H25"].Value = "Noi dung 4";

            ////đoạn này là khóa lại
            ////workSheet.Protection.IsProtected = true;
            ////workSheet.Protection.SetPassword("yosato");

            ////// Các quyền hạn được tùy chỉnh (có thể thay đổi tùy theo nhu cầu)
            ////workSheet.Protection.AllowSelectLockedCells = true; // Cho phép chọn ô khóa
            ////workSheet.Protection.AllowSelectUnlockedCells = true; // Cho phép chọn ô không khóa
            ////workSheet.Protection.AllowFormatCells = false; // Không cho phép định dạng lại ô
            ////workSheet.Protection.AllowEditObject = false; // Không cho phép chỉnh sửa object
            ////workSheet.Protection.AllowInsertColumns = false; // Không cho phép thêm cột
            ////workSheet.Protection.AllowInsertRows = false; // Không cho phép thêm hàng     



            //excel.Save();


            ////Tương tự với barcode số 2
            //Process.Start(desitnation);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string directoryPath = Application.StartupPath + "//Export";// Đường dẫn đến thư mục

            try
            {
                // Lấy tất cả các tệp trong thư mục
                string[] files = Directory.GetFiles(directoryPath);

                foreach (string file in files)
                {
                    File.Delete(file); // Xóa từng tệp
                    Console.WriteLine($"Đã xóa tệp: {file}");
                }

                Console.WriteLine("Đã xóa tất cả các tệp trong thư mục.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}

