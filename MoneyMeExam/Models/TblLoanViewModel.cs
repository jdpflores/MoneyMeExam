namespace MoneyMeExam.Models
{
    public class TblLoanViewModel
    {
        public int LoanId { get; set; }
        public int QouteId { get; set; }
        public decimal FinanceAmount { get; set; }
        public decimal WeeklyRepayment { get; set; }
        public decimal TotalRepayment { get; set; }
        public decimal EstablishmentFee { get; set; }
        public decimal Interest { get; set; }
    }
}
