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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());

        }

        public void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        public void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Wizard:", "What the ( ͡° ͜ʖ ͡°) did you just ( ͡° ͜ʖ ͡°) say about me, you little ( ͡° ͜ʖ ͡°)? I'll have you know I graduated top of my ( ͡° ͜ʖ ͡°) in the ( ͡° ͜ʖ ͡°), and I've been involved in numerous secret ( ͡° ͜ʖ ͡°) on ( ͡° ͜ʖ ͡°), and I have over 300 confirmed ( ͡° ͜ʖ ͡°). I am trained in ( ͡° ͜ʖ ͡°) warfare and I'm the top ( ͡° ͜ʖ ͡°) in the entire US armed ( ͡° ͜ʖ ͡°). You are nothing to me but just another ( ͡° ͜ʖ ͡°). I will wipe you the ( ͡° ͜ʖ ͡°) out with precision the ( ͡° ͜ʖ ͡°) of which has never been seen before on this ( ͡° ͜ʖ ͡°), mark my ( ͡° ͜ʖ ͡°) words. ( ͡° ͜ʖ ͡°) think ( ͡° ͜ʖ ͡°) can get away with saying that ( ͡° ͜ʖ ͡°) to me over the ( ͡° ͜ʖ ͡°)? Think again, ( ͡° ͜ʖ ͡°). As we speak I am contacting my secret network of ( ͡° ͜ʖ ͡°) across the ( ͡° ͜ʖ ͡°) and your ( ͡° ͜ʖ ͡°) is being ( ͡° ͜ʖ ͡°) right now so you better ( ͡° ͜ʖ ͡°) for the ( ͡° ͜ʖ ͡°), ( ͡° ͜ʖ ͡°). The ( ͡° ͜ʖ ͡°) that wipes out the pathetic little thing you call ( ͡° ͜ʖ ͡°). You're ( ͡° ͜ʖ ͡°) dead, ( ͡° ͜ʖ ͡°). I can be ( ͡° ͜ʖ ͡°), anytime, and I can ( ͡° ͜ʖ ͡°) you in over seven hundred ( ͡° ͜ʖ ͡°), and that's just with my bare ( ͡° ͜ʖ ͡°). Not only am I extensively trained in ( ͡° ͜ʖ ͡°) combat, but I have access to the entire ( ͡° ͜ʖ ͡°) of the United States ( ͡° ͜ʖ ͡°) and I will use it to its full extent to wipe your miserable ( ͡° ͜ʖ ͡°) off the face of the ( ͡° ͜ʖ ͡°), you little ( ͡° ͜ʖ ͡°). If only you could have known what unholy retribution your little ( ͡° ͜ʖ ͡°) comment was about to bring down upon ( ͡° ͜ʖ ͡°), maybe you would have held your ( ͡° ͜ʖ ͡°) ( ͡° ͜ʖ ͡°). But you couldn't, you didn't, and now you're paying the price, you ( ͡° ͜ʖ ͡°). I will ( ͡° ͜ʖ ͡°) fury all over ( ͡° ͜ʖ ͡°) and ( ͡° ͜ʖ ͡°) will ( ͡° ͜ʖ ͡°) in it. You're ( ͡° ͜ʖ ͡°) dead, ( ͡° ͜ʖ ͡°).", "K");
           
        }
    }
}