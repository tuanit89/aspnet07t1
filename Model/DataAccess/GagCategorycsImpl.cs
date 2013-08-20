using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entity;
using System.Data.SqlClient;
using Models;

namespace Model.DataAccess
{
    public class GagCategorycsImpl
    {
        public int add(GagCategoryInfo Info)
        {
            var param = new[] 
            {
                new SqlParameter("@CategoryName",Info.CategoryName),
                new SqlParameter("@CategoryTitle",Info.CategoryTitle),
                new SqlParameter("@CategoryTitle",Info.Description)
            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_GagCategory_Add", param);
        }
        public int Update(GagCategoryInfo Info)
        {
            var param = new[] 
            { 
                new SqlParameter("@CategoryId",Info.CategoryId),
                new SqlParameter("@CategoryName",Info.CategoryName),
                new SqlParameter("@CategoryTitle",Info.CategoryTitle),
                new SqlParameter("@Description",Info.Description)
            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_GagCategory_Update", param);
        }
        public int Delete(int id)
        {
            var param = new[]
            {
                new SqlParameter("@CategoryId",id)
            };
            return DataHelper.ExecuteNonQuery(Config.ConnectString, "usp_GagCategory_Delete", param);
        }
        public GagCategoryInfo GetInfo(int id)
        {
            GagCategoryInfo Info = null;
            var param = new[] { 
                new SqlParameter("@CategoryId",id)
            };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_GagCategory_GetByID", param);
            if (r != null)
            {
                Info = new GagCategoryInfo();
                while (r.Read())
                { 
                    Info.CategoryId = Int32.Parse(r["CategoryId"].ToString());
                    Info.CategoryName = r["CategoryName"].ToString();
                    Info.CategoryTitle = r["CategoryTitle"].ToString();
                    Info.Description = r["Description"].ToString();
                }
                r.Close();
                r.Dispose();
            }
            return Info;
        }
        public GagCategoryInfo GetList()
        {
            GagCategoryInfo Info = null;
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_GagCategory_GetList");
            if (r != null)
            {
                while (r.Read())
                {
                    Info = new GagCategoryInfo();
                    Info.CategoryId = Int32.Parse(r["CategoryID"].ToString());
                    Info.CategoryName = r["CategoryName"].ToString();
                    Info.CategoryTitle = r["CategoryTitle"].ToString();
                    Info.Description = r["Description"].ToString();
                }
                r.Close();
                r.Dispose();
            }
            return Info;
        }
    }
}
