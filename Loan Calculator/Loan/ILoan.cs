using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    public interface ILoan
    {
        double Time { get; set; }
        double Principal { get; set; }
        double Rate { get; set; }
        double InterestValue();
        double LoanValue();
    }
}
