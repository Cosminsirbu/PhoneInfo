using PhoneInfo.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.Abstractions
{
    public interface IUser: IRepository<User>
    {
        User GetUserByUserId(Guid userId);
        //User GetUserInfo(string userId);

        IEnumerable<Comment> GetComments();
    }
}
