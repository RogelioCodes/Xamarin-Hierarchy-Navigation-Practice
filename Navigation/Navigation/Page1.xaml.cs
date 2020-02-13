using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

       public void OnClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        public void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}