#region using

using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    internal class LeafTwoMap : BaseMap<LeafTwo>
    {
        public LeafTwoMap()
        {
            //Property
            Property(p => p.IncludePendingResults);

            // Db Mappings
            Map(t => t.Requires(m => m.Type).Equals(ItemType.Type2)).ToTable("LeafTwo");
        }
    }
}
