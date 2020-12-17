using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStorageERP.Client;

namespace TheStorageERP.Entities
{
    class PieChartInfo
    {
        public string argument { get; set; }
        public int value { get; set; }
        

        /*public List<PieChartInfo> GetPieChartInfos()
        {
            var list = Clients.FakeAccountInfoes.GetFakeAccountInfoesAsync().Result
                .Sum(x=>x.Advertising)
        }*/
    }
}
