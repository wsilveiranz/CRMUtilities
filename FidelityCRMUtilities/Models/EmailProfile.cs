using Newtonsoft.Json;

namespace Fidelity.CRMUtilities.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class EmailProfile
    {
        [JsonProperty(PropertyName = "Email")]
        public Email Email { get; set; }
        [JsonProperty(PropertyName = "AlternativeEmail")]
        public Email AlternativeEmail { get; set; }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Email
    {
        [JsonProperty(PropertyName = "StartDate")]
        public string StartDate { get; set; }
        [JsonProperty(PropertyName = "EmailAddress")]
        public string EmailAddress { get; set; }
        [JsonProperty(PropertyName = "EmailStatus")]
        public string EmailStatus { get; set; }
    }
}
