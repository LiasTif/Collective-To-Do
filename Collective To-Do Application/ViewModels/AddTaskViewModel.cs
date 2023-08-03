using Collective_To_Do_Application.API;
using Collective_To_Do_Application.Views.Elements;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels
{
    public class AddTaskViewModel : ObservableObject
    {
        public AddTaskParamElement AddTaskParamElement => new();

        public AddTaskViewModel(NavigationStore navigationStore) { }
    }
}