using System;
using System.Globalization;
using DeliverApp.Mobile.Models;
using Xamarin.Forms;

namespace DeliverApp.Mobile.Converters
{
    public class ShipmentAddressConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var address = value as DeliverModel;
            return $"{address.ShipmentAddress.Number} {address.ShipmentAddress.Street}, {address.ShipmentAddress.State}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

