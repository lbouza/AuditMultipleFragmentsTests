#region using

using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    class LeafFourMap : BaseMap<LeafFour>
    {
        public LeafFourMap()
        {
            // Db Mappings
            Map(t => t.Requires(m => m.Type).Equals(ItemType.Type3)).ToTable("LeafFour");
            
            // Many to Many
            HasMany(t => t.Tests)
                .WithMany();
        }
    }
}