#region using

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace DBService.Domain.Inheritance
{
    public class MiddleOne : Root
    {
        public virtual ICollection<EntityOne> Orders { get; set; }
        public virtual ICollection<EntityTwo> Tests { get; set; }
        public bool UseTestsSelectedJustForFilteringOrders { get; set; }

        public MiddleOne(IEnumerable<EntityOne> orders, IEnumerable<EntityTwo> tests, bool useTestsSelectedJustForFilteringOrders, DateTime? startDate = null, DateTime? endDate = null)
        {
            Orders = new List<EntityOne>(orders);
            Tests = new List<EntityTwo>(tests);
            StartDate = startDate;
            EndDate = endDate;
            UseTestsSelectedJustForFilteringOrders = useTestsSelectedJustForFilteringOrders;

            Type = ItemType.Type1;
        }

        protected MiddleOne()
        {
        }
        public override IEnumerable AsEnumerable()
        {
            return Orders.Select(x => x.Id);
        }
    }
}