using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Group9Project.Deep_s_Pages
{
    class SlotTemplate
    {
        public int Year { get; set; }
        public string Description { get; set; }


        private string _imageName;

        public string ImageName
        {

            set
            {
                _imageName = value;
                Image.Source = new BitmapImage(new Uri($"ms-appx:///Assets/Deep's Pictures/{_imageName}", UriKind.RelativeOrAbsolute));
            }
        }

        public Image Image { get; set; }

        public SlotTemplate()
        {
            Image = new Image();
        }
    }
}
