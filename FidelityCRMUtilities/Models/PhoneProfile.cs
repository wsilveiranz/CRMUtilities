using Newtonsoft.Json;

namespace Fidelity.CRMUtilities.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, Title = "Phones")]
    public class PhoneProfile
    {
        [JsonProperty(PropertyName = "Fax")]
        public Phone Fax { get; set; }
        [JsonProperty(PropertyName = "HomePhone")]
        public Phone HomePhone { get; set; }
        [JsonProperty(PropertyName = "MobilePhone")]
        public Phone MobilePhone { get; set; }
        [JsonProperty(PropertyName = "WorkPhone")]
        public Phone WorkPhone { get; set; }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Phone
    {
        [JsonProperty(PropertyName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty(PropertyName = "PhoneStatus")]
        public string PhoneStatus { get; set; }
        [JsonProperty(PropertyName = "Primary")]
        public bool Primary { get; set; }
        [JsonProperty(PropertyName = "StartDate")]
        public string StartDate { get; set; }
    }
}
