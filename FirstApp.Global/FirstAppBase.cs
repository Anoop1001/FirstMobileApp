using SimpleInjector;
using SQLite;
using System;
using System.IO;

namespace FirstApp.Global
{
    public class FirstAppBase
    {
        public static Container Container { get; }

        static FirstAppBase()
        {
            Container = new Container();
        }
    }
}
