using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyXamarinTestApp.Views
{
    public partial class XAMLvsCode : ContentPage
    {
        public XAMLvsCode()
        {
            var colorConverter = new ColorTypeConverter();
            var myColor = colorConverter.ConvertFromInvariantString("Green");

            var frame1 = new Frame
            {
                BorderColor = Color.Accent,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "Label from Code",
                    IsVisible = true,
                    Opacity = 0.75,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    TextColor = (Color)myColor,
                    BackgroundColor = Color.FromRgb(1, 1, 1),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Bold | FontAttributes.Italic
                }
            };

            Content = frame1;
            
                      

            InitializeComponent();
        }
    }
}
