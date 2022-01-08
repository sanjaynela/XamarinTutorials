using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World"
            //};
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "OK");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //Code inside event handler
            label.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}