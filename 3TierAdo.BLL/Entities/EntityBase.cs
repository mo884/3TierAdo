using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAdo.BLL.Entities
{
    public class EntityBase
    {
        public EntityState State { get; set; } = EntityState.created;
    }
}
