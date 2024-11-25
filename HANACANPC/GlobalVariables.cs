using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANACANPC
{
    class GlobalVariables
    {
        //Global variable information about SQL
        public static string ServerName { get; set; }
        public static string UserDB { get; set; }
        public static string PassDB { get; set; }
        public static string DatabaseName { get; set; }

        //Global variable information about Login Password
        public static string PassLogin { get; set; }

        //Pass mở khóa setting Config
        public static string PassOpenSetting { get; set; }

        //Global variable information about Language
        public static string Languages { get; set; }

    }
}
