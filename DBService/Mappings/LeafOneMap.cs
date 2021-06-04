#region using

using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    internal class LeafOneMap : BaseMap<LeafOne>
    {
        public LeafOneMap()
        {
            // Db Mappings
            Map(t => t.Requires(m => m.Type).Equals(ItemType.Type4)).ToTable("LeafOne");

            // One to Many
            HasMany(t => t.Orders)
                .WithMany();
        }
    }
}