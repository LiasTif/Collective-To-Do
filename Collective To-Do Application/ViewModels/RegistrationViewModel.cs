using Collective_To_Do_Application.API;
using Collective_To_Do_Application.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels
{
    public class RegistrationViewModel : ObservableObject, IUserInitializingViewModel
    {
        public NavigationStore NavigationStore { get; private set; }
        public UserInitElementsViewModel? UserInitElementsViewModel { private get; set; }

        /// <summary>
        /// RegistrationViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public RegistrationViewModel(NavigationStore navigationStore) => NavigationStore = navigationStore;
    }
}
