using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClientApp
{
    public class ClientModel
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-8KL3V0U\\SQLEXPRESS;database=DemontestOnline;uid=sa;pwd=123456");
            return conn;
        }
        
        public bool checkLogin(string user,string pass)
        {
            string sql = "SELECT* from tblstudent WHERE _username = @u and password = @p ";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", user);
            cmd.Parameters.AddWithValue("@p", pass);
            SqlDataReader rd = cmd.ExecuteReader();
            bool result = rd.HasRows;
            rd.Close();
            cmd.Connection.Close();
            return result;
        }

        public bool checkExam(string Examcode)
        {
            bool result = false;
            string sql = "SELECT*from tblExam WHERE _id = @id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", Examcode);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                string stt = red.GetString(2);
                result = stt.Equals("D");
            }
            cmd.Connection.Close();
            return result;
        }

    }
}
