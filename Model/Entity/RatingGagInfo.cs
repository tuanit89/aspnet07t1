using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entity
{
    public class RatingGagInfo
    {
        public int RatingGagId { get; set; }
        public int GagId { get; set; }

        public bool IsInsteresting { get; set; }
        public bool IsBoring { get; set; }
    }
}
