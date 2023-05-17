using Collective_To_Do_Application.API;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private NavigationStore navigationStore;
        
        public ObservableObject CurrentViewModel => navigationStore.CurrentViewModel;

        public MainWindowViewModel(NavigationStore navigationStore)
        {
            navigationStore.CurrentViewModel = new LaunchViewModel(navigationStore);
            this.navigationStore = navigationStore;

            // UpdateProperty if it is a CurrentViewModel property
            this.navigationStore.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "CurrentViewModel")
                    OnPropertyChanged("CurrentViewModel");
            };
        }
    }
}