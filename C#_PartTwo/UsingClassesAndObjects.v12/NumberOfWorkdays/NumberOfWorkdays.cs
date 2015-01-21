using System;
/* Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

class NumberOfWorkdays
{    
    static void HowManyWorkdays(DateTime today, DateTime searched)
    {
        DateTime[] holidays = 
            {
                
                new DateTime(today.Year, 1, 1), 
                new DateTime(today.Year, 3, 3), 
                new DateTime(today.Year, 4, 18),
                new DateTime(today.Year, 4, 19),
                new DateTime(today.Year, 4, 20),
                new DateTime(today.Year, 5, 1), 
                new DateTime(today.Year, 5, 6), 
                new DateTime(today.Year, 5, 24),
                new DateTime(today.Year, 9, 6), 
                new DateTime(today.Year, 9, 22),
                new DateTime(today.Year, 11, 1),
                new DateTime(today.Year, 12, 24),
                new DateTime(today.Year, 12, 25),
                new DateTime(today.Year, 12, 26),
                new DateTime(today.Year, 12, 31)
            };

        bool isHoliday = false;
        int weekDays = 0;

        for (DateTime i = today; i < searched.Date; i = i.AddDays(1))
        {
            for (int j = 0; j < holidays.Length; j++)
            {
                if (i == holidays[j])
                {
                    isHoliday = true;
                }
            }

            int weekDay = Convert.ToInt32(i.DayOfWeek) + 1;

            if (isHoliday == false && weekDay > 1 && weekDay < 7)
            {
                weekDays++;
            }

            isHoliday = false;
        }
        Console.WriteLine("There are {1} workdays", searched, weekDays + 1);
    }

    static void Main()
    {
        DateTime today = DateTime.Today;
        Console.Write("End date in format \"year, month, day\": ");
        DateTime searched = DateTime.Parse(Console.ReadLine());
        HowManyWorkdays(today, searched);
    }
}

