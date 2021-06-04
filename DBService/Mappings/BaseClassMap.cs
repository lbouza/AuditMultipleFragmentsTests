#region using

using System.Data.Entity.ModelConfiguration;
using DBService.Domain;

#endregion

namespace DBService.Mappings
{
    abstract class BaseMap<T> : EntityTypeConfiguration<T>
        where T: BaseClass
    {
        protected BaseMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Active)
                .IsRequired();
            Property(t => t.RowVersion)
                .IsRowVersion();
        }
    }
}