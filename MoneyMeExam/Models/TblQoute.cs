using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneyMeExam.Models
{
    public partial class TblQoute
    {
        [Key]
        public int QouteId { get; set; }
        public decimal AmountRquired { get; set; }
        public int Term { get; set; }
        public string Title { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
