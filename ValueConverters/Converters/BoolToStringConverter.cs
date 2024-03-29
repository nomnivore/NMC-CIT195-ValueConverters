﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ValueConverters.Converters
{
    class BoolToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool answerBool = (bool)value;

            if (answerBool)
                return "Yes";
            else
                return "No";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string answerString = (string)value;

            //if (answerString.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            //    return true;
            //else
            //    return false;
            return (answerString.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
