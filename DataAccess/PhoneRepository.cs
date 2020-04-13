using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using PhoneInfo.DataAccess;
using System;
using System.Collections.Generic;


namespace DataAccess
{
    public class PhoneRepository : BaseRepository<Phone>, IPhone
    {
        public PhoneRepository(PhoneInfoDBContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Comment> GetComments(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetComments()
        {
            throw new NotImplementedException();
        }

        public Phone GetPhoneByPhoneId(Guid phoneId)
        {
            throw new NotImplementedException();
        }

    }
}
