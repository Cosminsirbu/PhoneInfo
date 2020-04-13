using ApplicationLogic.Exceptions;
using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Services
{
    class PhoneService
    {
        private readonly IPhone PhoneRepository;
        public Phone GetPhoneByPhoneId(string phoneId)
        {
            Guid phoneIdGuid = Guid.Empty;
            if (!Guid.TryParse(phoneId, out phoneIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var phone = PhoneRepository.GetPhoneByPhoneId(phoneIdGuid);
            if (phone == null)
            {
                throw new EntityNotFoundException(phoneIdGuid);
            }

            return phone;
        }
    }
}
