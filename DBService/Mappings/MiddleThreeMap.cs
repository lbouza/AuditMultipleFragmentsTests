#region using

using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    internal class MiddleThreeMap : BaseMap<MiddleThree>
    {
        public MiddleThreeMap()
        {
            // Db Mappings
            Map(t => t.Requires(m => m.Type).Equals(ItemType.Type2)).ToTable("MiddleThree");

            //not Mapped
            Ignore(x => x.IsIncludePendingResults);
        }
    }
}