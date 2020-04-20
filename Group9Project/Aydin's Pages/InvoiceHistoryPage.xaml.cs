using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class InvoiceHistoryPage : Page
    {
        private List<InvoiceSystem> _invoice = new List<InvoiceSystem>();

        //Gets username, phone number and address from main site.
        public InvoiceHistoryPage()
        {
            this.InitializeComponent();
            PlaceholderName.Text = User.Name;
            PlaceholderPhoneNum.Text = User.PhoneNo;
            PlaceholderAddress.Text = User.Address;
            //InvoicePageView.ItemsSource = Invoice.InvoiceList;
        }

        //Gets list of invoices and displays them in a list view.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _invoice = e.Parameter as List<InvoiceSystem>;
            InvoiceHistoryPageView.ItemsSource = _invoice;
        }

        //Navigates back to bank site homepage.
        private void BackBankButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BankPage), _invoice);
        }
    }
}
