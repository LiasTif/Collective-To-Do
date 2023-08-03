using Collective_To_Do_Application.API;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels.Windows
{
    public class AddTaskWindowViewModel : ObservableObject 
    {
        private NavigationStore _navigationStore;
        public AddTaskViewModel AddTaskViewModelInstance => new(_navigationStore);

        public AddTaskWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
	}
}