using Microsoft.AspNet.Identity;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Carrick.Web.Services
{
   public class EMailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            await configSendEmailAsync(message);
        }

        private async Task configSendEmailAsync(IdentityMessage message)
        {
            // convert IdentityMessage to a MailMessage
            var email = new MailMessage(new MailAddress(ConfigurationManager.AppSettings["mailAccount"]
                , ConfigurationManager.AppSettings["mailAccountName"])
                , new MailAddress(message.Destination))
            {
                Subject = message.Subject
                ,Body = message.Body
                ,IsBodyHtml = true
                ,Priority = MailPriority.High      
                };



            using (var client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["mailAccount"]
                        , ConfigurationManager.AppSettings["mailAccountPassword"]);
                await client.SendMailAsync(email);
            }
        }
    }
}
