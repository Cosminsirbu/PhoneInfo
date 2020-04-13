using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.DataModel
{
    public class Comment
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Guid CommentId { get; set; }
        public Guid UserId { get; private set; }

    }
}
