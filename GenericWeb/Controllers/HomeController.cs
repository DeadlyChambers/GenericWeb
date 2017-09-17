using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using GenericWeb.Models;
using System.Net.Http;
using System.Net.Mail;
using System.Net;

namespace GenericWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationSettings _applicationSettings;

        public HomeController(IOptions<ApplicationSettings> settings)
        {
            _applicationSettings = settings.Value;

        }

        public IActionResult Index()
        {
            SetDisplayFromAppSettings();
            return View(_applicationSettings);
        }

        public IActionResult About()
        {
            SetDisplayFromAppSettings();
            ViewData["Message"] = "Anything you would like to talk about your company, yourself, or things you want the customer to know would go here.";

            return View(_applicationSettings);
        }

        public IActionResult Contact()
        {
            SetDisplayFromAppSettings();
            ViewData["Message"] = "Any contact information would go here";

            return View(_applicationSettings);
        }

        public IActionResult Error()
        {
            SetDisplayFromAppSettings();
            return View();
        }

        public async Task<HttpResponseMessage> SendEmail(string fromEmail, string body)
        {
            var fromAddress = new MailAddress(_applicationSettings.Email.EmailAddress, _applicationSettings.CompanyName+" automated email");
            var toAddress = new MailAddress(_applicationSettings.Email.EmailAddress, fromEmail);

            try
            {
                using (var smtpClient = new SmtpClient
                {
                    Host = _applicationSettings.Email.SmtpHost,
                    Port = _applicationSettings.Email.SmtpPort,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, _applicationSettings.Email.Password)
                })
                {

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = _applicationSettings.Email.Subject,
                        Body = $"Email sent on behalf of {fromEmail} \r\r {body}"
                    })

                    {
                        await smtpClient.SendMailAsync(message);
                        return new HttpResponseMessage(HttpStatusCode.OK);
                    }
                }
            }
            catch(Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        private void SetDisplayFromAppSettings()
        {
            ViewData["CompanyName"] = _applicationSettings.CompanyName;
            ViewData["Logo"] = _applicationSettings.Images?.Logos?.FirstOrDefault(x => x.ImageSize == Enums.ImageSize.Default).Name ?? "";
            ViewData["Facebook"] = _applicationSettings.Contacts?.Facebook;
            ViewData["Phone"] = _applicationSettings.Phone;
            ViewData["EmailMessage"] = _applicationSettings.Email?.EmailRequestMessage;
        }
    }
}
