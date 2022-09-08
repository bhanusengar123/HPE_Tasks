using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    public class HomeLoan : Loan
    {
        public HomeLoan()
        {
            Rate = 8;
        }
        public HomeLoan(double principleAmount, double time)
        {
            Rate = 8;
            Principal = principleAmount;
            Time = time;
        }
    }
}
