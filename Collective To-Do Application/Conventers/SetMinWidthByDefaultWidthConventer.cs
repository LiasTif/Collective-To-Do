using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Collective_To_Do_Application.Conventers
{
    class SetMinWidthByDefaultWidthConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TextBlock textBlock)
                return textBlock.Width;
            else
                return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}