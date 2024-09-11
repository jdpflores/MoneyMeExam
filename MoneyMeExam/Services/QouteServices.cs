using Excel.FinancialFunctions;
using MoneyMeExam.Models;
using Newtonsoft.Json.Linq;

namespace MoneyMeExam.Services
{
    public class QouteServices
    {

        private readonly moneymedbContext _context;

        public QouteServices(moneymedbContext context)
        {
            _context = context;
        }

        public async Task<TblLoan> ProcessLoan(TblQouteViewModel model)
        {
            TblLoan tblLoan = new TblLoan();

            //will set 15 as default based on philippine loan percentage by The Central Bank of the Philippines
            double InterestRate = 6.25 * 0.01;
            int addper = 0;

            if (model.Product == "ProductA")
            {
                InterestRate = 0;
            }
            else if(model.Product == "ProductB")
            {
                addper = 2;
            }

            double monthlyPayment = Financial.IPmt(rate: (InterestRate / 12) / 4,
                per: 1 + addper,
                nper: model.Term * 4,
                pv: Convert.ToDouble(model.AmountRquired),
                fv: 0,
                typ: PaymentDue.EndOfPeriod) * -1;

            tblLoan.FinanceAmount = model.AmountRquired;
            tblLoan.WeeklyRepayment = Convert.ToDecimal(Math.Round(monthlyPayment, 2));
            tblLoan.TotalRepayment = Convert.ToDecimal(Math.Round(monthlyPayment, 2)) * model.Term * 4;
            tblLoan.NoOfWeeks = model.Term * 4;
            tblLoan.EstablishmentFee = 300; //put 300 as default same with the example
            tblLoan.InterestPerc = Convert.ToDecimal(InterestRate);
            if (InterestRate == 0)
            {
                tblLoan.InterestAmount = 0;
            }
            else
            {
                tblLoan.InterestAmount = Convert.ToDecimal((tblLoan.TotalRepayment ?? 0) - model.AmountRquired);
            }

            model.IsMobileValid = !_context.TblBlacklistedMobiles.Where(x => x.MobileNumber == model.Mobile).Any();

            string[] email = model.Email.Split('@');
            model.IsDomainValid = !_context.TblBlacklistedDomains.Where(x => x.Domain == email[1]).Any();

            return await Task.FromResult(tblLoan);
        }
    }
}
