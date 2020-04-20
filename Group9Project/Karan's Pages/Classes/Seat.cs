using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace AppDevFinalProject.Karan_s_Pages.Classes
{
    class Seat
    {
        //full props for info to be displayed to the customer on the ticket
        private string _imageName;
        public string Number { get; set; }
        public string Country { get; set; }
        public string BoardingTime { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public string ImageName
        {//sets the image based on what you clicked
            set
            {
                _imageName = value;
                Image.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{_imageName}", UriKind.RelativeOrAbsolute));
            }
        }

        public Image Image { get; set; }

        public Seat()
        {
            Image = new Image();
        }
    }
}
