using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERPDatabase
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [MetadataType(typeof(CustomerMeta))]
    public partial class Customer
    {
    }

    public class CustomerMeta
    {
        [JsonProperty]
        public int CustomerId { get; set; }
        [JsonProperty]
        public string CustomerName { get; set; }
        [JsonProperty] public string CustomerPhone { get; set; }
        [JsonProperty] public string CustomerEmail { get; set; }
        [JsonProperty] public System.DateTime RegistrationDate { get; set; }
        [JsonProperty] public string LoginId { get; set; }
        [JsonProperty] public string Password { get; set; }
        [JsonProperty] public string OtherDetails { get; set; }
        [JsonProperty] public int CustomerTypeId { get; set; }
    }
}
