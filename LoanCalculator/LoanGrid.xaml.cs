using System.Collections.Generic;
using System.Windows.Controls;


namespace LoanCalculator
{
    /// <summary>
    /// Interaction logic for LoanGrid.xaml
    /// </summary>
    public partial class LoanGrid : Page
    {
        public LoanGrid(int sum, int day)
        {
            InitializeComponent();
            List<LoanData> loanDatas = new List<LoanData>();
            double bet;
            bet = 0.90;
            loanDatas.Add(new LoanData(0, bet, ((double)sum / 100) * bet, (((double) sum  / 100) * bet) + sum));
            for (int i = 1; i < day;  i++)
            {
                if (i >= 1 && i <= 5)
                    {
                        bet = 0.90;
                        loanDatas.Add(new LoanData(i, bet, loanDatas[i - 1].accumulative + (((double)sum / 100) * bet), loanDatas[i - 1].accumulative + ((((double)sum / 100) * bet) + sum)));
                        
                    }
                    if (i >= 6 && i <= 10)
                    {
                        bet = 0.70;
                        loanDatas.Add(new LoanData(i, bet, loanDatas[i - 1].accumulative + (((double)sum / 100) * bet), loanDatas[i - 1].accumulative + ((((double)sum / 100) * bet) + sum)));
                    }
                    if (i >= 11 && i <= 20)
                    {
                        bet = 0.60;
                        loanDatas.Add(new LoanData(i, bet, loanDatas[i - 1].accumulative + (((double)sum / 100) * bet), loanDatas[i - 1].accumulative + ((((double)sum / 100) * bet) + sum)));
                    }
                    if (i >= 21)
                    {
                        bet = 0.50;
                        loanDatas.Add(new LoanData(i, bet, loanDatas[i - 1].accumulative + (((double)sum / 100) * bet), loanDatas[i - 1].accumulative + ((((double)sum / 100) * bet) + sum)));
                    }

            }
            TBEffectiveBid.Text += loanDatas[loanDatas.Count - 1].accumulative / sum / day;
            TBSumLoan.Text += sum;
            TBProcentSum.Text += loanDatas[loanDatas.Count - 1].accumulative;
            TBAllSumLoan.Text += loanDatas[loanDatas.Count - 1].accumulative + sum;
            TBSumDay.Text += day;
            LoanDataGrid.ItemsSource = loanDatas;
        }
    }
}
