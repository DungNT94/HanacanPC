using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmDesignMaster : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        // Biến public
        public static class GloUserMaster
        {
            public static String DCode;
            public static String DName;
            public static String ECode;
            public static String ImageLnk;
            public static String ImageName;
        }

        public frmDesignMaster()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmDesignMaster_Load(object sender, EventArgs e)
        {
            ShowDesignMaster();
            //Tăng chiều rộng cột STT
            gridView1.IndicatorWidth = 40; 
        }
        
        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// 
        //Hàm reset trường trên form DesignMaster
        private void ResetDesignForm()
        {
            txtDesignCode.Text = "";
            txtDesignName.Text = "";
            txtEANCode.Text = "";
        }

        // Hàm hiển thị dữ liệu User trên gridControl
        public void ShowDesignMaster()
        {

            string query = "select * from MasterDesign";
            DataTable dttb = objConnection.GetDataTable(query);
            gridControl1.DataSource = dttb;
            gridView1.ClearSelection();
        }

        //Thêm Cột Đánh STT tự động

        private void gridView1_CustomDrawRowIndicator_1(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CustomGridview.Instance.CustomDrawRowIndicator(e);
            
        }

        //Hàm lấy dữ liệu sau khi click cell
        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            GloUserMaster.DCode = gridView1.GetFocusedRowCellValue("Code").ToString().Trim();
            txtDesignCode.Text = GloUserMaster.DCode;

            GloUserMaster.DName = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtDesignName.Text = GloUserMaster.DName;

            GloUserMaster.ECode = gridView1.GetFocusedRowCellValue("EANCode").ToString();
            txtEANCode.Text = GloUserMaster.ECode;

            GloUserMaster.ImageLnk = gridView1.GetFocusedRowCellValue("ImgLink").ToString();
            
        }

        //Hàm xóa bản ghi được chọn trên Grid Control
        private void DleteDesignMaster()
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
                        cmd2.CommandText = "Delete from MasterDesign where Code IN (" + Codes + ")";
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        ResetDesignForm();
                        ShowDesignMaster();
                        //gridView1.ClearSelection();
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

        //Nhấn Add để mở popup add thêm thông tin Design
        private frmDesignMasterADD frmDesignMasterADD;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDesignMasterADD = new frmDesignMasterADD();
            frmDesignMasterADD.ShowDialog();
            ShowDesignMaster();
            ResetDesignForm();

        }

        //Nhấn Delete để xóa bản ghi
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DleteDesignMaster();
        }

        //Nhấn Update để mở popup chỉnh sửa thông tin Design
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int[] SelectRows = gridView1.GetSelectedRows();
            if (SelectRows.Length==1)
            {
                frmDesignMasterUPDATE frmDesignMasterUPDATE = new frmDesignMasterUPDATE();
                frmDesignMasterUPDATE.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã để nhấn cập nhật ( Please select one code to update ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridView1.ClearSelection();
                ResetDesignForm();
                return;
            }
            ShowDesignMaster();
            ResetDesignForm();
        }

        //Doauble click để mở forn update
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            //frmDesignMasterUPDATE frmDesignMasterUPDATE = new frmDesignMasterUPDATE();
            //frmDesignMasterUPDATE.ShowDialog();
            //ShowDesignMaster();
            //ResetDesignForm();
        }

        //Nhấn nút Refresh để load dữ liệu form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDesignMaster();
            //Tăng chiều rộng cột STT
            gridView1.IndicatorWidth = 40;
        }

        //Sự kiện click chuột vào dòng của Gridview thì checkbox của dòng sẽ thay đổi theo

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            // Xác định vị trí của cell được nhấn
            var LocationRow = gridView1.CalcHitInfo(e.Location);

            // Kiểm tra nếu nhấn vào một cell trong dòng
            if (LocationRow.InRowCell)
            {

                // Kiểm tra xem có nhấn vào cột checkbox không
                // Giả sử cột checkbox là cột đầu tiên trong danh sách cột
                //GridColumn checkBoxColumn = gridView1.Columns.FirstOrDefault(c => c.OptionsColumn.AllowEdit && c.FieldName == "IsChecked"); // Thay "IsChecked" bằng tên trường của bạn

                //// Nếu nhấn vào checkbox, không làm gì để DevExpress tự xử lý
                //if (checkBoxColumn != null && LocationRow.Column == checkBoxColumn)
                //{
                //    return; // Để DevExpress tự xử lý checkbox
                //}


                int rowHandle = LocationRow.RowHandle;
                // Kiểm tra trạng thái chọn của dòng
                if (gridView1.IsRowSelected(rowHandle))
                {
                    // Nếu đã được chọn, bỏ chọn
                    gridView1.UnselectRow(rowHandle);
                }
                else
                {
                    // Nếu chưa được chọn, chọn dòng
                    gridView1.SelectRow(rowHandle);
                }
            }
            */
        }

        // Click cell image để hiển thị ảnh
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView View = sender as GridView;
            //GloCompensationLog.CTicketQR = View.GetFocusedRowCellValue("TicketQR").ToString().Trim();
            if (View.FocusedColumn.FieldName == "ImgLink")
            {
                if (GloUserMaster.ImageLnk != "" || !string.IsNullOrEmpty(GloUserMaster.ImageLnk))
                {
                    GloUserMaster.ImageName = GloUserMaster.ImageLnk;
                    //Mở form view ảnh
                    ViewImagesFormGridview viewImagesFormGridview = new ViewImagesFormGridview();
                    viewImagesFormGridview.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}