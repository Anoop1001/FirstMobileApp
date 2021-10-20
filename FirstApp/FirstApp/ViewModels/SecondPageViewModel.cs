using FirstApp.Contract;
using FirstApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApp.ViewModels
{
    public partial class SecondPageViewModel : BaseViewModel
    {
        private readonly IDatabaseManager _dataBaseManager;
        public SecondPageViewModel(IDatabaseManager dataBaseManager)
        {
            _dataBaseManager = dataBaseManager;
            LoadPersonalInformation().GetAwaiter().GetResult();
        }

        private async Task LoadPersonalInformation()
        {
            PersonalInformation = await _dataBaseManager.GetAllData<PersonalInformation>();
        }

        IEnumerable<PersonalInformation> personalInformation = new List<PersonalInformation>();

        public IEnumerable<PersonalInformation> PersonalInformation { get { return personalInformation; } set { SetProperty(ref personalInformation, value); } }
    }
}
