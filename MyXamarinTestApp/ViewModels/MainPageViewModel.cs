using System;
using MyXamarinTestApp.Views;
using Xamarin.Forms;

namespace MyXamarinTestApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public MainPageViewModel()
        {

        }
        public MainPageViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            
        }

        public Command NavigateToTimerCommand =>
            new Command(async() =>
            {
                await Navigation.PushAsync(new TimerPage());
            });


        public Command NavigateToPageWithSliderCommand =>
            new Command(async() =>
            {
                await Navigation.PushAsync(new PageWithSlider());
            });

    }
}
