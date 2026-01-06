using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace NhuaNong.Wpf.Converters
{
    public class SiloColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string type = value as string;
            
            Color c1, c2, c3;

            if (type == "Orange")
            {
                c1 = Color.FromRgb(255, 200, 150);
                c2 = Color.FromRgb(200, 100, 50);
                c3 = c1;
            }
            else if (type == "Blue")
            {
                c1 = Color.FromRgb(150, 200, 255);
                c2 = Color.FromRgb(50, 100, 200);
                c3 = c1;
            }
            else if (type == "Red")
            {
                c1 = Color.FromRgb(255, 150, 150);
                c2 = Color.FromRgb(200, 50, 50);
                c3 = c1;
            }
            else // Default Gray
            {
                c1 = Color.FromRgb(224, 224, 224);
                c2 = Color.FromRgb(160, 160, 160);
                c3 = c1;
            }

            // Create Metallic Gradient
            var brush = new LinearGradientBrush();
            brush.StartPoint = new System.Windows.Point(0, 0);
            brush.EndPoint = new System.Windows.Point(1, 0);
            brush.GradientStops.Add(new GradientStop(c2, 0.0));
            brush.GradientStops.Add(new GradientStop(c1, 0.2));
            brush.GradientStops.Add(new GradientStop(c2, 0.5));
            brush.GradientStops.Add(new GradientStop(c1, 0.8));
            brush.GradientStops.Add(new GradientStop(c2, 1.0));

            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
