#region using

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace DBService.Domain
{
    [Serializable]
    public abstract class BaseClass
    {
        public int Id { get; set; }
    
        public bool Active { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        protected BaseClass()
        {
            Active = true;
        }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
