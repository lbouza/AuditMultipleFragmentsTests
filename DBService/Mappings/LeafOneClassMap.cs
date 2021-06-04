using System.CodeDom;
using DBService.Domain;

namespace DBService.Mappings
{
    public class LeafOneClassMap:BaseEntityMap<LeafOneClass>
    {
        public LeafOneClassMap()
        {
            Map(t => t.Requires(m => m.Type).Equals(Discriminator.LeafOne)).ToTable("LeafOneClass");
        }
    }
}