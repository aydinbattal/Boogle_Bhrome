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
            this.InitializeComponent();
            User.Money = 100;
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            //Search button click

            if (Searchbar.Text == "www.tipcalculator.com")
                this.Frame.Navigate(typeof(TipCalculator));
            else if(Searchbar.Text == "www.bankpage.com")
                this.Frame.Navigate(typeof(BankPage));
            else if(Searchbar.Text == "www.slotmachine.com")
                this.Frame.Navigate(typeof(SlotMainPage));
            else if(Searchbar.Text == "www.airplane.com")
                this.Frame.Navigate(typeof(Airplane));
        }
        
        private void UsernameButtonClick(object sender, RoutedEventArgs e)
        {
            User.Username = Username.Text;
        }

        private void NameButtonClick(object sender, RoutedEventArgs e)
        {
            User.Name = Name.Text;
        }

        private void AddressButtonClick(object sender, RoutedEventArgs e)
        {
            User.Address = Address.Text;
        }

        private void PhoneNoButtonClick(object sender, RoutedEventArgs e)
        {
            User.PhoneNo = PhoneNo.Text;
        }
    }
}
