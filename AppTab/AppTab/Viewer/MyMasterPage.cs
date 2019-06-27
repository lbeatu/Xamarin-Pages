using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace App7.Viewer
{
       public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new MasterSayfalar.MyMenu();
           Detail = new MasterSayfalar.MyDetail();
        }
    }

    
}
