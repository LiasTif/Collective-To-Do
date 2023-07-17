﻿using System.Collections.Generic;
using System.Windows;
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

        private void dgMain_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "IsDone")
            {
                var templateColumn = new DataGridTemplateColumn();

                try
                {
                    templateColumn.CellTemplate = FindResource("CheckBoxTemplate") as DataTemplate;
                }
                catch
                {
                    //MessageBoxResult result = MessageBox.Show("Do you want to close this window?");
                    //Dispatcher.BeginInvoke(new Action(() => MessageBox.Show(result)));
                }

                templateColumn.Header = "IsDone";
                e.Column = templateColumn;
            }
        }
    }
}