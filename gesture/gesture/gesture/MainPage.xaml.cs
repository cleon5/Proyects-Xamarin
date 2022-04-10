using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace gesture
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnSwiped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Page1());
        }
        async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new Page1());
        }
        async void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
