using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    public class CarLoan : Loan
    {
        public CarLoan()
        {
            Rate = 7;
        }
        public CarLoan(double principleAmount, double time)
        {
            Rate = 7;
            Principal = principleAmount;
            Time = time;
        }
    }
}
