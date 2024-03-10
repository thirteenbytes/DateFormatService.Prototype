using System.Globalization;

namespace DateFormatService.Prototype;

public class DefaultDateTimeFormatProvider : IDateTimeFormatProvider
{
    public IEnumerable<string> GetDateTimeFormatPatterns()
    {
        var patterns = new List<string>()
        {
            "dd/MM/yyyy",
            "yyyy-MM-dd",
            "MM/dd/yyyy"
        };
        
        patterns.AddRange(CultureInfo.CurrentCulture.DateTimeFormat.GetAllDateTimePatterns());
        return patterns;
    }
}
