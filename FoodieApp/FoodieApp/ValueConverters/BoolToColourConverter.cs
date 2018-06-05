namespace FoodieApp
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public class BoolToColourConverter<T> : IValueConverter
    {
        public T TrueValue { get; set; }
        public T FalseValue { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof(bool))
                return FalseValue;

            return (bool)value ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
