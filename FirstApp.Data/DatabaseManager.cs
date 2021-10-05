using FirstApp.Contract;
using FirstApp.Data.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApp.Data
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly SQLiteConnection _connection;
        public DatabaseManager(SQLiteConnection connection)
        {
            _connection = connection;
            CreateGenericTable<PersonalInformation>().GetAwaiter().GetResult();
        }

        public async Task CreateGenericTable<T>()
        {
            await Task.FromResult(_connection.CreateTable<T>(CreateFlags.None));
        }

        public async Task<IEnumerable<T>> GetAllData<T>() where T : new()
        {
            return await Task.FromResult(_connection.Table<T>().ToList());
        }

        public async Task ClearData<T>()
        {
            await Task.FromResult(_connection.DeleteAll<T>());
        }

        public async Task InsertData<T>(T data)
        {
            await Task.FromResult(_connection.Insert(data));
        }
    }
}
