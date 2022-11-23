using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MobileApp.MVVM.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;
        
        [ObservableProperty]
        private string _password;
    }
    
}
