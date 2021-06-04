#region using

using System.ComponentModel.DataAnnotations.Schema;
using DBService.Domain;
using DBService.Domain.Inheritance;

#endregion

namespace DBService.Mappings
{
    class RootMap : BaseMap<Root>
    {
        public RootMap()
        {
            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Type)
                .IsRequired();

            // Db Mappings
            ToTable("TransmissionItems");
        }
    }
}