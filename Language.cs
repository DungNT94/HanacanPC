using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HANACANPC
{
    class Language
    {
        public static void CkcLanguage()
        {
            switch (Convert.ToInt32(GlobalVariables.Languages))
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                    break;
            }


            // Cập nhật văn bản cho các control ứng với các resources
            //label1.Text = rm.GetString("frmLoginLabel1Text");
            //label3.Text = rm.GetString("frmLoginLabel3Text");
            //btnLogin.Text = rm.GetString("frmLoginbtnLoginText");
            //btnExit.Text = rm.GetString("frmLoginbtnExitText");
        }
    }
}
