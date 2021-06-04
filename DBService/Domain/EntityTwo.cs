#region using

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

#endregion

namespace DBService.Domain
{
    public class EntityTwo :BaseClass
    {
        #region Constructors

        public EntityTwo()
        {
           
        }

        #endregion

        #region Local Values

        [MaxLength(25)]
        public string Code { get; set; }
        

        #endregion

    }
}