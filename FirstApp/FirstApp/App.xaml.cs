using FirstApp.Services;
using FirstApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp
{
    public partial class App : Application
    {
        public static Startup ApplicationStartup;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            ApplicationStartup = new Startup();
            MainPage = new MyFirstApp();
        }

        protected override void OnStart()
        {
            var dataService = DependencyService.Get<IDataStore<MockDataStore>>();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
