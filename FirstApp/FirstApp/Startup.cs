using FirstApp.Contract;
using FirstApp.Data;
using FirstApp.ViewModels;
using SimpleInjector;
using SQLite;
using System;
using System.IO;

namespace FirstApp
{
    public class Startup
    {
        public Container Container { get; }

        public Startup()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Person_DB.db");
            var sqLiteConnection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex);
            Container = new Container();
            Container.Register<FirstAppViewModel>();
            Container.RegisterSingleton<IDatabaseManager, DatabaseManager>();
            Container.RegisterInstance(sqLiteConnection);

            Container.Verify();
        }
    }
}
