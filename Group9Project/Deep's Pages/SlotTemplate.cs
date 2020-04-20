using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Group9Project.Deep_s_Pages
{
    
    //Class used as a template for the listview for slot machine history
    class SlotTemplate
    {
        //properties that will get assigned values in the list view
        public int Year { get; set; }
        public string Description { get; set; }


        private string _imageName;

        public string ImageName
        {

            //assigning the image name that is entered in the slotrepository to the image location in the assets folder.
            set
            {
                _imageName = value;
                Image.Source = new BitmapImage(new Uri($"ms-appx:///Assets/Deep's Pictures/{_imageName}", UriKind.RelativeOrAbsolute));
            }
        }

        public Image Image { get; set; }

        //constructor that initializes a new image for the list view
        public SlotTemplate()
        {
            Image = new Image();
        }
    }
}
