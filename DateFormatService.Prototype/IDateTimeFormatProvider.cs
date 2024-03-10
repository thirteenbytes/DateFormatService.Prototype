namespace DateFormatService.Prototype;

public interface IDateTimeFormatProvider
{
    IEnumerable<string> GetDateTimeFormatPatterns();
}
