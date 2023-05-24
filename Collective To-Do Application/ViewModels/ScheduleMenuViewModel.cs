using Collective_To_Do_Application.API;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace Collective_To_Do_Application.ViewModels
{
    public class ScheduleMenuViewModel : ObservableObject
    {
        private void ApplicationExit() => Application.Current.Shutdown();

        public ICommand ApplicationExitCommand { get; set; }

        public ScheduleMenuViewModel(NavigationStore navigationStore)
        {
            ApplicationExitCommand = new RelayCommand(ApplicationExit);
        }
    }
}