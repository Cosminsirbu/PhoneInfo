using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.DataModel
{
    public class Phone
    {
        public string Name { get; set; }
        public Guid PhoneId { get; set; }

        public ICollection<Comment> CommentId { get; private set; }
    }
}
