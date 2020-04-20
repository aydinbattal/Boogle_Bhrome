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

namespace Group9Project.Deep_s_Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SlotHistoryListView : Page
    {
        public SlotHistoryListView()
        {
            this.InitializeComponent();
            PopulateHistory();
        }

        //Method that will populate the List view from the list that was created in the slot repository.
        private void PopulateHistory()
        {
            foreach (var history in SlotRepository.GetHistory())
            {
                MainListView.Items.Add(history);
            }
        }

        //Event that when will assign the double clicked date as a parameter and pass it to the slotHistoryView.
        private void MainListView_OnDoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            SlotTemplate item = MainListView.SelectedItem as SlotTemplate;
            this.Frame.Navigate(typeof(SlotHistoryView), item);
        }

        //Event that will take the user back to the slot machine homepage
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SlotMainPage));
        }
    }
}
