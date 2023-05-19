using Collective_To_Do_Application.Interfaces;
using Collective_To_Do_Application.ViewModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Collective_To_Do_Application.Conventers
{
    /// <summary>
    /// create UserInitElementsViewModel and set it to parent VM
    /// </summary>
    public class GetUserInitElementsVM : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is IUserInitializingViewModel userInitVM)
            {
                UserInitElementsViewModel userInitElementsVM = new UserInitElementsViewModel(userInitVM.NavigationStore)
                    { ParentViewModel = userInitVM is RegistrationViewModel ? (RegistrationViewModel)userInitVM : (LoginViewModel)userInitVM };

                userInitVM.UserInitElementsViewModel = userInitElementsVM;
                return userInitElementsVM;
            }

            throw new Exception(); // if userInitElementsVM are not returned throw Exception
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}