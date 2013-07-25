using System;

namespace Model.Entity
{
    public class GagInfo
    {
        public int Id { get; set; }
        public string GagName { get; set; }
        public int GagUserId { get; set; }

        public string GagTypeId { get; set; }
        public string GagLink { get; set; }

        public DateTime GagCreatedDate { get; set; }

        public int CategoryId { get; set; }

        
    }
}
