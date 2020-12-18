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

    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(EmployeeMeta))]
    public partial class Employee
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(FacilityMeta))]
    public partial class Facility
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(FakeAccountInfo))]
    public partial class FakeAcountInfoc
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(FareMeta))]
    public partial class Fare
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(PurchaseMeta))]
    public partial class Purchase
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(PurchaseItemMeta))]
    public partial class PurchaseItem
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(RegionMeta))]
    public partial class Region
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(StorageMeta))]
    public partial class Storage
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(StorageSizeMeta))]
    public partial class StorageSize
    {
    }
    [JsonObject(MemberSerialization =MemberSerialization.OptIn)]
    [MetadataType(typeof(StorageTypeMeta))]
    public partial class StorageType
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
        [JsonProperty] public int FacilityId { get; set; }
        [JsonProperty] public string FacilitySpecDescription { get; set; }
        [JsonProperty]public int RegionId { get; set; }
        [JsonProperty] public int EmployeeId { get; set; }

    }
    public class FakeAccoutInfoMeta
    {
        [JsonProperty] public int InfoId { get; set; }
        [JsonProperty] public System.DateTime Date { get; set; }
        [JsonProperty] public int Sales { get; set; }
        [JsonProperty] public int OtherRevenues { get; set; }
        [JsonProperty] public int SalesReturns { get; set; }
        [JsonProperty] public int Depreciation { get; set; }
        [JsonProperty] public int Rent { get; set; }
        [JsonProperty] public int OtherSupplies { get; set; }
        [JsonProperty] public int Utilities { get; set; }
        [JsonProperty] public int Insurance { get; set; }
        [JsonProperty] public int Maintenance { get; set; }
        [JsonProperty] public int Advertising { get; set; }
        [JsonProperty] public int OtherExpenses { get; set; }

    }
    public class FareMeta
    {
        [JsonProperty] public int FareId { get; set; }
        [JsonProperty] public int StorageTypeId { get; set; }
        [JsonProperty] public int FarePerMinute { get; set; }
        [JsonProperty] public int StorageSizeId { get; set; }
    }
    public class PurchaseMeta
    {
        [JsonProperty] public int PurchaseId { get; set; }
        [JsonProperty] public System.DateTime PurchaseTime { get; set; }
        [JsonProperty] public string OtherDetails { get; set; }
        [JsonProperty] public int CustomerId { get; set; }
        [JsonProperty] public int PurchaseAmount { get; set; }
        [JsonProperty] public int TransactionId { get; set; }
    }
    public class PurchaseItemMeta
    {
        [JsonProperty] public int PurchaseItemId { get; set; }
        [JsonProperty] public System.DateTime InTime { get; set; }
        [JsonProperty] public System.DateTime OutTime { get; set; }
        [JsonProperty] public int StorageId { get; set; }
        [JsonProperty] public int PurchaseId { get; set; }
    }
    public class RegionMeta
    {
        [JsonProperty] public int RegionId { get; set; }
        [JsonProperty] public string City { get; set; }
        [JsonProperty] public string District { get; set; }
        [JsonProperty] public string Town { get; set; }
        [JsonProperty] public Nullable<decimal> Latitude { get; set; }
        [JsonProperty] public Nullable<decimal> Longitude { get; set; }
    }
    public class StorageMeta
    {    
        [JsonProperty] public int StorageId { get; set; }
        [JsonProperty] public int FacilityId { get; set; }
        [JsonProperty] public bool Activated { get; set; }
        [JsonProperty] public int FareId { get; set; }

    }
    public class StorageSizeMeta
    {
        [JsonProperty] public int StorageSizeId { get; set; }
        [JsonProperty] public int Width { get; set; }
        [JsonProperty] public int Height { get; set; }

    }
    public class StorageTypeMeta
    {
        [JsonProperty] public int StorageTypeId { get; set; }
        [JsonProperty] public string StorageTypeName { get; set; }
    }
}
