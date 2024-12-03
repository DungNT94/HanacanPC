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

namespace HANACANPC._03_Master
{
    public partial class frmDesignMasterADD : DevExpress.XtraEditors.XtraForm
    {
        SQLConnection objConnection = new SQLConnection();
        frmDesignMaster frmDesignMaster = new frmDesignMaster();
        // Biến public
        //public static class GloDesignMaster
        //{
        //    public static String DCodeA;
        //    public static String DNameA;
        //    public static String ECodeA;
        //    public static String ImageLnkA;
        //}
        public frmDesignMasterADD()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            txtEAN.Text = "";
            lbl_ImageLink.Text = "";
        }

        //Nhấn import để chọn và đọc byte ảnh
        //Khai biến toàn cục
        public byte[] imageData;
        public string filePath;
        private void btnImport_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter= "File Image (*.jpg, *.jpeg,*.png,*.gif,*.bmp,*.tiff) | *.jpg; *.jpeg; *.png;*.gif;*.bmp;*.tiff;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                //Gán tên ảnh cho label
                lbl_ImageLink.Text = Path.GetFileName(filePath);
                imageData = File.ReadAllBytes(filePath);

            }
        }

        //Hàm Add ảnh
        private async void AddImage()
        {
            string IpServer  = string.Empty; // Khởi tạo mặc định;
            if (!string.IsNullOrEmpty(lbl_ImageLink.Text))
            {
                using (var client = new HttpClient())
                {
                    if (FileConfig.ReadSqlConfig())
                    {
                        IpServer = GlobalVariables.ServerName;
                    }
                    //client.DefaultRequestHeaders.Add("Image-Name", imageName);
                    client.DefaultRequestHeaders.Add("Image-Name", Path.GetFileName(filePath));

                    using (var content = new ByteArrayContent(imageData))
                    {
                        var response = await client.PostAsync("http://" + IpServer + ":8686/Upload/UploadFromPC", content);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Upload thành công");
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

        //Hàm Insert bản ghi bảng DesignMaster, validate mã code và tên ảnh
        private void IsertDesignMaster()
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
                cmd1.CommandText = "MasterDesignP";
                cmd1.Parameters.AddWithValue("@DCode", txtDesignCode.Text);
                cmd1.Parameters.AddWithValue("@DImage", lbl_ImageLink.Text);
                //cmd1.Parameters.AddWithValue("@ECode", txtEAN.Text);
                object rs = cmd1.ExecuteScalar();
                int kq = Convert.ToInt32(rs);
                //int code = Convert.ToInt32(rs);

                if (kq == 1) //Đã tồn tại cả mã Design
                {
                    MessageBox.Show("Mã Design đã tồn tại ( design code already exists ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }
                if (kq == 3 && lbl_ImageLink.Text!="" ) //Đã tồn tên ảnh
                {
                    DialogResult result = MessageBox.Show("Đã tồn tại ảnh tên '" + lbl_ImageLink.Text + "', có chắc chắn muốn ghi đè ảnh cũ? " +
                                                        "\n(An image with the name '" + lbl_ImageLink.Text + "' already exists. Are you sure you want to overwrite the old image?).", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cmd2.Connection = conn;
                        cmd2.CommandText = "insert into MasterDesign (Code,Name,EANCode,ImgLink) values (N'" + txtDesignCode.Text + "', N'" + txtDesignName.Text + "',N'" + txtEAN.Text + "',N'" + lbl_ImageLink.Text + "')";
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        AddImage();
                        ResetDesignForm();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    cmd2.Connection = conn;
                    cmd2.CommandText = "insert into MasterDesign (Code,Name,EANCode,ImgLink) values (N'" + txtDesignCode.Text + "', N'" + txtDesignName.Text + "',N'" + txtEAN.Text + "',N'" + lbl_ImageLink.Text + "')";
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    AddImage();
                    ResetDesignForm();
                    //frmDesignMaster.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Nhấn Add để thêm thông tin vào Database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesignCode.Text) || string.IsNullOrEmpty(txtDesignName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã Design và Tên Design ( please enter full Design Code and Design Name ).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                if (string.IsNullOrEmpty(txtEAN.Text) & string.IsNullOrEmpty(lbl_ImageLink.Text))
                {
                    DialogResult rs = MessageBox.Show("Chưa nhập Mã EAN và Ảnh, có chắc chắn muốn thêm? ( EAN code and photo not entered enough, are you sure you want to add? ).", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.Yes == rs)
                    {
                        if ((txtDesignCode.Text.Length != 5)){
                            MessageBox.Show("Số ký tự của Design Code là 5 (The number of characters for Design Code is 5).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            IsertDesignMaster();
                        }
                        
                    }
                    else
                    {
                        return;
                    }
                }
                else if (!string.IsNullOrEmpty(txtEAN.Text) & string.IsNullOrEmpty(lbl_ImageLink.Text))
                {

                    MessageBox.Show("Vui lòng thêm ảnh ( Please import image ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtEAN.Text) & !string.IsNullOrEmpty(lbl_ImageLink.Text))
                {

                    MessageBox.Show("Vui lòng thêm EAN code ( Please import EAN Code ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if ((txtDesignCode.Text.Length != 5 ||txtEAN.Text.Length!=13))
                    {
                        MessageBox.Show("Số ký tự của Design Code là 5 và EAN Code là 13 ( The number of characters for Design Code is 5 and EAN Code is 13' ).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        IsertDesignMaster();
                    }
                }

            }
        }

        //Nhấn Delete để xóa ảnh, ko lưu nữa
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            lbl_ImageLink.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}