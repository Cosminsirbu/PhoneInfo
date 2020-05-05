using ApplicationLogic.Exceptions;
using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using System;

namespace ApplicationLogic.Services
{
    class UserService
    {
        private readonly IUser userRepository;
        public UserService(IUser userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetUserByUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var user = userRepository.GetUserByUserId(userIdGuid);
            if (user == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return user;
        }

        //public User GetUserInfo(string userId)
        //{
        //    Guid userIdGuid = Guid.Empty;

        //}
    }
}
