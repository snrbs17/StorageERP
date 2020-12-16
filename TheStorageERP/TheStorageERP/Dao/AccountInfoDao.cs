using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStorageERP.Client;
using TheStorageERP.Entities;

namespace TheStorageERP.Dao
{
    public class AccountInfoDao
    {
        List<FakeAccountInfo> data = Clients.FakeAccountInfoes.GetFakeAccountInfoesAsync().Result.ToList();

        //Func<FakeAccountInfo, int> SelectTimeScope = x => x.Date.Day;

        public List<InfoReorganized> GetInfoReorganized(Func<FakeAccountInfo, int> SelectTimeScope)
        {
            var value = Clients.FakeAccountInfoes.GetFakeAccountInfoesAsync().Result
                .Where(x => x.Date.Year == DateTime.Now.Year)
                .GroupBy(SelectTimeScope, x => x,
                (timeUnit, info) => new InfoReorganized
                {
                    InfoId = timeUnit,
                    Sales = info.Sum(x => x.Sales),
                    OtherRevenues = info.Sum(x => x.OtherRevenues),
                    SalesReturns = info.Sum(x => x.SalesReturns),
                    GrossProfit = info.Sum(x => x.GrossProfit),
                    Wages = info.Sum(x => x.Wages),
                    Depreciation = info.Sum(x => x.Depreciation),
                    Rent = info.Sum(x => x.Rent),
                    OtherSupplies = info.Sum(x => x.OtherSupplies),
                    Utilities = info.Sum(x => x.Utilities),
                    Insurance = info.Sum(x => x.Insurance),
                    Maintenance = info.Sum(x => x.Maintenance),
                    Advertising = info.Sum(x => x.Advertising),
                    OtherExpenses = info.Sum(x => x.OtherExpenses),
                });
            return value.OrderBy(x =>x.InfoId).ToList();
        }
    }
}
