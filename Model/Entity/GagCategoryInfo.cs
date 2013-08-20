using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entity
{
    public class GagCategoryInfo
    {
        //Danh sách thuộc tính
        public int CategoryId { get; set; }
        public string CategoryName{get;set;}

        public string Description{get;set;}
        public string CategoryTitle{get;set;}

        //Thuoc tinh kieu quan he ER : 1 category se co nhieu Gag
        public List<GagInfo> ListGags(int pageIndex,int pageSize)
        {
            //Tam thoi chua viet truy van
            return null;
        }

    }
}
