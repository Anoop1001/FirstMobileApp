using FirstApp.Contract;
using FirstApp.Data.Models;
using FirstApp.Models;
using System;
using System.Collections.Generic;
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
            InitializeColorsFromSource();
        }

        private void InitializeColorsFromSource()
        {
            Colors = new List<DisplayColor>
        {
            new DisplayColor { Name = "Aqua",  Id = Color.Aqua},
            new DisplayColor { Name = "Blue",  Id = Color.Blue},
            new DisplayColor { Name = "Gray",  Id = Color.Gray},
            new DisplayColor { Name = "Lime",  Id = Color.Lime},
            new DisplayColor { Name = "Navy",  Id = Color.Navy},
            new DisplayColor { Name = "Purple",Id = Color.Purple},
            new DisplayColor { Name = "Silver",Id = Color.Silver},
            new DisplayColor { Name = "White", Id = Color.White},
            new DisplayColor { Name ="Black",   Id = Color.Black},
            new DisplayColor { Name ="Fuchsia", Id = Color.Fuchsia},
            new DisplayColor { Name ="Green",   Id = Color.Green},
            new DisplayColor { Name ="Maroon",  Id = Color.Maroon},
            new DisplayColor { Name ="Olive",   Id = Color.Olive},
            new DisplayColor { Name ="Red",     Id = Color.Red},
            new DisplayColor { Name ="Teal",    Id = Color.Teal},
            new DisplayColor { Name ="Yellow",  Id = Color.Yellow}
        };

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
        public ICommand GetColorValue { get; }

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

        public bool NameEntered
        {
            get { return string.IsNullOrEmpty(Name); }
            set { }
        }

        List<DisplayColor> _colors = new List<DisplayColor>();

        public List<DisplayColor> Colors { get { return _colors; } set { SetProperty(ref _colors, value); } }

        private DisplayColor _displayColor;
        public DisplayColor DisplayColor { get { return _displayColor; } set { SetProperty(ref _displayColor, value); } }

    }
}
