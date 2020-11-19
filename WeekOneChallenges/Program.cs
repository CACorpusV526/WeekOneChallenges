using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, here is my attempt at the Week 1 Challenges!");
            Console.WriteLine();

            string firstName = "Carlos";
            string lastName = "Corpus-Valenzuela";
            int age = 20;
            string intro = $"Hi! I'm {firstName} {lastName} and I am {age} years old.";
            Console.WriteLine(intro);
            string mgs = "Metal Gear Solid Series";
            string dd = "Dungeon Defenders";
            string dmc = "Devil May Cry Series";
            string dbz = "Dragonball Z Games";
            string[] favVideoGames = { mgs, dd, dmc, dbz };
            Console.WriteLine("Here are some of my favorite games!");
            foreach (string item in favVideoGames)
            {
                Console.WriteLine(item);
            }
            List<string> Dates = new List<string>();
            DateTime rightNow = DateTime.Now;
            string now = rightNow.ToString();
            DateTime yestDay = new DateTime(2020, 11, 13);
            string yest = yestDay.ToString();
            Dates.Add(now);
            Dates.Add(yest);
            foreach (var item in Dates)
            {
                Console.WriteLine(item);
            }
            int sum = age + 7;
            Console.WriteLine(sum);
            int diff = age - 7;
            Console.WriteLine(diff);
            int prod = age * 7;
            Console.WriteLine(prod);
            int quot = age / 7;
            Console.WriteLine(quot);
            int remainder = age % 7;
            Console.WriteLine(remainder);
            Console.WriteLine("How many hours did you sleep last night?");
            string userSleep = Console.ReadLine();
            int userSleepHrs = Int32.Parse(userSleep);
            if (userSleepHrs >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (userSleepHrs >= 8 && userSleepHrs < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (userSleepHrs > 4 && userSleepHrs < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
            Console.WriteLine("How are you feeling today?");
            Console.WriteLine("Please type: Great, Good, Okay, or Bad");
            string userFeel = Console.ReadLine();
            switch (userFeel)
            {
                case "Great":
                    Console.WriteLine("That's awesome!");
                    break;
                case "Good":
                    Console.WriteLine("Hopefully that's only the start.");
                    break;
                case "Okay":
                    Console.WriteLine("Things will get better.");
                    break;
                case "Bad":
                    Console.WriteLine("Cowabummer man :(");
                    break;
                default:
                    Console.WriteLine("Sorry I don't understand your response");
                    break;
            } Console.ReadLine();
        }
    }
}
