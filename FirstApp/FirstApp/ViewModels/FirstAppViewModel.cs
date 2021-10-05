using FirstApp.Contract;
using FirstApp.Data.Models;
using System;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstApp.ViewModels
{
    public partial class FirstAppViewModel : BaseViewModel
    {
        private readonly IDatabaseManager _dataBaseManager;
        public FirstAppViewModel(IDatabaseManager dataBaseManager)
        {
            _dataBaseManager = dataBaseManager;
            ClickAddCommand = new Command(AddButtonClicked());
            ClickDisplayCommand = new Command(DisplayButtonClicked());
            ClickClearCommand = new Command(ClearButtonClicked());
        }

        private Action<object> AddButtonClicked()
        {
            return async (e) =>
            {
                await _dataBaseManager.InsertData(new PersonalInformation { Name = Name, Address = Address });
                ClickDisplayCommand.Execute(null);
            };
        }

        private Action<object> DisplayButtonClicked()
        {
            return async (e) =>
            {
                var personalData = await _dataBaseManager.GetAllData<PersonalInformation>();
                PersonalInformation = string.Join(Environment.NewLine, personalData.Select(x => $"{x.Name} {x.Address}"));
            };
        }

        private Action<object> ClearButtonClicked()
        {
            return async (e) =>
            {
                await _dataBaseManager.ClearData<PersonalInformation>();
                ClickDisplayCommand.Execute(null);
            };
        }

        public ICommand ClickAddCommand { get; }
        public ICommand ClickDisplayCommand { get; }
        public ICommand ClickClearCommand { get; }

        string personalInformation = string.Empty;
        public string PersonalInformation
        {
            get { return personalInformation; }
            set { SetProperty(ref personalInformation, value); }
        }

        string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        string address = string.Empty;
        public string Address
        {
            get { return address; }
            set { SetProperty(ref address, value); }
        }
    }
}
