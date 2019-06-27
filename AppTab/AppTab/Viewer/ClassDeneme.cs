using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace App7.Viewer
{
    public class ClassDeneme : ContentPage
    {
        public ClassDeneme()
            {
            Label lblPage = new Label();
            lblPage.Text = "Merhabagtykuıl";
            lblPage.FontSize = 30;
            lblPage.HorizontalOptions = LayoutOptions.Center;
            lblPage.VerticalOptions = LayoutOptions.Center;
            Content = lblPage;
         }
    }
}
