using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using System;


namespace ApplicationLogic.Services
{
    class TipUsService
    {
        private readonly ITipUs tipUsRepository;

        public TipUsService(ITipUs tipUsRepository)
        {
            this.tipUsRepository = tipUsRepository;
        }

        public void AddTipUs(Guid tipUsId, string tipUsEmail, string tipUsContent, DateTime date)
        {
            tipUsRepository.Add(new TipUs()
            {
                TipusId = tipUsId,
                Email = tipUsEmail,
                Content = tipUsContent,
                Date = date
            });
        }
    }
}
