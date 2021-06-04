#region using

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace DBService.Domain.Inheritance
{
    public class MiddleThree : MiddleOne
    {
        public bool? IsIncludePendingResults { get; set; }

        public MiddleThree(IEnumerable<EntityOne> orders, IEnumerable<EntityTwo> tests, bool useTestsSelectedJustForFilteringOrders, bool? isIncludePending, DateTime? startdate = null, DateTime? enddate = null)
            : base(orders, tests, useTestsSelectedJustForFilteringOrders, startdate, enddate)
        {
            Type = ItemType.Type2;
            IsIncludePendingResults = isIncludePending;
        }

        //Needed by EntityFramework
        public MiddleThree() { }

        public override IEnumerable AsEnumerable()
        {
            return Orders.Select(x => x.Id);
        }
    }
}