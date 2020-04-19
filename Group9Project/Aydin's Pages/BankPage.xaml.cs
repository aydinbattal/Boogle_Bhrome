using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Group9Project.Aydin_s_Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BankPage : Page
    {
        BankSystem bank = new BankSystem();

        private InvoiceSystem _invoice = new InvoiceSystem();

        public BankPage()
        {
            this.InitializeComponent();
            PlaceholderDate.Text = DateTime.Now.ToString();
            //PlaceholderBalance.Text = $"Your Balance: {bank.Balance}";
            //PlaceholderOverdraft.Text = bank.OverdraftAmount.ToString();
        }

        private void AppBarButton_OnClick(object sender, RoutedEventArgs e)
        {
            //todo: implement going back to mainsite
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            List<InvoiceSystem> invoices = e.Parameter as List<InvoiceSystem>;

            if (invoices != null)
            {
                foreach (var invoice in invoices)
                {
                    _invoice.InvoiceList.Add(invoice);
                    bank.UpdateValues(invoice.TempBalance, invoice.TempOverdraftAmount);
                }
            }
            PlaceholderBalance.Text = bank.Balance.ToString();
            PlaceholderOverdraft.Text = bank.OverdraftAmount.ToString();

        }
        private void ProcessButton_OnClick(object sender, RoutedEventArgs e)
        {
            double depositAmt = double.Parse(DepositAmt.Text);
            double withdrawAmt = double.Parse(WithdrawAmt.Text);

            bank.Deposit(depositAmt);
            bank.Withdraw(withdrawAmt);
            _invoice.AddInvoice(depositAmt, withdrawAmt, bank.Balance, bank.OverdraftAmount);

            int count = _invoice.InvoiceList.Count;
            MessageDialog dialog = new MessageDialog($"Invoice Number = {_invoice.InvoiceList[count - 1].InvoiceNumber} \n Date Processed = {_invoice.InvoiceList[count - 1].Date} \n Deposit Amount = {DepositAmt.Text} \n Withdraw Amount = {WithdrawAmt.Text}");
            dialog.ShowAsync();

            PlaceholderBalance.Text = bank.Balance.ToString();
            PlaceholderOverdraft.Text = bank.OverdraftAmount.ToString();
        }


        private void InvoiceHistoryButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InvoiceHistoryPage), _invoice.InvoiceList);
        }
    }
}
