﻿using SophiApp.Commons;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SophiApp.Converters
{
    internal class IntToChangedWord : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var localization = (Localization)values[0];
            var counter = System.Convert.ToString(values[1]).ToCharArray();
            var word = values[2] as string;

            if (localization.Language == UILanguage.RU)
            {
                var eleven = new char[] { '1', '1' };

                if (counter.SequenceEqual(eleven))
                    return "Изменено";

                switch (counter.Last())
                {
                    case '1':
                        return "Изменена";

                    default:
                        return "Изменено";
                }
            }

            return word;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
