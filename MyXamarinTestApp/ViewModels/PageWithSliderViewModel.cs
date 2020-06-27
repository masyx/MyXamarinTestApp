using System;
using Xamarin.Forms;

namespace MyXamarinTestApp.ViewModels
{
    public class PageWithSliderViewModel
    {
        private INavigation Navigation { get; set; }

        public PageWithSliderViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
        }


    }
}
