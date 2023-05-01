using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Globalization;

namespace NetLandApp.Helpers
{
    public class DateTimeConverter : ITypeConverter
    {
        private const string DateFormat = "dd.MM.yyyy";

        public object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            DateTime.TryParseExact(text, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);
            return result;
        }

        public string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            if (value is DateTime dateTime)
            {
                return dateTime.ToString(DateFormat);
            }

            return string.Empty;
        }
    }

}
