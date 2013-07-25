using System;
using System.Collections.Generic;

namespace Model.Entity
{
    public class GagInfo
    {
        public int GagId { get; set; }
        public string GagName { get; set; }
        public int GagUserId { get; set; }
        public UserInfo User
        {
            get
            {
                return null;
            }
        }
        public string GagTypeId { get; set; }
        public string GagLink { get; set; }
        public string GetLinkByType
        {
            get
            {
                //nếu là image //

                //nếu là video

                return string.Empty;
            }
        }

        public DateTime GagCreatedDate { get; set; }

        public int CategoryId { get; set; }

        public int TotalVisits { get; set; }
        public int TotalComments { get; set; }
        public int TotalLikes { get; set; }

        public bool IsAdult { get; set; }

        public bool IsHomeMade { get; set; }
        public string FromCopy { get; set; }

        public bool IsApproved { get; set; }

        //Method for Gags
        //Danh sách đánh giá
        public List<RatingGagInfo> Ratings
        {
            get
            {
                return null;
            }
        }


    }
}
