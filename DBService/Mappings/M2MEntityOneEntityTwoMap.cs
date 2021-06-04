using DBService.Domain;

namespace DBService.Mappings
{
    internal class M2MEntityOneEntityTwoMap:BaseMap<M2MEntityOneEntityTwo>
    {
        public M2MEntityOneEntityTwoMap()
        {
            // One to many
            HasRequired(m => m.EntityTwo)
                .WithMany()
                .HasForeignKey(m => m.EntityTwoId);
        }
    }
}