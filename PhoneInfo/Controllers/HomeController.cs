using System;
using System.Diagnostics;
using ApplicationLogic.Services;
using Microsoft.AspNetCore.Mvc;
using PhoneInfo.Models;

namespace PhoneInfo.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhoneService _phoneService;
        private string retPage;

        public HomeController(PhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SearchViewModel vm)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    retPage = _phoneService.GetPage(vm.Search);
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View(retPage);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
