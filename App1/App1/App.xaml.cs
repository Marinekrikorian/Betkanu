﻿using App1.Views;
using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

   
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
