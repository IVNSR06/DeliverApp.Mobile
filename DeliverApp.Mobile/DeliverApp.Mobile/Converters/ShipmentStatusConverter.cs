using System;
using System.Globalization;
using DeliverApp.Mobile.Models.Enums;
using Xamarin.Forms;

namespace DeliverApp.Mobile.Converters
{
    public class ShipmentStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string status;

            switch ((PackageStatus)value)
            {
                case PackageStatus.OnRoad:
                    status = "OnRoad";
                    break;
                case PackageStatus.Delivered:
                    status = "Delivered";
                    break;
                default:
                    status = string.Empty;
                    break;
            }

            return status;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

