using System;
using MyXamarinTestApp.Views;
using Xamarin.Forms;

namespace MyXamarinTestApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {

        }
        public MainPageViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            
        }

        public INavigation Navigation { get; set; }

        public Command NavigateToTimerCommand =>
            new Command(async() =>
            {
                await Navigation.PushAsync(new TimerPage());
            });

    }
}
