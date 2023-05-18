using Collective_To_Do_Application.API;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Collective_To_Do_Application.ViewModels
{
    partial class LaunchViewModel : ObservableObject
    {
        private NavigationStore navigationStore;

        #region commands
        private void NavigateLoginView() => navigationStore.CurrentViewModel = new LoginViewModel(navigationStore);
        private void NavigateRegistrationView() => navigationStore.CurrentViewModel = new RegistrationViewModel(navigationStore);

        public ICommand NavigateLoginViewCommand { get; }
        public ICommand NavigateRegistrationViewCommand { get; }
        #endregion

        public LaunchViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;

            NavigateLoginViewCommand = new RelayCommand(NavigateLoginView);
            NavigateRegistrationViewCommand = new RelayCommand(NavigateRegistrationView);
        }
    }
}