using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStorageERP
{
    public static class Factors
    {
        public static Func<FakeAccountInfo, int> SelectTimeScope { get; set; }
        = x => x.Date.Month;
    }
}
