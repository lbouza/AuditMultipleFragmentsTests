#region using

using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    class LeafFiveMap : BaseMap<LeafFive>
    {
        public LeafFiveMap()
        {
            // Db Mappings
            Map(t => t.Requires(m => m.Type).Equals(ItemType.Type2)).ToTable("LeafFive");

            // Many to Many
            HasMany(t => t.Orders)
                .WithMany();
        }
    }
}
