#region using

using System.Collections;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace DBService.Domain.Inheritance
{
    public class LeafFour : MiddleTwo
    {
        public virtual ICollection<M2MEntityOneEntityTwo> Tests { get; set; }

        public LeafFour(IEnumerable<M2MEntityOneEntityTwo> tests)
        {
            Tests = new List<M2MEntityOneEntityTwo>(tests);
            Type = ItemType.Type3;
        }
        public LeafFour()
        {
        }
        public override IEnumerable AsEnumerable()
        {
            return Tests.Select(x => x.Id);
        }
    }
}