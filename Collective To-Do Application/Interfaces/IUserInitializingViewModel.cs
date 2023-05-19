using Collective_To_Do_Application.API;
using Collective_To_Do_Application.ViewModels;

namespace Collective_To_Do_Application.Interfaces
{
    interface IUserInitializingViewModel
    {
        public NavigationStore NavigationStore { get; }
        public UserInitElementsViewModel? UserInitElementsViewModel { set; }
    }
}