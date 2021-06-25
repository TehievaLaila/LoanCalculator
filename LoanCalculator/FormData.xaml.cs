using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoanCalculator
{
    /// <summary>
    /// Interaction logic for FormData.xaml
    /// </summary>
    public partial class FormData : Page
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void BSubmit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoanGrid(Convert.ToInt32(TBSumLoan.Text), Convert.ToInt32(TBLoanDay.Text)));
        }

        private void TBSumLoan_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBLoanDay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
