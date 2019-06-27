using App7.MasterSayfalar;
using AppTab.MsterSayfa;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace AppTab.Viewer
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new MyMenu();
            Detail = new MyDetail();
        }
    }


}
