using Collective_To_Do_Application.API;
using Collective_To_Do_Application.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace Collective_To_Do_Application.ViewModels
{
    public class ScheduleMenuViewModel : ObservableObject
    {
        private NavigationStore _navigationStore;

        #region commands
        private void NavigateProfileView() => _navigationStore.CurrentViewModel = new ProfileViewModel(_navigationStore);
        private void OpenAddTaskWindow() => new AddTaskWindow().ShowDialog();

        public ICommand ApplicationExitCommand { get; set; }
        public ICommand NavigateProfileViewCommand { get; set; }
        public ICommand OpenAddTaskWindowCommand { get; set; }
        #endregion

        private void ApplicationExit() => Application.Current.Shutdown();

        public ScheduleMenuViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            ApplicationExitCommand = new RelayCommand(ApplicationExit);
            OpenAddTaskWindowCommand = new RelayCommand(OpenAddTaskWindow);
            // Set LaunchViewModel like CurrentViewModel
            NavigateProfileViewCommand = new RelayCommand(NavigateProfileView);
        }
    }
}