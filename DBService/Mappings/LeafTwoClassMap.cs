using DBService.Domain;

namespace DBService.Mappings
{
    public class LeafTwoClassMap:BaseEntityMap<LeafTwoClass>
    {
        public LeafTwoClassMap()
        {
            Map(t => t.Requires(m => m.Type).Equals(Discriminator.LeafTwo)).ToTable("LeafTwoClass");
//            HasMany(x => x.PropertyCollection).WithMany();
        }
    }
}