namespace LoginFlow.ViewModels;

public partial class MainViewModel : BaseViewModel
{

    [RelayCommand]
    private async void Logout()
    {
        // REMOVE TOKEN 
        await Shell.Current.GoToAsync("//Login");
    }
}
