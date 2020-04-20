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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Group9Project.Dylan_s_Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TipCalculator : Page
    {
        //properties for calculations
        public double HST { get; set; } 
        public double TipTotal { get; set; }
        public double FinalTotal { get; set; }
        public double WalletAfterBill { get; set; }
        public TipCalculator()
        {
            //runs ButtonChange to disable buttons right away.
            this.InitializeComponent();
            ButtonChange();
        }

        private void ButtonChange()
        {
            //makes sure texboxes are filled before enabling calculate button.
            if (string.IsNullOrEmpty(BillAmount.Text) || string.IsNullOrEmpty(TipAmount.Text))
                CalculateButton.IsEnabled = false;
            else
                CalculateButton.IsEnabled = true;
        }

        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            //calculates and prints values.
            HST = Double.Parse(BillAmount.Text) * 0.13;
            TipTotal = Double.Parse(BillAmount.Text) * (Double.Parse(TipAmount.Text) * 0.01);
            FinalTotal = Double.Parse(BillAmount.Text) + TipTotal + HST;
            WalletAfterBill = User.Money - FinalTotal;
            if (WalletAfterBill < 0)
                WalletAfterBill = 0;

            Output.Text = $"{User.Username}'s Bill:\n\n HST: ${HST}\n Tip Total: ${TipTotal}\nFinal Total: ${FinalTotal}\n\n If you payed this bill you would have ${WalletAfterBill} left in your wallet";

        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            //navigates back to mainpage when back button is clicked.
            this.Frame.Navigate(typeof(MainPage));
        }

        private void BillAmount_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //redetermines if button should be disabled
            ButtonChange();
        }

        private void TipAmount_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //redetermines if button should be disabled
            ButtonChange();
        }
    }
}
