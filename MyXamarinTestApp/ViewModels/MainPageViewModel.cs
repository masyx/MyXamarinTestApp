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

        public Command NavigateToTriggersPage =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new TriggersPage());
            });

        public Command NavigateToXAMLvsCode =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new XAMLvsCode());
            });

        public Command NavigateToXAMLvsCode2 =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new XAMLvsCode2());
            });

        public Command NavigateToClock =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new Clock());
            });
        
        public Command NavigateToOpacityBindingCodePage =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new OpacityBindingCodePage());
            });

        public Command NavigateToOpacityBindingXAMLPage =>
            new Command(async () =>
            {
                await Navigation.PushAsync(new OpacityBindingXAMLPage());
            });

    }
}
