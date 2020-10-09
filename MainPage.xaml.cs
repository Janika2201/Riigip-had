using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rigipuhad
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void whichOne()
        {
            string action = await DisplayActionSheet("Mida avada?", "Cancel", null, "Uusaasta", "Iseseis", "Suurreede", "Ulestõusmispuhade",
                "Kevadpüha", "Joulualaupaev", "Jaanipaev", "Nelipuhade", "Jaanipaev", "Voidupuha");
        }
    }
}
