using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Threading.Tasks;
using App7.TabbedSayfalar;

namespace App7.Viewer
{
    public class MyCarouselPage : CarouselPage
    {
        public MyCarouselPage()
        {
            Children.Add(new MyTab1());
            Children.Add(new MyTab2());
        }
    }
}
