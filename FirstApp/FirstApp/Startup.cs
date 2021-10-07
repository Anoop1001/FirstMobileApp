using FirstApp.Contract;
using FirstApp.Data;
using FirstApp.Global;
using FirstApp.ViewModels;
using SimpleInjector;

namespace FirstApp
{
    public class Startup : FirstAppBase
    {
        public Startup()
        {
           
        }

        public static Container Run()
        {
            Container.Register<FirstAppViewModel>();
            Container.RegisterSingleton<IDatabaseManager, DatabaseManager>();
            Container.Verify();
            return Container;
        }
    }
}
