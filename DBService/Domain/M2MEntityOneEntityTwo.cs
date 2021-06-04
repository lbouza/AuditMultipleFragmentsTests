#region using

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace DBService.Domain
{
    public class M2MEntityOneEntityTwo : BaseClass
    {
        #region Constructors

        public M2MEntityOneEntityTwo()
        {
           
        }

        #endregion

        public int EntityOneId { get; set; }
        public virtual EntityOne EntityOne { get; set; }

        public int EntityTwoId { get; set; }
        public virtual EntityTwo EntityTwo { get; set; }

        public int Level { get; set; }
    }
}