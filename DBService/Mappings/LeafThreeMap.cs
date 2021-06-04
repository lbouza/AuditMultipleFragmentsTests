#region using

using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    internal class LeafThreeMap : BaseMap<LeafThree>
    {
        public LeafThreeMap()
        {
            // Db Mappings
            Map(t => t.Requires(m => m.Type).Equals(ItemType.Type2)).ToTable("LeafThree");
        }
    }
}
