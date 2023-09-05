using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace Collective_To_Do_Application.Conventers
{
    /// <summary>
    /// Change elemnt style based on it`s index 
    /// </summary>
    public class IndexToStyleConverter : IValueConverter
    {
        /// <summary>
        /// If <param name="value"> are 0 we change style of element
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Application.LoadComponent(
                new Uri("/Collective To-Do Application;component/ResourceDictionaries/UserInitElementsViewResources.xaml",
                UriKind.Relative)) is ResourceDictionary dictionary)
            {
                // set style to TextBox depending on whether he is the first on the list
                return (int)value == 0 ? dictionary["tbxFirtPinRegistrationView"] : dictionary["tbxPinRegistrationView"];
            }

            throw new Exception();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}