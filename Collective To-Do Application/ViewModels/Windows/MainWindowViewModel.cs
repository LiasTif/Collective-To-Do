using Collective_To_Do_Application.API;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private NavigationStore currNavigationStore;

        public ObservableObject ViewModel => CurrNavigationStore.CurrentViewModel;

        public MainWindowViewModel(NavigationStore navigationStore)
        {
            navigationStore.CurrentViewModel = new LaunchViewModel(navigationStore);
            this.CurrNavigationStore = navigationStore;
        }
    }
}