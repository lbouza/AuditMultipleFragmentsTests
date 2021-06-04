using System.Collections.Generic;

namespace DBService.Domain
{
    public class EntityOne:BaseClass
    {
        public virtual ICollection<M2MEntityOneEntityTwo> Tests { get; set; }
    }
}