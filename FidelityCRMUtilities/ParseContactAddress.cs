using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Fidelity.CRMUtilities.Models;

namespace Fidelity.CRMUtilities
{
    public static class ParseContactAddress
    {
        [FunctionName("ParseContactAddress")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("ParseContactAddress function Started");
            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                AdviserCRM data = JsonConvert.DeserializeObject<AdviserCRM>(requestBody);

                AddressProfile profile = new AddressProfile();
                if (!String.IsNullOrEmpty(data.account.address1_composite))
                {
                    profile.MailingAddress = new Address()
                    {
                        Addressee = data.agency.fdl_addresscommsto,
                        AddressLine1 = data.contact.address1_line1,
                        AddressLine2 = data.contact.address1_line2,
                        Country = data.contact.address1_country,
                        PostCode = data.contact.address1_postalcode,
                        Suburb = data.contact.address1_line3,
                        TownCity = data.contact.address1_city,
                        AddressStatus = "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                }

                if (!String.IsNullOrEmpty(data.account.address2_composite))
                {
                    profile.PhysicalAddress = new Address()
                    {
                        AddressLine1 = data.contact.address2_line1,
                        AddressLine2 = data.contact.address2_line2,
                        Country = data.contact.address2_country,
                        PostCode = data.contact.address2_postalcode,
                        Suburb = data.contact.address2_line3,
                        TownCity = data.contact.address2_city,
                        AddressStatus = "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                }

                return (ActionResult)new OkObjectResult(profile);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(String.Format("An error occurred processing this request. See detailes below\r\n{0}", ex.Message));
            }
        }
    }
}
