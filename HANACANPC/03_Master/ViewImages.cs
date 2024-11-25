using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HANACANPC._03_Master.frmDesignMaster;
using static HANACANPC._03_Master.frmDesignMasterUPDATE;

namespace HANACANPC._03_Master
{
    public partial class ViewImages : DevExpress.XtraEditors.XtraForm
    {
        public ViewImages()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        /// <summary>
        /// Hàm view ảnh từ PictureBox
        /// </summary>
        //string imagePath = "..\\..\\..\\..\\HanacanCheckSytem\\HanacanCheckSytem\\Image\\" + GloUserMaster.ImageLnk;
        private async void ReviewImage()
        {
            //if (File.Exists(imagePath))
            //{
            //    pictureBox1.Image = Image.FromFile(imagePath);
            //}
            //else
            //{
            //    MessageBox.Show("Không tồn tại ảnh trong thư mục chứa ảnh (There is no photo in the folder containing photos).","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    this.Close();
            //}
            string imageName = GloUserMaster1.ImageName;
            using (var client = new HttpClient())
            {
                //string url = $"http://10.84.30.37:8686/Image/" + imageName; //Wifi guest
                //string url = $"http://10.84.26.06:8686/Image/" + imageName; //Wifi sato office
                string url = $"http://localhost:8686/Image/" + imageName; //Wifi sato

                var response = await client.GetAsync(url);
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        // Tải ảnh về dưới dạng mảng byte
                        byte[] imageBytes = webClient.DownloadData(url);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            // Chuyển đổi mảng byte thành đối tượng Image
                            Image image = Image.FromStream(ms);
                            // Gán ảnh cho PictureBox
                            pictureBox1.Image = image;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải hoặc không tồn tại ảnh: " + ex.Message);
                    }
                }
            }
        }

        //Load form
        private void ViewImages_Load(object sender, EventArgs e)
        {
            ReviewImage();
        }
    }
}