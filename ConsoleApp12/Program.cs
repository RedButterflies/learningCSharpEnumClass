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
        Console.WriteLine(DaysOfTheWeek.Monday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Monday+1) + "st day of the week ");
        Console.WriteLine(DaysOfTheWeek.Tuesday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Tuesday+1) + "nd day of the week ");
        Console.WriteLine(DaysOfTheWeek.Wednesday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Wednesday+1) + "rd day of the week ");
        Console.WriteLine(DaysOfTheWeek.Thursday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Thursday+1) + "th day of the week ");
        Console.WriteLine(DaysOfTheWeek.Friday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Friday+1) + "th day of the week ");
        Console.WriteLine(DaysOfTheWeek.Saturday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Saturday+1) + "th day of the week ");
        Console.WriteLine(DaysOfTheWeek.Sunday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Sunday+1) + "th day of the week ");
        
        
    }
}