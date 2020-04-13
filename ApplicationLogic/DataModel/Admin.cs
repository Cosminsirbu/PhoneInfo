using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.DataModel
{
    public class Admin
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid AdminId { get; set; }

        public ICollection<User> UsersId { get; set; }
        public ICollection<TipUs> TipusId { get; set; }
        public ICollection<Comment> CommentsId { get; set; }
    }
}
