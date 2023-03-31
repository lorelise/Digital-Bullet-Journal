using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Basic_Bullet_Journal
{
    public class HabitTracker : BuJo 
    {
        //weekly habit tracker
        public static List<Habits> AddHabit()
        {
            
            List<Habits> tracker = new List<Habits>();
            Console.WriteLine("Please enter habit name:");
            string inputH = Console.ReadLine();

            Console.WriteLine("Populating....");
            var completed = new Dictionary<string, string>()
            {
                {"Sunday", "_"},
                {"Monday", "_" },
                {"Tuesday", "_" },
                {"Wednesday", "_"},
                {"Thursday", "x"},
                {"Friday", "_"},
                {"Saturday", "_"}

            };
            tracker.Add(new Habits(inputH, completed));
            

            return tracker;

            //string docPath =
            //      Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "habits.txt")))
            //{

            //    foreach (string item in bool)
            //        outputFile.WriteLine(item);
            //}

        }

        public static void Options()
        {
            Console.WriteLine("Would you like to 'view' your tracker or 'add' a new habit?");
            string input2 = Console.ReadLine();

            if (input2.ToLower() == "view")
            {
                List<Habits> allHabits = HabitTracker.AddHabit();
                foreach (var habit in allHabits)
                {
                    Console.WriteLine($"This Week's Habits:\n *{habit} ");
                }
            }
            else if (input2.ToLower() == "add")
            {
                HabitTracker.AddHabit();
            }
            else
            {
                Console.WriteLine("Please choose to 'view' tracker or 'add' a habit.");
            }
            Console.WriteLine("\nYou are definitely viewing habits right now!");

           
        }

        //public string[][]   
        //case (2)
        //  AddHabit() method

        //case (1)
        //  ViewTracker() method

        //else
        //  Console.WriteLine("Invalid input. Please type 1 to view tracker, 2 to add a new habit, or 'return' to return to homepage.");

        //if ( = "return")
        //loop back to homepage
    }
}
