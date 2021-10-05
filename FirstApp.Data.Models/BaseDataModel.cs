using SQLite;

namespace FirstApp.Data.Models
{
    public class BaseDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
