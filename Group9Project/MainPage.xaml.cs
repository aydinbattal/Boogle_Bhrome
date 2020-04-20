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
using AppDevFinalProject.Karan_s_Pages;
using Group9Project.Aydin_s_Pages;
using Group9Project.Deep_s_Pages;
using Group9Project.Dylan_s_Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Group9Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //inits user properties to not be null, and runs ButtonChange right away to disable buttons.
            this.InitializeComponent();
            User.Money = 100;
            User.PhoneNo = "";
            User.Name = "";
            User.Address = "";
            User.Username = "";
            ButtonChange();
        }

        private void ButtonChange()
        {
            //makes sure all user inputs are filled before enabling buttons
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Name.Text) ||
                string.IsNullOrEmpty(Address.Text) || string.IsNullOrEmpty(PhoneNo.Text))
            {
                TipCalcButton.IsEnabled = false;
                AirplaneButton.IsEnabled = false;
                BankButton.IsEnabled = false;
                SlotMachineButton.IsEnabled = false;
                SearchbarButton.IsEnabled = false;
            }
            else
            {
                TipCalcButton.IsEnabled = true;
                AirplaneButton.IsEnabled = true;
                BankButton.IsEnabled = true;
                SlotMachineButton.IsEnabled = true;
                SearchbarButton.IsEnabled = true;
            }

        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            //Takes searchbar text and redirects to proper site depending on inputed text. Does nothing if incorrect.
            if (Searchbar.Text == "www.tipcalculator.com")
                this.Frame.Navigate(typeof(TipCalculator));
            else if(Searchbar.Text == "www.bank.com")
                this.Frame.Navigate(typeof(BankPage));
            else if(Searchbar.Text == "www.slotmachine.com")
                this.Frame.Navigate(typeof(SlotMainPage));
            else if(Searchbar.Text == "www.airplane.com")
                this.Frame.Navigate(typeof(Airplane));
        }

        private void TipCalcQuickLinkButton(object sender, RoutedEventArgs e)
        {
            //navigates to TipCalculator.xaml website when quicklink is clicked.
            this.Frame.Navigate(typeof(TipCalculator));
        }

        private void AirplaneQuickLinkButton(object sender, RoutedEventArgs e)
        {
            //navigates to Airplane.xaml website when quicklink is clicked.
            this.Frame.Navigate(typeof(Airplane));
        }

        private void BankQuickLinkButton(object sender, RoutedEventArgs e)
        {
            //navigates to BankPage.xaml website when quicklink is clicked.
            this.Frame.Navigate(typeof(BankPage));
        }

        private void SlotMachineQuickLinkButton(object sender, RoutedEventArgs e)
        {
            //navigates to SlotMainPage.xaml website when quicklink is clicked.
            this.Frame.Navigate(typeof(SlotMainPage));
        }

        private void Username_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //redetermines if buttons should be disabled
            ButtonChange();
        }

        private void Name_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //redetermines if buttons should be disabled
            ButtonChange();
        }

        private void Address_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //redetermines if buttons should be disabled
            ButtonChange();
        }

        private void PhoneNo_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //redetermines if buttons should be disabled
            ButtonChange();
        }

        private void Username_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //changes user Username property based on textbox.
            User.Username = Username.Text;
        }

        private void Name_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //changes user Name property based on textbox.
            User.Name = Name.Text;
        }

        private void Address_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //changes user Address property based on textbox.
            User.Address = Address.Text;
        }

        private void PhoneNo_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //changes user PhoneNo property based on textbox.
            User.PhoneNo = PhoneNo.Text;
        }
    }
}
