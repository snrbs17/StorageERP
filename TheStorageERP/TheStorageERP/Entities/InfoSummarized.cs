using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStorageERP.Entities
{
    public class InfoSummarized
    {
        public int _Date { get; set; }
        public int GrossProfit { get; set; }// sales + OtherRevenues + SalesReturns
        public int VariableCost { get; set; }//Utilities, OtherSupplies, Depreciation, Main, ad
        public int FixedCost { get; set; }//Wages, Rent, Insurance, OtherExpenses

    }
}
