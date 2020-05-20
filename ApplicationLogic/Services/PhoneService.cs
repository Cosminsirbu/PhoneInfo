using ApplicationLogic.Exceptions;
using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using System;

namespace ApplicationLogic.Services
{
    public class PhoneService
    {
        private readonly IPhone _PhoneRepository;
        public PhoneService(IPhone PhoneRepository)
        {
            _PhoneRepository = PhoneRepository;
        }

        public Phone GetPhoneByPhoneId(string phoneId)
        {
            Guid phoneIdGuid = Guid.Empty;
            if (!Guid.TryParse(phoneId, out phoneIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var phone = _PhoneRepository.GetPhoneByPhoneId(phoneIdGuid);
            if (phone == null)
            {
                throw new EntityNotFoundException(phoneIdGuid);
            }

            return phone;
        }

        public string GetPage(string name)
        {
            return _PhoneRepository.GetPage(name);
        }

    }
}
