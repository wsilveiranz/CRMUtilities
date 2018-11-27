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
    public static class ParseEmails
    {
        [FunctionName("ParseEmails")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("ParseEmail function Started");
            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                AdviserCRM data = JsonConvert.DeserializeObject<AdviserCRM>(requestBody);

                EmailProfile profile = new EmailProfile();

                Email email = GetEmail(data.agency._fdl_primaryemail_label, data);
                if (!string.IsNullOrEmpty(email.EmailAddress))
                    profile.Email = email;

                Email alternativeEmail = GetEmail(data.agency._fdl_alternateemail_label, data);
                if (!string.IsNullOrEmpty(alternativeEmail.EmailAddress))
                    profile.AlternativeEmail= alternativeEmail;
                
                return (ActionResult)new OkObjectResult(profile);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(String.Format("An error occurred processing this request. See detailes below\r\n{0}", ex.Message));
            }
        }


        private static Email GetEmail(string location, AdviserCRM data)
        {
            switch (location)
            {
                case "Contact Email 1":

                    return new Email()
                    {
                        EmailAddress = data.contact.emailaddress1,
                        EmailStatus = string.IsNullOrEmpty(data.contact.emailaddress1) ? "Inactive" : "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                case "Contact Email 2":
                    return new Email()
                    {
                        EmailAddress = data.contact.emailaddress2,
                        EmailStatus = string.IsNullOrEmpty(data.contact.emailaddress2) ? "Inactive" : "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                case "Contact Email 3":
                    return new Email()
                    {
                        EmailAddress = data.contact.emailaddress3,
                        EmailStatus = string.IsNullOrEmpty(data.contact.emailaddress3) ? "Inactive" : "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                case "Account Email 1":
                    return new Email()
                    {
                        EmailAddress = data.account.emailaddress1,
                        EmailStatus = string.IsNullOrEmpty(data.account.emailaddress1) ? "Inactive" : "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                case "Account Email 2":
                    return new Email()
                    {
                        EmailAddress = data.account.emailaddress2,
                        EmailStatus = string.IsNullOrEmpty(data.account.emailaddress2) ? "Inactive" : "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                case "Account Email 3":
                    return new Email()
                    {
                        EmailAddress = data.account.emailaddress3,
                        EmailStatus = string.IsNullOrEmpty(data.account.emailaddress3) ? "Inactive" : "Active",
                        StartDate = Convert.ToDateTime(data.contact.createdon).ToString("dd/MM/yyyy")
                    };
                default:
                    return null;
            }
        }
    }
}
