using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStorageERP.Client;
using TheStorageERP.Entities;

namespace TheStorageERP.Dao
{
    public class InfoSummarizedDao
    {
        public List<InfoSummarized> GetInfoes()
        {
            var list = Clients.FakeAccountInfoes.GetFakeAccountInfoesAsync().Result
                .Where(x => x.Date.Year == DateTime.Now.Year)
                .GroupBy(Factors.SelectTimeScope, x => x, (timeUnit, Info) => new InfoSummarized
                {
                    _Date = timeUnit,
                    GrossProfit = Info.Sum(x => x.GrossProfit),
                    VariableCost = Info.Sum(x => x.Utilities + x.OtherSupplies + x.Depreciation + x.Maintenance + x.Advertising),
                    FixedCost = Info.Sum(x => x.Wages + x.Rent + x.Insurance + x.OtherExpenses)

                }).ToList();
            return list;
        }
    }
}
