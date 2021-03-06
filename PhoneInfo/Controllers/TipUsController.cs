﻿using System;
using System.Linq;
using System.Threading.Tasks;
using ApplicationLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.DataAccess;
using PhoneInfo.Models;

namespace PhoneInfo.Controllers
{
    public class TipUsController : Controller
    {
        private readonly PhoneInfoDBContext _context;
        private readonly TipUsService _tipusService;

        Guid tipUsId;
        DateTime date;


        public TipUsController(PhoneInfoDBContext context, TipUsService tipusService)
        {
            _context = context;
            _tipusService = tipusService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipUsViewModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    tipUsId = Guid.NewGuid();
                    date = DateTime.Now;
                    _tipusService.AddTipUs(tipUsId, vm.Email, vm.Content, date);
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }   

            return View(vm);  
        }

        private bool TipUsExists(Guid id)
        {
            return _context.TipUs.Any(e => e.TipusId == id);
        }
    }
}
