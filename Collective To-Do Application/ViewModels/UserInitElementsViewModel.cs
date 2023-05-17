using Collective_To_Do_Application.API;
using Collective_To_Do_Application.Models.UserInitElements;
using Collective_To_Do_Application.ViewModels.Elements;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Collective_To_Do_Application.ViewModels
{
    public partial class UserInitElementsViewModel : ObservableObject
    {
        // Count of numbers in pin code
        private const byte TextBoxesCount = 4;

        #region properties
        public ObservableObject ParentViewModel { get; set; }
        public ContinueButtonProcessor ContinueButtonProcessor { get; set; } = new ContinueButtonProcessor();
        public PersonDataProcessor PersonDataProcessor { get; set; }
        public ObservableCollection<TextBoxViewModel> TextBoxes { get; set; }

        private NavigationStore navigationStore;
        #endregion

        #region commands
        private void NavigateLaunchView() => navigationStore.CurrentViewModel = new LaunchViewModel(navigationStore);

        public ICommand NavigateLaunchViewCommand { get; }
        //public ICommand NavigateScheduleMenuView { get; }
        #endregion

        /// <summary>
        /// RegistrationViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public UserInitElementsViewModel(NavigationStore navigationStore)
        {
            // Create TextBoxes and add it`s to ObservableCollection
            TextBoxes = new ObservableCollection<TextBoxViewModel>();
            for (int i = 0; i < TextBoxesCount; i++) { TextBoxes.Add(new TextBoxViewModel(this) { Id = i }); }

            PersonDataProcessor = new PersonDataProcessor(this);

            // Set LaunchViewModel like CurrentViewModel
            NavigateLaunchViewCommand = new RelayCommand(NavigateLaunchView);
        }
    }
}
