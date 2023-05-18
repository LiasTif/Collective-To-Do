using Collective_To_Do_Application.ViewModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Collective_To_Do_Application.Conventers
{
    public class EnterButtonTextConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is UserInitElementsViewModel viewModel)
            {
                if (viewModel.ParentViewModel is RegistrationViewModel)
                    return "Create";
                else if (viewModel.ParentViewModel is LoginViewModel)
                    return "Enter";
            }

            throw new Exception();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
