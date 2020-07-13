using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyXamarinTestApp.Views
{
    public partial class OpacityBindingCodePage : ContentPage
    {
        public OpacityBindingCodePage()
        {
            //InitializeComponent();

            var label = new Label
            {
                Text = ";-)",
                FontSize = Device.GetNamedSize(NamedSize.Header, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var slider = new Slider
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Value = 0.5
            };

            // set the binding context: target is label, source is slider
            label.BindingContext = slider;

            // bind the properties: target is Opacity, source is Value
            label.SetBinding(Label.OpacityProperty, "Value");

            //Constract the page
            Padding = new Thickness(0, 10);
            Content = new StackLayout
            {
                Children = { label, slider }
            };
        }
    }
}
