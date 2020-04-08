using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;

namespace CookingTerminalMain
{
    /// <summary>
    /// Converter, takes the boolean and returns a Visibility
    /// </summary>
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if (parameter == null)
           
            {
                return (bool)value ? Visibility.Visible : Visibility.Hidden;
            }
           
            else
            {
               
                return (bool)value ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
