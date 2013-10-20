using System;

namespace Model.Entity
{
    [Serializable]
    public class UserNotification
    {
        public int NotiID { get; set; }
        public string NotiName { get; set; }
        public string NotiContent { get; set; }
    }
}
