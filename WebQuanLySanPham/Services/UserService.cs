using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebQuanLySanPham.Models;

namespace WebQuanLySanPham.Services
{
    public class UserService
    {
        public static List<User> LoginClient(string _username, string _password)
        {
            List<User> users = new List<User>();
            SqlConnection conn = ConnectionDb.GetConnection();

            string sql = "SELECT Username, Password FROM [tbl__User] WHERE Username='"+_username+"' AND Password='"+_password+"' ";
            SqlCommand sqlcommand = new SqlCommand(sql, conn);
            sqlcommand.CommandType = System.Data.CommandType.Text;

            conn.Open();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                User user = new User
                {
                    Username = Convert.ToString(sqlDataReader["Username"]),
                    Password = Convert.ToString(sqlDataReader["Password"])
                };


                users.Add(user);
            }

            sqlDataReader.Close();
            conn.Close();
            conn.Dispose();
            return users;
        }
    }
}