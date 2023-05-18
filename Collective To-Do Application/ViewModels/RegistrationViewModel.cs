using Collective_To_Do_Application.API;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels
{
    class RegistrationViewModel : ObservableObject
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
