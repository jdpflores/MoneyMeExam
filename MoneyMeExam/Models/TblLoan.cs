using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneyMeExam.Models
{
    public partial class TblLoan
    {
        [Key]
        public int LoanId { get; set; }
        public int QouteId { get; set; }
        public decimal? FinanceAmount { get; set; }
        public decimal? WeeklyRepayment { get; set; }
        public decimal? TotalRepayment { get; set; }
        public decimal? NoOfWeeks { get; set; }
        public decimal? EstablishmentFee { get; set; }
        public decimal? InterestPerc { get; set; }
        public decimal? InterestAmount { get; set; }
    }
}
