using FirstApp.Views;
using SimpleInjector;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class App : Application
    {
        public static Container ContainerContext;
        public App()
        {
            InitializeComponent();

            ContainerContext = Startup.Run();
            //MainPage = new MyFirstApp();
            MainPage = new NavigationPage(new MyFirstApp());
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
