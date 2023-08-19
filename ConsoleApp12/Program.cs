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
        Console.WriteLine(DaysOfTheWeek.Sunday+" is the: " +Convert.ToInt16( (int)DaysOfTheWeek.Sunday+1) + "th day of the week \n");



        DaysOfTheWeek day = DaysOfTheWeek.Tuesday;
        switch (day)
        {
            case DaysOfTheWeek.Monday:
                Console.WriteLine("It's Monday");
                break;
            case DaysOfTheWeek.Tuesday:
                Console.WriteLine("It's Tuesday");
                break;
            case DaysOfTheWeek.Wednesday:
                Console.WriteLine("It's Wednesday");
                break;
            case DaysOfTheWeek.Thursday:
                Console.WriteLine("It's Thursday");
                break;
            case DaysOfTheWeek.Friday:
                Console.WriteLine("It's Friday");
                break;
            case DaysOfTheWeek.Saturday:
                Console.WriteLine("It's Saturday");
                break;
            case DaysOfTheWeek.Sunday:
                Console.WriteLine("It's Sunday");
                break;

        }

        Console.WriteLine(Months.January + "is the "+(int)Months.January + "st month of the year");
        Console.WriteLine(Months.February + "is the "+(int)Months.February + "nd month of the year");
        Console.WriteLine(Months.March + "is the "+(int)Months.March + "rd month of the year");
        Console.WriteLine(Months.April + "is the "+(int)Months.April + "th month of the year");
        Console.WriteLine(Months.May + "is the "+(int)Months.May + "th month of the year");
        Console.WriteLine(Months.June + "is the "+(int)Months.June + "th month of the year");
        Console.WriteLine(Months.July + "is the "+(int)Months.July + "th month of the year");
        Console.WriteLine(Months.August + "is the "+(int)Months.August + "th month of the year");
        Console.WriteLine(Months.September + "is the "+(int)Months.September + "th month of the year");
        Console.WriteLine(Months.October + "is the "+(int)Months.October + "th month of the year");
        Console.WriteLine(Months.November + "is the "+(int)Months.November + "th month of the year");
        Console.WriteLine(Months.December + "is the "+(int)Months.December + "th month of the year");
        
    }
}