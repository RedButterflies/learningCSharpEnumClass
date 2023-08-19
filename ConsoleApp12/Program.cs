//the Enum class
enum DaysOfTheWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Months
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Monday is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Monday+1) + "st day of the week ");
    }
}