using System;
using System.Collections.Generic;
using MyXamarinTestApp.ViewModels;
using Xamarin.Forms;

namespace MyXamarinTestApp.Views
{
    public partial class PageWithSlider : ContentPage
    {
        public PageWithSlider()
        {
            InitializeComponent();
            BindingContext = new PageWithSliderViewModel(Navigation);
            
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelSliderValue.Text = e.NewValue.ToString("F3");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            await DisplayAlert("Clicked!",
                "The button labeled '" + button.Text + "' has been clicked", "OK");
        }
    }
}
