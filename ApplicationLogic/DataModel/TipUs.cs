using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.DataModel
{
    public class TipUs
    {
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Guid TipusId { get; set; }
    }
}
