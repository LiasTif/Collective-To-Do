using Collective_To_Do_Application.API;
using Collective_To_Do_Application.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels
{
    public class LoginViewModel : ObservableObject, IUserInitializingViewModel
    {
        public NavigationStore NavigationStore { get; private set; }

        public UserInitElementsViewModel? UserInitElementsViewModel { private get; set; }

        public LoginViewModel(NavigationStore navigationStore) => NavigationStore = navigationStore;
    }
}