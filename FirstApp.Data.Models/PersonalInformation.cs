using SQLite;

namespace FirstApp.Data.Models
{
    public class PersonalInformation : BaseDataModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
