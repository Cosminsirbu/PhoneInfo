using PhoneInfo.ApplicationLogic.Abstractions;
using PhoneInfo.ApplicationLogic.DataModel;
using PhoneInfo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class UserRepository : BaseRepository<User>, IUser
    {
        public UserRepository(PhoneInfoDBContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Comment> GetComments()
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserId(Guid userId)
        {
            return dbContext.User
                            .Where(user => user.UserId == userId)
                            .SingleOrDefault();
        }

    }
}
