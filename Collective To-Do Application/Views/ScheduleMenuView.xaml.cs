using System.Collections.Generic;
using System.Windows.Controls;

namespace Collective_To_Do_Application.Views
{
    /// <summary>
    /// Interaction logic for ScheduleMenuView.xaml
    /// </summary>
    public partial class ScheduleMenuView : UserControl
    {
        public ScheduleMenuView()
        {
            InitializeComponent();

            Models.Task task = new Models.Task();
            dgMain.ItemsSource = new List<Models.Task>
            {
                task,
                task
            };
        }
    }
}