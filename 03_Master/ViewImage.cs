using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HANACANPC._03_Master.frmDesignMaster;

namespace HANACANPC._03_Master
{
    public partial class ViewImage : DevExpress.XtraEditors.XtraForm
    {
        public ViewImage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        string imageUrl = "https://"+ GloUserMaster.ImageLnk + "";
        //Load form
        private void ViewImage_Load(object sender, EventArgs e)
        {
            ReviewImage(imageUrl);
        }

        /// <summary>
        /// HÀM HIỂN THỊ ẢNH
        /// </summary>
        /// <param name="filePath"></param>
        private  void ReviewImage( string filePath)
        {
            pictureBox1.Image = Image.FromFile(filePath);
        }
    }
}