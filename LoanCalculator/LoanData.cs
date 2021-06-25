using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class LoanData
    {
        public int day { get; set; }
        public double bet { get; set; }
        public double accumulative { get; set; }
        public double paymentAmount { get; set; }
        public LoanData(int day, double bet, double accumulative, double paymentAmount)
        {
            this.accumulative = accumulative;
            this.paymentAmount = paymentAmount;
            this.day = day;
            this.bet = bet;
        }
    }
}
