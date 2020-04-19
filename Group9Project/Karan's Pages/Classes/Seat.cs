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
        private string _imageName;
        public string Number { get; set; }
        public string Country { get; set; }
        public string BoardingTime { get; set; }
        public string Description { get; set; }

        public string ImageName
        {
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
