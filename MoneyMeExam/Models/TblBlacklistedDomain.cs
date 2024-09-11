using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneyMeExam.Models
{
    public partial class TblBlacklistedDomain
    {
        [Key]
        public int BlacklistedDomainId { get; set; }
        public string Domain { get; set; } = null!;
    }
}
