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
    public static class ParseContactPhone
    {
        [FunctionName("ParseContactPhone")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("ParseContactPhone function Started");

            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                AdviserCRM data = JsonConvert.DeserializeObject<AdviserCRM>(requestBody);
                PhoneProfile profile = new PhoneProfile();
                if (!String.IsNullOrEmpty(data.contact.mobilephone))
                {
                    profile.MobilePhone = new Phone()
                    {
                        PhoneNumber = data.contact.mobilephone,
                        PhoneStatus = "Active",
                        Primary = true,
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                };

                if (!String.IsNullOrEmpty(data.contact.telephone1))
                {
                    profile.WorkPhone = new Phone()
                    {
                        PhoneNumber = data.contact.telephone1,
                        PhoneStatus = "Active",
                        Primary = true,
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };

                };
                return new OkObjectResult(profile);

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(String.Format("An error occurred processing this request. See detailes below\r\n{0}", ex.Message));
            }

        }
    }
}
