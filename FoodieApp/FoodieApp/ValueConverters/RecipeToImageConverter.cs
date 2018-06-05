namespace FoodieApp
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;
    public class RecipeToImageConverter : IValueConverter
    {
        public string Assembly { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = value as string;
            if (string.IsNullOrEmpty(source))
                return null;
            var path = $"{Assembly}.{source}";
            return ImageSource.FromResource(path);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
