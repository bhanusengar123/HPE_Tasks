using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    public class Loan : ILoan
    {
        private double Interest;
        private double TotalAmount;
        private double _principal;
        private double _time;
        public double Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Time");
                    throw new ArgumentOutOfRangeException("Time cannnot be negative");
                }
                _time = value;
            }
        }
        public double Principal
        {
            get
            {
                return _principal;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Principal");
                    throw new ArgumentOutOfRangeException("Principal cannnot be negative");
                }
                _principal = value;
            }
        }
        public double Rate { get; set; }
            
        public double InterestValue()
        {
            Interest = (Principal * Rate * Time) / 100;
            return Interest;
        }
        public double LoanValue()
        {
            TotalAmount = InterestValue() + Principal;
            return TotalAmount;
        }
        
    }
}
