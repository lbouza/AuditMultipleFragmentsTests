#region using

using System.Collections;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace DBService.Domain.Inheritance
{
    public class LeafFive : MiddleTwo
    {
        public virtual ICollection<EntityOne> Orders { get; set; }

        public LeafFive()
        {
            Type = ItemType.Type2;
        }

        public LeafFive(IEnumerable<EntityOne> orders)
        {
            Orders = new List<EntityOne>(orders);
        }

        public override IEnumerable AsEnumerable()
        {
            return Orders.Select(x=>x.Id);
        }
    }
}
