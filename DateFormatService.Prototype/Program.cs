// See https://aka.ms/new-console-template for more information
using DateFormatService.Prototype;
using System.Globalization;

var provider = new DefaultDateTimeFormatProvider();

var formats = provider.GetDateTimeFormatPatterns().ToList();
formats.AddRange(CultureInfo.CurrentCulture.DateTimeFormat.GetAllDateTimePatterns());


var parser = new DateTimeParserService(provider);

var listOfDates = new List<string>()
{
    "2024-02-02",
    "2024-01-01",
    "30/11/2023"
};

try
{
    foreach (var input in listOfDates)
    {
        DateTime parsedDateTime = parser.Parse(input);
        Console.WriteLine("Successfully parsed date: " + parsedDateTime);
    }

}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
