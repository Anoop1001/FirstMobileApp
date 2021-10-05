using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApp.Contract
{
    public interface IDatabaseManager
    {
        Task CreateGenericTable<T>();
        Task InsertData<T>(T data);
        Task<IEnumerable<T>> GetAllData<T>() where T : new();
        Task ClearData<T>();
    }
}
