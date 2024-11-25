using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANACANPC
{
    class FileConfig
    {
        SQLConnection objConnection = new SQLConnection();
        //Read Data from SQL.ini file
        public static bool ReadSqlConfig()
        {
            try
            {

                String path = Application.StartupPath + "/SQL.ini";
                string line = System.IO.File.ReadAllLines(path)[0];
                String[] arr = line.Split(',');
                GlobalVariables.ServerName = arr[0];
                GlobalVariables.DatabaseName = arr[1];
                GlobalVariables.UserDB = arr[2];
                GlobalVariables.PassDB = arr[3];

                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        //Write Data from SQL.ini file
        public static bool WriteConfig(string ServerName, string DBName, string LoginName, string Password)
        {
            try
            {

                try
                {

                    String path = Application.StartupPath + "/SQL.ini";
                    System.IO.File.WriteAllText(path, ServerName + "," + DBName + "," + LoginName + "," + Password);

                    return true;

                }
                catch (Exception)
                {

                    return false;
                }

            }
            catch (Exception)
            {
                return false;

            }

        }

        ///Read pass from PassSetting.ini file
        public static bool ReadPassConfig()
        {
            try
            {

                String path = Application.StartupPath + "/PassSetting.ini";
                string line = System.IO.File.ReadAllLines(path)[0];
                String[] arr = line.Split(',');
                GlobalVariables.PassOpenSetting = arr[0];
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        //Read Data from PassLogin.ini file
        public static bool ReadPassLoginConfig()
        {
            //Khai báo đối tượng mới của lớp để truy cập hàm tĩnh
            var FC = new FileConfig();
            try
            {
                string cmdText = "Select Password from Password";
                GlobalVariables.PassLogin = FC.objConnection.ExcuteCommandReturnString(cmdText);
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        //Read Data from Language.ini file
        public static bool ReadLanguage()
        {
            try
            {

                String path = Application.StartupPath + "/Language.ini";
                string line = System.IO.File.ReadAllLines(path)[0];
                String[] arr = line.Split(',');
                GlobalVariables.Languages = arr[0];
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
