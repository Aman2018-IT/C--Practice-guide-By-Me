// See https://aka.ms/new-console-template for more information
using System.Data.Common;

static string GetDay(int dayNum)
{
    string dayName;

    switch(dayNum)
    {
        case 0:
            dayName = "SunDay";
            break;
        case 1:
            dayName = "Monday";
            break;
        case 2:
            dayName = "Tuesday";
            break;
        case 3:
            dayName = "Wednesday";
            break;
        case 4:
            dayName = "Thursday";
            break;
        case 5:
            dayName = "Friday";
            break;
        case 6:
            dayName = "Saturday";
            break;
        default:
            dayName = "Invalid number";
            break;
    }
    return dayName;
}

Console.WriteLine(GetDay(3));