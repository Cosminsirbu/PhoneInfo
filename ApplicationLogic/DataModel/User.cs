using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.DataModel
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessPermission { get; set; }
        public Guid UserId { get; set; }

        public ICollection<Comment> CommentId { get; private set; }
        

    }
}
