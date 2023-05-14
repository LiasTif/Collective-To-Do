using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.API
{
    public partial class NavigationStore : ObservableObject
    {
        [ObservableProperty]
        public ObservableObject currentViewModel;
    }
}