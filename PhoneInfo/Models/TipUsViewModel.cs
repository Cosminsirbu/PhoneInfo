using System;
using System.ComponentModel.DataAnnotations;

namespace PhoneInfo.Models
{
    public class TipUsViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Guid TipusId { get; set; }
    }
}
