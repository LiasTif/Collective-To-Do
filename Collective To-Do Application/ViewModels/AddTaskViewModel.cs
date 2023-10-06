using Collective_To_Do_Application.API;
using AddTaskElements.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels
{
    public class AddTaskViewModel : ObservableObject
    {
        public AddTaskDeadlineElement AddTaskDeadlineElement => new();
        public AddTaskNameElement AddTaskNameElement => new();
        public AddTaskButtonsElement AddTaskButtonsElement => new();
        public AddTaskAssignPersonElement AddTaskAssignPersonElement => new();
        public AddTaskDescriptionElement AddTaskDescriptionElement => new();

        public AddTaskViewModel(NavigationStore navigationStore) { }
    }
}