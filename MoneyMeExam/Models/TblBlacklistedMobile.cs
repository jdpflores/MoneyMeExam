using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneyMeExam.Models
{
    public partial class TblBlacklistedMobile
    {
        [Key]
        public int BlacklistedMobileId { get; set; }
        public string MobileNumber { get; set; } = null!;
    }
}
