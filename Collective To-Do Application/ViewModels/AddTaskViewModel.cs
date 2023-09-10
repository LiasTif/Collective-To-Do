using Collective_To_Do_Application.API;
using Collective_To_Do_Application.Views.Elements;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels
{
    public class AddTaskViewModel : ObservableObject
    {
        public AddTaskDeadlineElement AddTaskDeadlineElement => new();
        public AddTaskNameElement AddTaskNameElement => new();
        public AddTaskButtonsElement AddTaskButtonsElement => new();
        public AddTaskAssignPersonElement AddTaskAssignPersonElement => new();

        public AddTaskViewModel(NavigationStore navigationStore) { }
    }
}