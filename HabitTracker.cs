using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Net;

namespace Basic_Bullet_Journal
{
    public class HabitTracker
    {
        //weekly habit tracker
        public static List<Habits> AddHabit()
        {

            Console.WriteLine("How many habits would you like to add?");
            var numberOfHabits = int.Parse(Console.ReadLine());
            List<Habits> tracker = new List<Habits>();
            if (numberOfHabits <= 0 || numberOfHabits > 10)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }
           
            else
            {
                for (int i = 0; i < numberOfHabits; i++)
                {


                    Console.WriteLine("Populating....");
                    var completed = new Dictionary<string, string>()
            {
                {"sunday", "_"},
                {"monday", "_" },
                {"tuesday", "_" },
                {"wednesday", "_"},
                {"thursday", "_"},
                {"friday", "_"},
                {"saturday", "_"}

            };
                    Console.WriteLine("Please enter habit name:");
                    string inputH = Console.ReadLine();
                    Console.WriteLine("Did you complete the task this week?");
                    var task = Console.ReadLine();
                    if (task.ToLower() == "yes")
                    {
                        Console.WriteLine("On what day of the week?");
                        var day = Console.ReadLine();
                        if (completed.ContainsKey($"{day.ToLower()}"))
                        {
                            completed[$"{day.ToLower()}"] = "X";
                            Console.WriteLine("Nice going!");
                        }
                        else
                        { Console.WriteLine("Tomorrow is another day!"); }
                    }
                        tracker.Add(new Habits(inputH, completed));
                }
                foreach (var item in tracker)
                {
                    Console.WriteLine($"This Week's Habits:\n *{item} ");
                }    
            }
            return tracker;
            

            //System.IO.File.WriteAllLines(@"C:\temp\ipAddresses.txt", tracker);


            //List<Habits> docPath =
            //      Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "habits.txt")))
            //{

            //    foreach (string item in tracker)
            //        outputFile.WriteLine(item);
            //}

        }

        public static void Options()
        {
            Console.WriteLine("Let's look at your habits! Enter 'okay' to continue.");
            string input2 = Console.ReadLine();

            if (input2.ToLower() == "okay")
            {
                //List<Habits> allHabits = HabitTracker.AddHabit();
                HabitTracker.AddHabit();
                //foreach (var habit in allHabits)
                //{
                //    Console.WriteLine($"This Week's Habits:\n *{habit} ");
                //}
            }

            else
            {
                Console.WriteLine("Please write 'okay!'");
            }
            //Console.WriteLine("\nYou are definitely viewing habits right now!");
            HabitTracker.Options();
           
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
