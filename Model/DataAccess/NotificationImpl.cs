using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model.Entity;

namespace Model.DataAccess
{
    public class NotificationImpl
    {
        public readonly static  NotificationImpl Impl = new NotificationImpl();

        public List<UserNotification> Notifications()
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand("select * from Sql")
            }
            return null;
        }

        public int UserNotificationUnread(int userID)
        {
            return 0;
        }
    }
}
