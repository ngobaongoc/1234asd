using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Adminapp
{
   public class AdminModel
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-8KL3V0U\\SQLEXPRESS;database=DemontestOnline;uid=sa;pwd=123456");
            return conn;
        }
        public Staff CheckLogin(string u, string p)
        {
            Staff staff = null;
            string sql = "Select * from tblStaff where username = @u and password=@p";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", u);
            cmd.Parameters.AddWithValue("@p", p);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                staff = new Staff();
                staff.Username = rd.GetString(0);
                staff.roles = rd.GetInt32(2);
                
            }
            cmd.Connection.Close();
            return staff;
        }
        public bool CheckExist(string id)
        {
            bool result = false;
            string sql = "SELECT * FROM tblQuestion WHERE _id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rd = cmd.ExecuteReader();
            result = rd.HasRows;
            cmd.Connection.Close();
            return !result;
        }
        public bool AddnewQuestion(string id, string content, string a, string b, string c, string d, string correct, string subject)
        {
            string sql = "INSERT  INTO tblQuestion VALUES(@id,@a,@b,@c,@d,@crr,@sid,@ct)";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@crr", correct);
            cmd.Parameters.AddWithValue("@sid", subject);
            cmd.Parameters.AddWithValue("@ct", content);

            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public DataTable GetQuestions()
        {
            string sql = "SELECT * FROM tblQuestion ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;
        }
        public bool DeleteQuetion(String id)
        {
            string sql = "DELETE FROM tblQuestion WHERE _id = @i";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;

        }
        public bool updatequestion(string id, string subject, string content, string correct, string a, string b, string c, string d)
        {
            string sql = "update tblquestion set _sid= @t,_content=@ct,_correct=@crr,_a=@a,_b=@b,_c=@c,_d=@d where _id=@i";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@t", subject);
            cmd.Parameters.AddWithValue("@ct", content);
            cmd.Parameters.AddWithValue("@crr", correct);
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public DataTable SearchbyID(string id)
        {
            string sql = "SELECT * FROM tblQuestion WHERE _id='" + id + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;

        }
    }
}
