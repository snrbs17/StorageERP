using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStorageERP.Client
{
    public static class Clients
    {
        public static CustomersClient Customers = new CustomersClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static CustomerTypesClient CustomerTypes = new CustomerTypesClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static EmployeesClient Employees = new EmployeesClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static FacilitiesClient Facilities = new FacilitiesClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static FakeAccountInfoesClient FakeAccountInfoes = new FakeAccountInfoesClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static FaresClient Fares = new FaresClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static PurchaseItemsClient PurchaseItems = new PurchaseItemsClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static PurchasesClient Purchases = new PurchasesClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static RegionsClient Regions = new RegionsClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static StoragesClient Storages = new StoragesClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static StorageSizesClient StorageSizes = new StorageSizesClient("http://localhost:17827", new System.Net.Http.HttpClient());
        public static StorageTypesClient StorageTypes = new StorageTypesClient("http://localhost:17827", new System.Net.Http.HttpClient());
    }
}
