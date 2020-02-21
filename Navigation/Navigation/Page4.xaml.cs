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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        public void Button_Clicked(object sender, EventArgs e)//sends you back
        {
            Navigation.PopAsync();
        }

        public void Button_Clicked_1(object sender, EventArgs e)//sends you to root
        {
            Navigation.PopToRootAsync();
        }

        
        protected override void OnAppearing() //displays prompt when page is opened
        {
            DisplayAlert("Error", "The simulation has broken", "OK");

        }


    }
}