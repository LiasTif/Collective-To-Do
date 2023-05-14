using Collective_To_Do_Application.API;
using Collective_To_Do_Application.ViewModels.Windows;
using Collective_To_Do_Application.Views;
using System.Windows;

namespace Collective_To_Do_Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow mainWindow = new();
            MainWindowViewModel mainWindowViewModel = new(new NavigationStore());

            // set ViewModel(DataContext) for MainWindow
            mainWindow.DataContext = mainWindowViewModel;
            mainWindow.Show();
        }
    }
}