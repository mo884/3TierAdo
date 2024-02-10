using _3TierAdo.BLL.Entities;
using _3TierAdo.BLL.EntityLists;
using _3TierAdo.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAdo.BLL.EntityManger
{
    public class PublisherMange
    {
        static DBManger dBManger = new();
        public static PublisherList GetAllPuplisher()
        {
            PublisherList list = new();
            try
            {
                return DataTableToPublisherList(dBManger.ExecuteTable("GetAllPublisher"));
            }
            catch (Exception)
            {


            }
            return list;

        }

       


        #region Mapper
        internal static PublisherList DataTableToPublisherList(DataTable dataTable)
        {
            PublisherList publishers = new PublisherList();
            try
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    publishers.Add(DataRowToPublisher(item));
                }
            }
            catch (Exception)
            {


            }
            return publishers;
        }
        internal static Publisher DataRowToPublisher(DataRow datarow)
        {
            Publisher publisher = new();
            try
            {

                publisher.pub_id = datarow.Field<string>("pub_id");
                publisher.pub_name = datarow.Field<string?>("pub_name").ToString();
                

            }
            catch (Exception)
            {


            }
            return publisher;
        }


        #endregion
    }
}
