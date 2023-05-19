using Collective_To_Do_Application.ViewModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Collective_To_Do_Application.Conventers
{
    public class EnterButtonTextConventer : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            // return "Create" if ParentViewModel are Registration
            // and "Enter" if Login
            if (value is UserInitElementsViewModel viewModel)
                return viewModel.ParentViewModel is RegistrationViewModel ? "Create" : "Enter";

            throw new Exception();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}