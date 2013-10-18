using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model.Entity;
using Models;

namespace Model.DataAccess
{
    public class UserImpl
    {
        public static readonly UserImpl Impl = new UserImpl();

        public User NormalLogin(string username, string password)
        {
            return null;
        }

        public User FacebookLogin(string username)
        {
            using(var cn =  new )
            return null;
        }

        public User Register(string username,string password, string email)
        {
            return null;
        }

        public User FacebookRegister(User user)
        {
            using (var cn = new SqlConnection(Config.ConnectString))
            {
                var cmd = new SqlCommand("User_RegisterFacebook",cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                cmd.Parameters.AddWithValue("@FacebookID",user.FacebookID);
                cmd.Parameters.AddWithValue("@Fullname", user.Fullname);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@ProfilePicture", user.ProfilePicture);
                cmd.Parameters.AddWithValue("@Status", user.Status);
                cmd.Parameters.AddWithValue("@Verified", user.Verified);
                cmd.Parameters.AddWithValue("@Country", user.Country);
                cmd.Parameters.AddWithValue("@Description", user.Description);
                cmd.Parameters.AddWithValue("@JoinedDate", user.JoinedDate);

                cmd.Connection.Open();
                var k = cmd.ExecuteNonQuery();
                cn.Close();
            }
            return null;
        }

        
            
    }
}
