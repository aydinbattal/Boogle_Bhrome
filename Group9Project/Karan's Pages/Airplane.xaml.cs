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
using AppDevFinalProject.Karan_s_Pages.Classes;
using Group9Project;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppDevFinalProject.Karan_s_Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Airplane : Page
    {
        public Airplane()
        {
            this.InitializeComponent();
            PopulateSeats();
        }
        public void PopulateSeats()
        {
            foreach (var movie in Destinations.GetSeats())
            {
                AirplaneListView.Items.Add(movie);
            }
        }
        private void AirplaneListView_OnDoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {

            //todo: subtract ticket price from balance from dylans program
            Seat seat = AirplaneListView.SelectedItem as Seat;
            this.Frame.Navigate(typeof(SeatsPage), seat);
        }

        private void BackButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
