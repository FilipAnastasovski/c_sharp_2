using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static int AgeCalculator(DateTime birthday)
        {
            DateTime denes = DateTime.Today;
            int age = denes.Year - birthday.Year;
            if (denes.Month < birthday.Month)
            {
                age--;
            }
            else if (denes.Month == birthday.Month && denes.Day < birthday.Day)
            {
                age--;
            }
            return age;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Day:");
                string day = Console.ReadLine();

                Console.WriteLine("Enter Month:");
                string month = Console.ReadLine();

                Console.WriteLine("Enter Year:");
                string year = Console.ReadLine();

                
                string birthday = $@"{month}/{day}/{year}";
                Match birtdayMatch = Regex.Match(birthday, @"^(?:(?:(?:0?[13578]|1[02])(\/|-|\.)31)\1|(?:(?:0?[1,3-9]|1[0-2])(\/|-|\.)(?:29|30)\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:0?2(\/|-|\.)29\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:(?:0?[1-9])|(?:1[0-2]))(\/|-|\.)(?:0?[1-9]|1\d|2[0-8])\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");

                if (!birtdayMatch.Success)
                {
                    Console.WriteLine("Not a valid date ");
                    continue;
                }
                else
                {
                    
                    string parseFormat = $@"{day}/{month}/{year}";
                    DateTime convertedDate = DateTime.Parse(parseFormat);

                    Console.WriteLine($"You are {AgeCalculator(convertedDate)} years old.");

                    Console.WriteLine("Do you want to enter a new date? (Y/N)");
                    string odgovor = Console.ReadLine();

                    if (odgovor == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }
            }
        }
    }
}
