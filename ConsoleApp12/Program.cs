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

        Console.WriteLine("\n"+Months.January + " is the "+Convert.ToInt16((int)Months.January+1) + "st month of the year");
        Console.WriteLine(Months.February + " is the "+Convert.ToInt16((int)Months.February+1) + "nd month of the year");
        Console.WriteLine(Months.March + " is the "+Convert.ToInt16((int)Months.March+1) + "rd month of the year");
        Console.WriteLine(Months.April + " is the "+Convert.ToInt16((int)Months.April+1) + "th month of the year");
        Console.WriteLine(Months.May + " is the "+Convert.ToInt16((int)Months.May+1) + "th month of the year");
        Console.WriteLine(Months.June + " is the "+Convert.ToInt16((int)Months.June+1) + "th month of the year");
        Console.WriteLine(Months.July + " is the "+Convert.ToInt16((int)Months.July+1) + "th month of the year");
        Console.WriteLine(Months.August + " is the "+Convert.ToInt16((int)Months.August+1) + "th month of the year");
        Console.WriteLine(Months.September + " is the "+Convert.ToInt16((int)Months.September+1) + "th month of the year");
        Console.WriteLine(Months.October + " is the "+Convert.ToInt16((int)Months.October+1) + "th month of the year");
        Console.WriteLine(Months.November + " is the "+Convert.ToInt16((int)Months.November+1) + "th month of the year");
        Console.WriteLine(Months.December + " is the "+Convert.ToInt16((int)Months.December+1) + "th month of the year\n");

        Months month = Months.March;
        switch (month)
        {
            case Months.January:
                Console.WriteLine("It's January");
                break;
            case Months.February:
                Console.WriteLine("It's February");
                break;
            case Months.March:
                Console.WriteLine("It's March");
                break;
            case Months.April:
                Console.WriteLine("It's April");
                break;
            case Months.May:
                Console.WriteLine("It's May");
                break;
            case Months.June:
                Console.WriteLine("It's June");
                break;
            case Months.July:
                Console.WriteLine("It's July");
                break;
            case Months.August:
                Console.WriteLine("It's August");
                break;
            case Months.September:
                Console.WriteLine("It's September");
                break;
            case Months.October:
                Console.WriteLine("It's October");
                break;
            case Months.November:
                Console.WriteLine("It's November");
                break;
            case Months.December:
                Console.WriteLine("It's December");
                break;
        }
    }
}