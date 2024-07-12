namespace OOP_Session_01
{
    internal class Program
    {
        /*  enum WeekDays
          {
              Monday,
              Tuesday,
              Wednesday,
              Thursday,
              Friday,
              Saturday,
              Sunday
          }*/ //1

        /* enum Season
         {
             Spring,
             Summer,
             Autumn,
             Winter
         }
         static string GetMonthRange(Season season)
         {
             switch (season)
             {
                 case Season.Spring:
                     return "March to May";
                 case Season.Summer:
                     return "June to August";
                 case Season.Autumn:
                     return "September to November";
                 case Season.Winter:
                     return "December to February";
                 default:
                     return "Unknown season";
             }
         }*/ //2

       /* enum Colors
        {
            Red,
            Green,
            Blue
        }
        static bool IsPrimaryColor(Colors color)
        {
            
            return Enum.IsDefined(typeof(Colors), color);
        }*/ //4
        static void Main(string[] args)
        {
            #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            /* Console.WriteLine("Days of the Week:");

             foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
             {
                 Console.WriteLine(day);
             }*/

            #endregion
            #region 2.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            /* Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
             string input = Console.ReadLine();

             if (Enum.TryParse(input, true, out Season season))
             {

                 string monthRange = GetMonthRange(season);
                 Console.WriteLine($"The month range for {season} is: {monthRange}");
             }
             else
             {
                 Console.WriteLine("Invalid season. Please enter one of the following: Spring, Summer, Autumn, Winter.");
             }*/
            #endregion
            #region 3.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable


            #endregion
            #region 4.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            /*  Console.WriteLine("Enter a color (Red, Green, Blue):");
              string input = Console.ReadLine();

              if (Enum.TryParse(input, true, out Colors color))
              {
                  bool isPrimary = IsPrimaryColor(color);
                  if (isPrimary)
                  {
                      Console.WriteLine($"{color} is a primary color.");
                  }
                  else
                  {
                      Console.WriteLine($"{color} is not a primary color.");
                  }
              }
              else
              {
                  Console.WriteLine("Invalid color. Please enter one of the following: Red, Green, Blue.");
              }*/
            #endregion
            #region 5.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            #endregion


        }
    }
}
