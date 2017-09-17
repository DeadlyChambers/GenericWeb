using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using GenericWeb.Models;

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

        private void SetDisplayFromAppSettings()
        {
            ViewData["CompanyName"] = _applicationSettings.CompanyName;
            ViewData["Logo"] = _applicationSettings.Images?.Logos?.FirstOrDefault(x => x.ImageSize == Enums.ImageSize.Default).Name ?? "";
            ViewData["Facebook"] = _applicationSettings.Contacts?.Facebook;
            ViewData["Phone"] = _applicationSettings.Phone;
        }
    }
}
