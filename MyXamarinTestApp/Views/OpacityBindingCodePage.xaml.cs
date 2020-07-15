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

            // 1) FIRST OPTION TO CREATE BINDING
            //// set the binding context: target is label, source is slider
            //label.BindingContext = slider;
            //// bind the properties: target is Opacity, source is Value
            //label.SetBinding(Label.OpacityProperty, "Value");

            // 2) SECOND OPTION TO CREATE BINDING
            // Define Binding object with source onject and property
            Binding binding = new Binding
            {
                Source = slider,
                Path = "Value"
            };
            // Bind the Opacity property of the the lavel to the source
            label.SetBinding(Label.OpacityProperty, binding);

            // 3) THIRD OPTION TO CREATE BINDING, it is OBSOLETE
            //Binding binding1 = Binding.Create<Slider>(src => src.Value);
            //binding1.Source = slider;

            //Constract the page
            Padding = new Thickness(0, 10);
            Content = new StackLayout
            {
                Children = { label, slider }
            };
        }
    }
}
