using System;

namespace IkommAcademyDag_1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task1
            Header("Task 1");
            string allDates = "All registered dates\n";
            int day1 = 29;
            int month1 = 2;
            int year1 = 2100;
            int year2 = 2000;
            int year3 = 2016;
            int year4 = 2021;

            Console.WriteLine($"Is {year1} a leap-year?  {(IsLeapYear(year1) ? "Yes!" : "No!")}");
            Console.WriteLine($"Is {year2} a leap-year?  {(IsLeapYear(year2) ? "Yes!" : "No!")}");
            Console.WriteLine($"Is {year3} a leap-year?  {(IsLeapYear(year3) ? "Yes!" : "No!")}");
            Console.WriteLine($"Is {year4} a leap-year?  {(IsLeapYear(year4) ? "Yes!" : "No!")}");
            EndLine();
            #endregion


            #region task2
            Header("Task 1");
            Console.WriteLine(ValidateDate(30, 2, 2020));
            Console.WriteLine(ValidateDate(day1, month1, year2));
            EndLine();

            #endregion


            #region taks3
            Header("Task 1");
            bool end;
            do
            {
                Console.Write("Day: ");
                int.TryParse(Console.ReadLine(), out int day); //omitting the output of tryParse for now. Can be used for error handling
                Console.Write("Month: ");
                int.TryParse(Console.ReadLine(), out int month);
                Console.Write("Year: ");
                int.TryParse(Console.ReadLine(), out int year);
                string output = ValidateDate(day, month, year);
                Console.WriteLine(output);
                Console.Write("Do you wish to continue? (y/n) default 'n': ");
                string result = Console.ReadLine();
                if (ValidateBoolean(day, month, year)) allDates += output + '\n';
                end = result.Contains('y') || result.Contains('Y');
            } while (end);
            Console.WriteLine(allDates);
            EndLine();
            #endregion

        }

        static void Header(string text)
        {
            int offset = text.Length / 2;
            Console.WriteLine(new string('~', Console.WindowWidth / 2 - offset) + text + new string('~', Console.WindowWidth / 2 - offset));
        }

        static int DaysInMonth(int month, int year)
        {
            if (month == 2)
            {
                return 28 + (IsLeapYear(year) ? 1 : 0);
            }
            else if (month < 8)
            {
                return 30 + (month % 2 == 1 ? 1 : 0);
            }
            else
            {
                return 30 + (!(month % 2 == 1) ? 1 : 0);
            }

        }

        static bool ValidateBoolean(int day, int month, int year)
        {
            if (!(day > 0)) return false;

            if (year <= 0 || year > 2099) return false;

            if (month > 12 || month <= 0) return false;

            if (day > DaysInMonth(month, year)) return false;

            return true;
        }

        static string ValidateDate(int day, int month, int year)
        {
            if (!(day > 0)) return $"ERROR: Invalid day, day Zero or negative! Input data: - day: {day}";
            
            if (year <= 0 || year > 2099) return $"ERROR: Invalid year! Input data - year: {year}";

            if (month > 12 || month <= 0) return $"ERROR: Invalid month! Input data - month: {month}";

            if (day > DaysInMonth(month, year)) return $"ERROR: Too many days in month! Input data - day/month: {day}/{month}";

            
            return $"{day}{(day == 1 ? "st": day == 2 ? "nd" : day == 3 ? "rd" : "th")} of {FormatMonth(month)} {year}";
        }

        static string FormatMonth(int month)
        {
            // Faster solution would be to define an array with all months and accessing them using array[input month - 1]
            switch (month)
            {
                case 1:
                    return "January";

                case 2:
                    return "February";

                case 3:
                    return "March";

                case 4:
                    return "April";

                case 5:
                    return "May";

                case 6:
                    return "June";

                case 7:
                    return "July";

                case 8:
                    return "August";

                case 9:
                    return "September";

                case 10:
                    return "October";

                case 11:
                    return "November";

                case 12:
                    return "December";
                default:
                    return "unreachable";
            }
        }

        static void EndLine()
        {
            Console.WriteLine(new string('=', Console.WindowWidth));
            Console.WriteLine("\n\n");
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && !(year % 100 == 0)) || year % 400 == 0;
        }
    }
}
