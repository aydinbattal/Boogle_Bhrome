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
using Group9Project.Dylan_s_Pages;

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

        //Gets username, money from the main site.
        public BankPage()
        {
            this.InitializeComponent();
            PlaceholderDate.Text = DateTime.Now.ToString();
            PlaceholderName.Text = User.Name;
            PlaceholderBalance.Text = User.Money.ToString();
            //PlaceholderOverdraft.Text = $"Overdraft Limit: {bank.OverdraftAmount}";
        }

        //Navigates back to the main site.
        private void AppBarButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        //Adds the invoice to user's invoice history.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            List<InvoiceSystem> invoices = e.Parameter as List<InvoiceSystem>;

            if (invoices != null)
            {
                foreach (var oneInvoice in invoices)
                {
                    _invoice.InvoiceList.Add(oneInvoice);
                    bank.UpdateValues(oneInvoice.TempBalance, oneInvoice.TempOverdraftAmount);
                }
            }
            PlaceholderBalance.Text = bank.Balance.ToString();
            PlaceholderOverdraft.Text = bank.OverdraftAmount.ToString();

        }

        //Processes depositing&withdrawing based on user input then sends it to the generate invoice method located in InvoiceSystem
        private void ProcessButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double depositAmt = double.Parse(DepositAmt.Text);
                double withdrawAmt = double.Parse(WithdrawAmt.Text);

                bank.Deposit(depositAmt);
                bank.Withdraw(withdrawAmt);
                _invoice.GenerateInvoice(depositAmt, withdrawAmt, bank.Balance, bank.OverdraftAmount);

                int count = _invoice.InvoiceList.Count;
                MessageDialog dialog = new MessageDialog($"Invoice Number = {_invoice.InvoiceList[count - 1].InvoiceNumber} \n Date Processed = {_invoice.InvoiceList[count - 1].Date} \n Deposit Amount = {DepositAmt.Text} \n Withdraw Amount = {WithdrawAmt.Text}");
                dialog.ShowAsync();

                PlaceholderBalance.Text = bank.Balance.ToString();
                PlaceholderOverdraft.Text = bank.OverdraftAmount.ToString();
            }
            catch (FormatException exception)
            {
                MessageDialog warning = new MessageDialog("Please enter a valid amount!");
                warning.ShowAsync();
            }

            
        }

        //Passes the list of invoices to proper page and navigates there.
        private void InvoiceHistoryButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InvoiceHistoryPage), _invoice.InvoiceList);
        }
    }
}
