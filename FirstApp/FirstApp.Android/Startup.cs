using FirstApp.Global;
using SQLite;
using System;
using System.IO;

namespace FirstApp.Droid
{
    class Startup : FirstAppBase
    {
        public Startup()
        {
           
        }

        public void Run()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Person_DB.db");
            var sqLiteConnection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex);
            Container.RegisterInstance(sqLiteConnection);
        }
    }
}