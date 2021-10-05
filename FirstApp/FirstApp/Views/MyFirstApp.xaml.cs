
using FirstApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFirstApp : ContentPage
    {
        public MyFirstApp()
        {
            InitializeComponent();
            //var container = new SimpleInjector.Container();
            //container.Options.ResolveUnregisteredConcreteTypes = true;

            this.BindingContext = App.ApplicationStartup.ServiceProvider.GetService<FirstAppViewModel>();
        }
    }
}