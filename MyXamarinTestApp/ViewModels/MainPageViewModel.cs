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

        public Command NavigateToGridDemoPage =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new GridDemoPage());
            });

        public Command NavigateToAbsoluteLayoutDemoPage =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new AbsoluteDemoPage());
            });

        public Command NavigateToSharedRecourses =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new SharedResourcesPage());
            });

        public Command NavigateToStaticConstantsPage =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new StaticConstantsPage());
            });

    }
}
