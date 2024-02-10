using _3TierAdo.BLL.Entities;
using _3TierAdo.BLL.EntityLists;
using _3TierAdo.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAdo.BLL.EntityManger
{
    public class TitleManger
    {
        static DBManger dBManger = new();
        public static TitleList GetAllTitle()
        {
            TitleList list = new();
            try
            {
               return DataTableToTitleList( dBManger.ExecuteTable("GetAllTitle"));
            }
            catch (Exception)
            {

                
            }
            return list;

        }

        public static bool EditeAllTitle(List<Title>updateTitles)
        {
            try
            {
                
                foreach (var item in updateTitles)
                {
                    Dictionary<string, object> keyValuePairs = new Dictionary<string, object>()
                    {
                        ["title_id"]=item.title_id,
                        ["title"] =item.title,
                        ["pub_id"] = item.pub_id,
                        ["price"]=item.price,
                        ["advance"] = item.advance,
                        ["royalty"] = item.royalty,
                        ["ytd_sales"] =item.ytd_sales,
                        ["notes"] = item.notes,
                       
                       
                    };
                    if (dBManger.ExecuteNonQuery("EditeAllTitle", keyValuePairs)<0)
                    {
                        return false;
                    }
                        
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool CreateTitle(List<Title> createTitles)
        {
            try
            {

                foreach (var item in createTitles)
                {
                    Dictionary<string, object> keyValuePairs = new Dictionary<string, object>()
                    {
                        ["title_id"]=item.title_id,
                        ["title"] =item.title,
                        ["type"] =item.title,
                        ["pub_id"] = item.pub_id,
                        ["price"]=item.price,
                        ["advance"] = item.advance,
                        ["royalty"] = item.royalty,
                        ["ytd_sales"] =item.ytd_sales,
                        ["notes"] = item.notes,
                        ["pubUpdate"] = DateTime.Now

                    };
                    if (dBManger.ExecuteNonQuery("CreateTitle", keyValuePairs)<0)
                    {
                        return false;
                    }

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool DeleteTitle(List<Title> delteTitles)
        {
            try
            {

                foreach (var item in delteTitles)
                {
                    Dictionary<string, object> keyValuePairs = new Dictionary<string, object>()
                    {
                        ["title_id"]=item.title_id,
                       

                    };
                    if (dBManger.ExecuteNonQuery("DeleteTitle", keyValuePairs)<0)
                    {
                        return false;
                    }

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Title GetTitleByID(string titleID)
        {
            try
            {

                
                    Dictionary<string, object> keyValuePairs = new Dictionary<string, object>()
                    {
                        ["title_id"]=titleID,


                    };
                return DataTableToTitleList(dBManger.ExecuteTable("GetTitleByID", keyValuePairs)).FirstOrDefault();



            }
            catch (Exception)
            {

                return new();
            }
        }

        public static bool EditeTitlePrice(string title_id, decimal price)
        {
            try
            {
                Dictionary<string, object> keyValuePairs = new Dictionary<string, object>()
                {
                    ["price"]=price,
                    ["title_id"]=title_id
                };
               return dBManger.ExecuteNonQuery("EditeTitlePrice", keyValuePairs)>0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        #region Mapper
        internal static TitleList DataTableToTitleList(DataTable dataTable)
        {
            TitleList titles = new TitleList();
            try
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    titles.Add(DataRowToTitle(item));
                }
            }
            catch (Exception)
            {

               
            }
            return titles;
        }
        internal static Title DataRowToTitle(DataRow datarow)
        {
            Title title = new();
            try
            {
                
                title.title_id = datarow.Field<string>("title_id");
                title.title = datarow.Field<string?>("title").ToString();
                title.pub_id =  datarow.Field<string?>("pub_id").ToString();
                title.notes =  datarow.Field<string?>("notes").ToString();
                title.price = datarow.Field<decimal?>("price");
                title.advance = datarow.Field<decimal?>("advance");

                if (int.TryParse(datarow.Field<int?>("royalty").ToString(), out int Tempdtint))
                    title.royalty = Tempdtint;
                else
                    title.royalty = 0;
                if (int.TryParse(datarow.Field<int?>("ytd_sales").ToString(), out  Tempdtint))
                    title.ytd_sales = Tempdtint;
                else
                    title.ytd_sales = 0;

                title.State = EntityState.Unchanged;

            }
            catch (Exception)
            {

                
            }
            return title;
        }


        #endregion
    }
}
