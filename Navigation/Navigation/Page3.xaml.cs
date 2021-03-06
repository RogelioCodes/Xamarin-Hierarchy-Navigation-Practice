﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {

        public Page3()
        {
            InitializeComponent();

        }
        public void Button_Clicked(object sender, EventArgs e)//sends you back
        {
            Navigation.PushAsync(new Page4()); //sends you to page 4
        }

        public void Button_Clicked_1(object sender, EventArgs e)//sends you to root
        {
            Navigation.PopToRootAsync();
        }
       
        protected override void OnDisappearing() //displays prompt when disappearing
        {
            DisplayAlert("", "WOOOOOOOOOOOOOOOOSH", "OK?");
        }

        protected override void OnAppearing() //displays prompt when page is opened
        {
            DisplayAlert("", "The wizard has teleported you.", "OK");

        }
    }
}