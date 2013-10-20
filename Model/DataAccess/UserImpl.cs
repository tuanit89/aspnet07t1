using System.Data;
using System.Data.SqlClient;
using Model.Entity;
using Models;

namespace Model.DataAccess
{
    public class UserImpl
    {
        public static readonly UserImpl Impl = new UserImpl();

        public User NormalLogin(string email, string password)
        {
            using (var cn = new SqlConnection(Config.ConnectString))
            {
                var cmd = new SqlCommand("User_LoginNormal", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cn.Open();
                var reader = cmd.ExecuteReader();
                var info = new User();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        info.Fullname = reader.GetString(reader.GetOrdinal("Fullname"));
                        info.JoinedDate = reader.GetDateTime(reader.GetOrdinal("JoinedDate"));
                        info.Gender = reader.GetBoolean(reader.GetOrdinal("Gender"));
                        info.Id = reader.GetInt32(reader.GetOrdinal("UserId"));
                        info.Email = reader.GetString(reader.GetOrdinal("Email"));
                        info.Status = reader.GetBoolean(reader.GetOrdinal("Status"));
                        info.Verified = reader.GetBoolean(reader.GetOrdinal("Verified"));
                        info.Country = reader.GetString(reader.GetOrdinal("Country"));
                        info.ProfilePicture = reader.GetString(reader.GetOrdinal("ProfilePicture"));

                        if (!reader.IsDBNull(reader.GetOrdinal("Website")))
                        {
                            info.Website = reader.GetString(reader.GetOrdinal("Website"));
                        }
                        info.ErrorStatus = User.EStatusError.Normal;
                        if (!reader.IsDBNull(reader.GetOrdinal("LastLogin")))
                        {
                            info.LastLogin = reader.GetDateTime(reader.GetOrdinal("LastLogin"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("RememberMe")))
                        {
                            info.RememberMe = reader.GetBoolean(reader.GetOrdinal("RememberMe"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("Pwd")))
                        {
                            info.Password = reader.GetString(reader.GetOrdinal("Pwd"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("Ip")))
                        {
                            info.RememberIp = reader.GetBoolean(reader.GetOrdinal("Ip"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("LastIp")))
                        {
                            info.LastIp = reader.GetString(reader.GetOrdinal("LastIp"));
                        }
                    }
                }
                else
                {
                    info.ErrorStatus = User.EStatusError.NotFound;
                }
                return info;
            }
        }

        public User FacebookLogin(string email)
        {
            using (var cn = new SqlConnection(Config.ConnectString))
            {
                var cmd = new SqlCommand("User_LoginFacebook", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                cmd.Parameters.AddWithValue("@Email", email);
                cn.Open();
                var reader = cmd.ExecuteReader();
                var info = new User();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        info.Fullname = reader.GetString(reader.GetOrdinal("Fullname"));
                        info.JoinedDate = reader.GetDateTime(reader.GetOrdinal("JoinedDate"));
                        info.Gender = reader.GetBoolean(reader.GetOrdinal("Gender"));
                        info.Id = reader.GetInt32(reader.GetOrdinal("UserId"));
                        info.Email = reader.GetString(reader.GetOrdinal("Email"));
                        info.Status = reader.GetBoolean(reader.GetOrdinal("Status"));
                        info.Verified = reader.GetBoolean(reader.GetOrdinal("Verified"));
                        info.Country = reader.GetString(reader.GetOrdinal("Country"));
                        info.ProfilePicture = reader.GetString(reader.GetOrdinal("ProfilePicture"));

                        if (!reader.IsDBNull(reader.GetOrdinal("FacebookID")))
                        {
                            info.FacebookID = reader.GetString(reader.GetOrdinal("FacebookID"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("Description")))
                        {
                            info.Description = reader.GetString(reader.GetOrdinal("Description"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("Website")))
                        {
                            info.Website = reader.GetString(reader.GetOrdinal("Website"));
                        }
                        info.ErrorStatus = User.EStatusError.Normal;
                        if (!reader.IsDBNull(reader.GetOrdinal("LastLogin")))
                        {
                            info.LastLogin = reader.GetDateTime(reader.GetOrdinal("LastLogin"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("RememberMe")))
                        {
                            info.RememberMe = reader.GetBoolean(reader.GetOrdinal("RememberMe"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("Pwd")))
                        {
                            info.Password = reader.GetString(reader.GetOrdinal("Pwd"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("Ip")))
                        {
                            info.RememberIp = reader.GetBoolean(reader.GetOrdinal("Ip"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("LastIp")))
                        {
                            info.LastIp = reader.GetString(reader.GetOrdinal("LastIp"));
                        }
                    }
                }
                else
                {
                    info.ErrorStatus = User.EStatusError.NotFound;
                }
                return info;
            }
        }

        public User NormalRegister(string username,string password, string email)
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

                user = FacebookLogin(user.Email);
                return user;
            }
        }

        
            
    }
}
