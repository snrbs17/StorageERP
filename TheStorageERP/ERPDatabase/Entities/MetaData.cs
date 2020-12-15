using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDatabase
{
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(CustomerTypeMeta))]
    public partial class CustomerType
    {
    }

    public class CustomerTypeMeta
    {
        [JsonProperty] public int CustomerTypeId { get; set; }
        [JsonProperty] public string CustomerTypeDescription { get; set; }
    }

    public class EmployeeMeta
    {
        [JsonProperty] public int EmployeeId { get; set; }
        [JsonProperty] public string Name { get; set; }
    }

    public class FacilityMeta
    {
        public int FacilityId { get; set; }
        public string FacilitySpecDescription { get; set; }
        public int RegionId { get; set; }
        public int EmployeeId { get; set; }

    }
    public class FakeAccoutInfo
    {
        public int InfoId { get; set; }
        public System.DateTime Date { get; set; }
        public int Sales { get; set; }
        public int OtherRevenues { get; set; }
        public int SalesReturns { get; set; }
        public int GrossProfit { get; set; }
        public int Wages { get; set; }
        public int Depreciation { get; set; }
        public int Rent { get; set; }
        public int OtherSupplies { get; set; }
        public int Utilities { get; set; }
        public int Insurance { get; set; }
        public int Maintenance { get; set; }
        public int Advertising { get; set; }
        public int OtherExpenses { get; set; }

    }
    public class FareMeta
    {
        public int FareId { get; set; }
        public int StorageTypeId { get; set; }
        public int FarePerMinute { get; set; }
        public int StorageSizeId { get; set; }
    }
    public class PurchaseMeta
    {
        public int PurchaseId { get; set; }
        public System.DateTime PurchaseTime { get; set; }
        public string OtherDetails { get; set; }
        public int CustomerId { get; set; }
        public int PurchaseAmount { get; set; }
        public int TransactionId { get; set; }
    }
    public class PurchaseItemMeta
    {
        public int PurchaseItemId { get; set; }
        public System.DateTime InTime { get; set; }
        public System.DateTime OutTime { get; set; }
        public int StorageId { get; set; }
        public int PurchaseId { get; set; }
    }
    public class RegionMeta
    {
        public int RegionId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
    }
    public class StorageMeta
    {    
        public int StorageId { get; set; }
        public int FacilityId { get; set; }
        public bool Activated { get; set; }
        public int FareId { get; set; }

    }
    public class StorageSizeMeta
    {
        public int StorageSizeId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
    public class StorageTypeMeta
    {
        public int StorageTypeId { get; set; }
        public string StorageTypeName { get; set; }
    }
}
