using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyXamarinTestApp.Views
{
    public partial class XAMLvsCode : ContentPage
    {
        public XAMLvsCode()
        {
            InitializeComponent();

            var colorConverter = new ColorTypeConverter();
            var myColor = colorConverter.ConvertFromInvariantString("Green");

            Label label = new Label
            {
                Text = "Hello from Code!",
                IsVisible = true,
                Opacity = 0.75,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = (Color)myColor,
                BackgroundColor = Color.FromRgb(255, 128, 128),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            (Content as StackLayout).Children.Insert(0, label);
        }
    }
}
