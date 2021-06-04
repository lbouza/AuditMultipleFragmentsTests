using System.Collections.Generic;

namespace DBService.Domain
{
    public class LeafTwoClass:MiddleClass
    {
        public LeafTwoClass()
        {
            Type = Discriminator.LeafTwo;
        }

//        public virtual ICollection<LeafThreeClass> PropertyCollection { get; set; }
    }
}