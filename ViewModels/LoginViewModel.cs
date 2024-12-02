using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFlow.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _name;

        [RelayCommand]
        private async void Login()
        {
            await Shell.Current.GoToAsync("//Main");
        }

        [RelayCommand]
        private async void Register()
        {
            Name = "Arno";
            await Shell.Current.GoToAsync("TestPage");
        }
    }
}
