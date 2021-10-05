using FirstApp.Contract;
using FirstApp.Data;
using FirstApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using SQLite;
using System;
using System.IO;

namespace FirstApp
{
    public class Startup
    {
        public ServiceProvider ServiceProvider { get; }

        public Startup()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Person_DB.db");
            var sqLiteConnection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex);
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<FirstAppViewModel>();
            serviceCollection.AddSingleton<IDatabaseManager, DatabaseManager>();
            serviceCollection.AddSingleton(sqLiteConnection);

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
