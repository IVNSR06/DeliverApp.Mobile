using System;
using System.Globalization;
using DeliverApp.Mobile.Models;
using Xamarin.Forms;

namespace DeliverApp.Mobile.Converters
{
    public class PersonNameSpacesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var person = value as Person;
            return $"{person.Name} {person.LastName}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

