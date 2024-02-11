using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAdo.BLL.Entities
{
    public class Title: EntityBase
    {
        private string pvTitle;
        private string? pvpub_id;
        private decimal pvprice;
        private string pvNotes;
        public string title_id { get; set; }
        
        public string title
        {
            get => pvTitle;
            set
            {
                if (pvTitle != value)
                {
                    pvTitle = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
        public string? pub_id { get=> pvpub_id; set {
                if (pvpub_id != value)
                {
                    pvpub_id = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            } }


        public decimal price
        {
            get => pvprice; set
            {
                if (pvprice != value)
                {
                    pvprice = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
        public decimal advance { get; set; }
        public int royalty { get; set; }
        public int ytd_sales { get; set; }
        public string? notes
        {
            get => pvNotes; set
            {
                if (pvNotes != value)
                {
                    pvNotes = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }

    }

}
