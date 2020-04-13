using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Services
{
    class TipUsService
    {
        private readonly ITipUs tipUsRepository;

        public TipUsService(ITipUs tipUsRepository)
        {
            this.tipUsRepository = tipUsRepository;
        }

        public void AddTipUs(string tipUsEmail, string tipUsContent)
        {
            tipUsRepository.Add(new TipUs()
            {
                TipusId = Guid.NewGuid(),
                Email = tipUsEmail,
                Content = tipUsContent,
                Date = DateTime.Now
            });
        }
    }
}
