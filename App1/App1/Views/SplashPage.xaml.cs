using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            Animate();
        }
        public async void Animate()
        {
            imglogo.Opacity = 0;
            await imglogo.FadeTo(1, 2000);
            await Navigation.PushAsync(new AppShell());
        }
    }
}