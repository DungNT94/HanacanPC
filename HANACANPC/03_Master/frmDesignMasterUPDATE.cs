using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HANACANPC._03_Master.frmDesignMaster;

namespace HANACANPC._03_Master
{
    public partial class frmDesignMasterUPDATE : DevExpress.XtraEditors.XtraForm
    {
        public static class GloUserMaster1
        {
            public static String ImageName;
        }
        public frmDesignMasterUPDATE()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void frmDesignMasterUPDATE_Load(object sender, EventArgs e)
        {
            DesignFormStart();
        }

        /// <summary>
        /// HÀM CHUNG
        /// </summary>
        /// 

        //Hàm load dữ liệu khi load form
        private void DesignFormStart()
        {
            txtDesignCode.Text = GloUserMaster.DCode;
            txtDesignName.Text = GloUserMaster.DName;
            txtEAN.Text = GloUserMaster.ECode;
            lbl_ImageLink.Text = GloUserMaster.ImageLnk;
        }

        //Reset form Design Update
        private void RsetDesignUpdate()
        {
            txtDesignCode.Text = "";
            txtDesignName.Text = "";
            txtEAN.Text = "";
            lbl_ImageLink.Text = "";
        }
        //Hàm Update bản ghi được chọn và sửa trên Grid Control
        private void UdateDesignMaster()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
                conn.Open();
                //SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "Update MasterDesign set Name = N'" + txtDesignName.Text + "',EANCode = N'" + txtEAN.Text + "',ImgLink = N'" + lbl_ImageLink.Text + "' where Code = N'" + GloUserMaster.DCode + "'";
                cmd2.ExecuteNonQuery();
                conn.Close();
                ImportImage();

                //Đóng form design update
                this.Close();
                //Thông báo cập nhật thành công
                MessageBox.Show("Mã " + txtDesignCode.Text + " cập nhật thành công ( Design Code " + txtDesignCode.Text + " updated successfully ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Nhấn Delete để xóa ảnh được lưu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbl_ImageLink.Text = "";
        }

        //Nhấn import để chọn và đọc byte ảnh
        //Khai biến toàn cục
        public byte[] imageData;
        public string filePath;
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "file image (*.jpg, *.jpeg,*.png,*.gif,*.bmp,*.tiff) | *.jpg; *.jpeg; *.png;*.gif;*.bmp;*.tiff;";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {

                filePath = openfiledialog.FileName;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source=" + GlobalVariables.ServerName + ";initial catalog=" + GlobalVariables.DatabaseName + ";integrated security=false;user id=" + GlobalVariables.UserDB + ";password=" + GlobalVariables.PassDB + ";";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "updatemasterdesignp";
                cmd1.Parameters.AddWithValue("@dimage", Path.GetFileName(filePath));

                object rs = cmd1.ExecuteScalar();
                int kq = Convert.ToInt32(rs);

                if (kq == 3) //đã tồn tên ảnh
                {
                    DialogResult result = MessageBox.Show("đã tồn tại ảnh tên '" + Path.GetFileName(filePath) + "', có chắc chắn muốn ghi đè ảnh cũ? " +
                                                        "\n(an image with the name '" + Path.GetFileName(filePath) + "' already exists. are you sure you want to overwrite the old image?).", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //gán tên ảnh cho label
                        lbl_ImageLink.Text = Path.GetFileName(filePath);
                        imageData = File.ReadAllBytes(filePath);
                        conn.Close();
                    }
                    else
                    {
                        filePath = null;
                        return;
                        
                    }
                }
                else
                {
                    //gán tên ảnh cho label
                    lbl_ImageLink.Text = Path.GetFileName(filePath);
                    imageData = File.ReadAllBytes(filePath);
                    conn.Close();
                }
                // glousermaster1.imagename= lbl_imagelink.text;
            }

        }

        //Hàm Add image
        private async void ImportImage()
        {
            if (!string.IsNullOrEmpty(lbl_ImageLink.Text)&&!string.IsNullOrEmpty(filePath))
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("Image-Name", imageName);
                    client.DefaultRequestHeaders.Add("Image-Name", Path.GetFileName(filePath));

                    using (var content = new ByteArrayContent(imageData))
                    {
                        var response = await client.PostAsync("http://localhost:8686/Upload/UploadFromPC", content);

                        if (response.IsSuccessStatusCode)
                        {
                            //MessageBox.Show("Upload thành công");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi upload: " + response.ReasonPhrase);
                        }
                    }
                }
                
            }
            else
            {
                return;
            }
            
        }


        //Nhấn cancel để thoát và đóng form mà không lưu.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Nhấn Save để cập nhật thông tin bảng Design Master
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesignName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Tên Design ( please enter full Design Name ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtEAN.Text.Length != 13)
                {
                    MessageBox.Show("Mã EAN code có 13 ký tự ( EAN Code has 13 characters ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    UdateDesignMaster();
                }
            }
        }


        //Nhấn check để mở form View Ảnh
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (lbl_ImageLink.Text != "")
            {
                GloUserMaster1.ImageName = lbl_ImageLink.Text;
                //Mở form view ảnh
                ViewImages viewImages = new ViewImages();
                viewImages.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tồn tại ảnh (No image available).");
            }
            

        }
    }
}