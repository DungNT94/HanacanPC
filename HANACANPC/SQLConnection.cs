using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANACANPC
{
    class SQLConnection
    {
        //Khai báo 1 biến SqlConnection
        SqlConnection conn;
        SqlCommand cmd;
        public string ConnString { get; set; }
        public int code { get; set; }
        // Hàm Lấy chuỗi kết nối get connectionSting
        public string GetConnectionString()
        {
            if (FileConfig.ReadSqlConfig())
            {
                ConnString = "Data Source=" + GlobalVariables.ServerName + ";Initial Catalog=" + GlobalVariables.DatabaseName + ";Integrated Security=False;User ID=" + GlobalVariables.UserDB + ";Password=" + GlobalVariables.PassDB + ";";
            }
            return ConnString;

        }

        //Hàm mở kết nối SQL;
        public void OpenConnection()
        {
            conn = new SqlConnection(GetConnectionString());
            conn.ConnectionString = GetConnectionString();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        // Hàm đóng kết nối SQL
        public void CloseConnection()
        {
            conn.Close();
        }



        // Câu lệnh trả về kết quả cột đầu tiên của hàng đầu tiên trong tập kết quả,
        // sử dụng câu lệnh trực tiếp
        public string ExcuteCommandReturnString(String query)
        {

            try
            {

                OpenConnection();
                cmd = new SqlCommand(query, conn);
                
                String rs = cmd.ExecuteScalar().ToString();
                CloseConnection();
                return rs;

            }
            catch (Exception ex)
            {
                return "ERROR:" + ex;
            }

        }

        //New return have "where"
        public string CommandConditionReturnString(string UserCode)
        {

            try
            {
                string cmdText = "Select*from MasterUser where Code =@UserID";
                OpenConnection();
                cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = UserCode;
                String rs = cmd.ExecuteScalar().ToString();
                CloseConnection();
                return rs;

            }
            catch (Exception ex)
            {
                return "ERROR" + ex;
            }

        }


        //Hàm lấy dữ liệu từ bảng lên datatable
        public DataTable GetDataTable(String Query)
        {
            OpenConnection();
            SqlDataAdapter ada = new SqlDataAdapter();
            DataTable tb = new DataTable();
            ada.SelectCommand = new SqlCommand(Query, conn); ;
            //ada.SelectCommand.CommandText = Query;
            ada.Fill(tb);


            CloseConnection();
            return tb;
        }

        public DataSet TablesWithPara(string query)
        {
            DataSet objSet = new DataSet();

            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter objDa = new SqlDataAdapter(); objDa.SelectCommand = cmd;
                objDa.Fill(objSet);
                CloseConnection(); return objSet;
            }
            catch (Exception)
            {

                return null;
            }


        }


        
        //Hàm insert bảng UserMaster
        public void InsertUserMaster(string UserCode, string UserName)
        {

            OpenConnection();
            string cmdText = "insert into MasterUser (Code,Name)";
            cmdText += " values(@UserCode,@UserName)";
            cmd = new SqlCommand(cmdText, conn);
 
            cmd.Parameters.Add("@UserCode", SqlDbType.NChar).Value = UserCode;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;

            cmd.ExecuteNonQuery();
            CloseConnection();
            //return (rs > 0);
        }


    }
}
