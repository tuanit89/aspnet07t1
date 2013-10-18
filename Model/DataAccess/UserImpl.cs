using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entity;

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
            return null;
        }

        public User Register(string username,string password, string email)
        {
            return null;
        }

        public User FacebookRegister(User user)
        {
            return null;
        }

        
            
    }
}
