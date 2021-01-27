using System;

public class FridayUtil
{
    DayOfWeek friday = DayOfWeek.Friday;

    public DateTime[] allFridays = new DateTime[5];

    public FridayUtil(DateTime dt)
    {
        getAllFridaysInDateMonth(dt);
    }

    //  computes all the fridays in a month
    private void getAllFridaysInDateMonth(DateTime staticDateTime)
    {
        int numDays = DateTime.DaysInMonth(staticDateTime.Year, staticDateTime.Month);
        int index = 0;
        DateTime newDay = new DateTime(staticDateTime.Year, staticDateTime.Month, 01);
        while (numDays > 0)
        {
            if (newDay.DayOfWeek == friday)
            {
                allFridays[index] = newDay;
                index++;
            }
            newDay = newDay.AddDays(1);
            numDays--;
        }
    }

    //  checks for the next friday from a date
    public DateTime getNearestFriday(DateTime dt)
    {
        DateTime upperFriday = allFridays[0].AddYears(1);
        for (int i = 0; i < allFridays.Length; i++)
        {
            if (dt <= allFridays[i])
            {
                upperFriday = allFridays[i];
                break;
            }
        }
        return upperFriday;
    }

    //  holds all the possible fridays of a month
    public enum fridaysOfTheMonth
    {
        firstFriday, secondFriday, thirdFriday, fourthFriday, lastFriday
    }

    //  check which friday it is.
    public fridaysOfTheMonth CheckFriday(DateTime day)
    {
        if (day == allFridays[0])
        {
            return fridaysOfTheMonth.firstFriday;
        }
        else if (day == allFridays[1])
        {
            return fridaysOfTheMonth.secondFriday;
        }
        else if (day == allFridays[2])
        {
            return fridaysOfTheMonth.thirdFriday;
        }
        else if (day == allFridays[3])
        {
            return fridaysOfTheMonth.fourthFriday;
        }
        else
        {
            return fridaysOfTheMonth.lastFriday;
        }
    }

    //  checks if a day is a friday
    public static bool isFriday(DateTime dt)
    {
        return dt.DayOfWeek == DayOfWeek.Friday;
    }
}
