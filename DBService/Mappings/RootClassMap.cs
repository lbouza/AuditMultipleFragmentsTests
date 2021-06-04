using DBService.Domain;

namespace DBService.Mappings
{
    public class RootClassMap:BaseEntityMap<RootClass>
    {
        public RootClassMap()
        {
            Property(x => x.Type).IsRequired();
            ToTable("RootClasses");
        }
    }
}