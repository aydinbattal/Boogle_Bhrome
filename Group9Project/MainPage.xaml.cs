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
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            //Search button click

            if (Searchbar.Text == "www.tipcalculator.com")
                this.Frame.Navigate(typeof(TipCalculator));
        }
        
        private void UsernameButtonClick(object sender, RoutedEventArgs e)
        {
            //Username button click
            User.Username = Username.Text;
        }
    }
}
