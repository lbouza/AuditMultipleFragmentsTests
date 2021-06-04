using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audit.EntityFramework;
using DBService;

namespace AuditTest
{
    class Program
    {
        [MTAThread]
        static void Main(string[] args)
        {
            var evs =new List<EntityFrameworkEvent>();
            Audit.Core.Configuration.Setup().UseDynamicProvider(_ => _.OnInsert(ev =>
            {
                evs.Add(ev.GetEntityFrameworkEvent());
            }));

            Tests service = new Tests();
            service.Test();
        }
    }
}
