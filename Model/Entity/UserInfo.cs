using System;
using System.Collections.Generic;

namespace Model.Entity
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public int UserName { get; set; }

        public DateTime JoinDate { get; set; }
        public int TotalGags { get; set; }
        public int TotalLikes { get; set; }
        public int TotalComments { get; set; }
        public int Ranking { get; set; }
        public string Signature { get; set; }

        public List<GagInfo> ListPostGags(int pageIndex, int pageSize)
        {
            return null;
        } 
    }
}
