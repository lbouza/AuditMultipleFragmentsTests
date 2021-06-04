#region using

using System.Collections;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace DBService.Domain.Inheritance
{
    public class LeafTwo : MiddleOne
    {
        public bool? IncludePendingResults { get; set; }

        public bool? IncludeStandardTests { get;set; }
        public bool? IncludeMicrobiologyTests { get;set; }
        public bool? IncludeToxicologyTests { get;set; }
        public bool? IncludePathologyTests { get;set; }


        public LeafTwo(IEnumerable<EntityOne> orders, IEnumerable<EntityTwo> tests,
            bool useTestsSelectedJustForFilteringOrders,
            bool? isIncludePending,
            bool? includeStandardTests,
            bool? includeMicrobiologyTests,
            bool? includeToxicologyTests, bool? includePathologyTests)
            : base(orders, tests, useTestsSelectedJustForFilteringOrders)
        {
            IncludePendingResults = isIncludePending;

            IncludeStandardTests = includeStandardTests;
            IncludeMicrobiologyTests = includeMicrobiologyTests;
            IncludeToxicologyTests = includeToxicologyTests;
            IncludePathologyTests = includePathologyTests;
        }

        //Needed by EntityFramework
        public LeafTwo()
        {
        }
        public override IEnumerable AsEnumerable()
        {
            return Orders.Select(x => x.Id);
        }
    }
}
