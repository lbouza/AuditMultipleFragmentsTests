#region using

using System.Collections.Generic;

#endregion

namespace DBService.Domain.Inheritance
{
    public class LeafThree : MiddleThree
    {
        //Needed by EntityFramework
        public LeafThree()
        {
        }

        public LeafThree(IEnumerable<EntityOne> orders, IEnumerable<EntityTwo> tests, bool useTestsSelectedJustForFilteringOrders, bool? isIncludePending)
            : base(orders, tests, useTestsSelectedJustForFilteringOrders, isIncludePending)
        {
        }
    }
}
