using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MoneyMeExam.Models
{
    public partial class TblQouteViewModel
    {
        [Key]
        public int QouteId { get; set; }

        [DisplayName("Amount Required")]
        [Required(ErrorMessage = "Select Amount Required")]
        public decimal AmountRquired { get; set; }


        [DisplayName("Product")]
        public string Product { get; set; } = "ProductA";

        [DisplayName("Term")]
        [Required(ErrorMessage = "Select Term")]
        public int Term { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Select Title")]
        public string Title { get; set; } = null!;

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Select Last Name")]
        public string LastName { get; set; } = null!;

        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "Enter Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Mobile")]
        [Required(ErrorMessage = "Enter Mobile")]
        public string Mobile { get; set; } = null!;

        [DisplayName("Email")]
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; } = null!;

        public LoanDetails? LoanDetails { get; set; }
    }
}
