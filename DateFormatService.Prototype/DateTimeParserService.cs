using System.Globalization;

namespace DateFormatService.Prototype;

public interface IDateTimeParserService
{
    DateTime Parse(string value);
}

public class DateTimeParserService : IDateTimeParserService
{
    private List<string> _dateTimeFormatPatterns;

    public DateTimeParserService(IDateTimeFormatProvider provider)
    {
        _dateTimeFormatPatterns = provider.GetDateTimeFormatPatterns().ToList();
    }

    public DateTime Parse(string value)
    {
        foreach (var pattern in _dateTimeFormatPatterns)
        {
            if (DateTime.TryParseExact(value, pattern, null, DateTimeStyles.None, out var dateTimeFormat))
            {
                _dateTimeFormatPatterns.Remove(pattern);
                _dateTimeFormatPatterns.Insert(0, pattern);
                return dateTimeFormat;
            }
        }

        throw new Exception("Unable to parse the string as a valid datetime");
    }
}
