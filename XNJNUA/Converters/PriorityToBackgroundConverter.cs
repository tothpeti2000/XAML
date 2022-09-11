using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using XNJNUA.Models;

namespace XNJNUA.Converters
{
    public class PriorityToBackgroundConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var priority = (Priority)value;

            switch (priority)
            {
                case Priority.High: return "Red";
                case Priority.Normal: return "Orange";
                case Priority.Low: return "Green";
                default: return "White";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
