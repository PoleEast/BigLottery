using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigLottery
{
    //by.ChatGpt(目前我也看不懂)
    public class IntListCell : DataGridViewTextBoxCell
    {
        protected override object GetValue(int rowIndex)
        {
            object value = base.GetValue(rowIndex);
            if (value == null)
                return null;

            if (value is List<int> intList)
                return string.Join(", ", intList);

            return null;
        }
    }

    public class IntListConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is List<int> intList && destinationType == typeof(string))
            {
                return string.Join(", ", intList);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

}
