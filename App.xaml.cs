using baler_aurora_layout.Services;
using baler_aurora_layout.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baler_aurora_layout
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
