using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DBService.Domain.Inheritance
{
    public class LeafOne : Root
    {
        public LeafOne()
        {
            Type = ItemType.Type1;
        }

        public virtual ICollection<EntityOne> Orders { get; set; }

        public override IEnumerable AsEnumerable()
        {
            return Orders.Select(x => x.Id);
        }
    }
}