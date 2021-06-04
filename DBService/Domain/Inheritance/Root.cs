#region using

using System;
using System.Collections;

#endregion

namespace DBService.Domain.Inheritance
{
    public abstract class Root : BaseClass
    {
        public ItemType Type { get; protected set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Attention { get; set; }
        public string AttentionComment { get; set; }

        public virtual IEnumerable AsEnumerable()
        {
            return null;
        }
    }
}