using CookingTerminalMain.Pages;

using CookingTerminalMain.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;

namespace CookingTerminalMain
{
    public class NavigationValueConverter : MarkupExtension, IValueConverter
    {

        private NavigationValueConverter navConverter = null;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((Navigator)value)
            {
                case Navigator.MainMenu:
                    var main = new MainMenuPage();
                    main.DataContext = new MainMenuViewModel();
                    return main;

                case Navigator.ChosenOrder:
                    var scnd = new ChosenOrderPage();
                    scnd.DataContext = new ChosenOrderViewModel();
                    return scnd;

                case Navigator.Login:
                    var login = new LoginPage();
                    login.DataContext = new LoginViewModel();
                    return login;


                default:
                    return null;

            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (navConverter == null)
                navConverter = new NavigationValueConverter();

            return navConverter;
        }
    }
}
