#region using

using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    internal class MiddleOneMap : BaseMap<MiddleOne>
    {
        public MiddleOneMap()
        {
            // Db Mappings
            Map(t => t.Requires(m => m.Type).Equals(ItemType.Type1)).ToTable("MiddleOne");

            // One to Many
            HasMany(t => t.Orders)
                .WithMany();
            HasMany(t => t.Tests)
                .WithMany();
        }
    }
}