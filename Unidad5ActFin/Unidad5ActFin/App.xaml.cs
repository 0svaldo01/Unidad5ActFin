using System;
using Unidad5ActFin.Services;
using Unidad5ActFin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unidad5ActFin
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
