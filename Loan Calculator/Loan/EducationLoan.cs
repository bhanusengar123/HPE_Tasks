using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    public class EducationLoan : Loan
    {
        public EducationLoan()
        {
            Rate = 10.30;
        }
        public EducationLoan(double principleAmount, double time)
        {
            Rate = 10.30;
            Principal = principleAmount;
            Time = time;
        }
    }
}
