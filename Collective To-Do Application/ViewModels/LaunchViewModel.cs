using Collective_To_Do_Application.API;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Collective_To_Do_Application.ViewModels
{
    partial class LaunchViewModel : ObservableObject
    {
        private void NavigateLoginView() => navigationStore.CurrentViewModel = new LoginViewModel(navigationStore);

        private NavigationStore navigationStore;

        #region commands
        public ICommand NavigateLoginViewCommand { get; }
        //public ICommand NavigateRegistrationView { get; }
        #endregion

        public LaunchViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            NavigateLoginViewCommand = new RelayCommand(NavigateLoginView);
        }
    }
}