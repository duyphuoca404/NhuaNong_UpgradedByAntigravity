using System;
using System.Globalization;
using System.Windows.Data;

namespace NhuaNong.Wpf.Converters
{
    public class LevelHeightConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length >= 2 && values[0] is double actual && values[1] is double max)
            {
                if (max <= 0) max = 100; // Default max to avoid division by zero
                double percentage = actual / max;
                if (percentage > 1) percentage = 1;
                if (percentage < 0) percentage = 0;
                
                return percentage * 118; // Max height of the bar (120 - 2 border)
            }
            return 0.0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
