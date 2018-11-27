using Newtonsoft.Json;

namespace Fidelity.CRMUtilities.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AddressProfile
    {
        [JsonProperty(PropertyName = "MailingAddress")]
        public Address MailingAddress { get; set; }
        [JsonProperty(PropertyName = "PhysicalAddress")]
        public Address PhysicalAddress { get; set; }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Address
    {
        [JsonProperty(PropertyName = "AddressStatus")]
        public string AddressStatus { get; set; }
        [JsonProperty(PropertyName = "Addressee")]
        public string Addressee { get; set; }
        [JsonProperty(PropertyName = "AdressLine1")]
        public string AddressLine1 { get; set; }
        [JsonProperty(PropertyName = "AdressLine2")]
        public string AddressLine2 { get; set; }
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }
        [JsonProperty(PropertyName = "Suburb")]
        public string Suburb { get; set; }
        [JsonProperty(PropertyName = "PostCode")]
        public string PostCode { get; set; }
        [JsonProperty(PropertyName = "StartDate")]
        public string StartDate { get; set; }
        [JsonProperty(PropertyName = "TownCity")]
        public string TownCity { get; set; }
    }

}
