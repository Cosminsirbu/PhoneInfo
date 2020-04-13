using PhoneInfo.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.Abstractions
{
    public interface IPhone : IRepository<Phone>
    {
        IEnumerable<Comment> GetComments();
        IEnumerable<Comment> GetComments(User user);
        Phone GetPhoneByPhoneId(Guid phoneId);
    }
}
