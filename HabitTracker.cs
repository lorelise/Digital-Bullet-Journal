using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;


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

                    Console.WriteLine("Populating....\n");
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
                    string ?inputH = Console.ReadLine();
                    Console.WriteLine("Did you complete the task this week?");
                    var task = Console.ReadLine();
                    if (task.ToLower() == "yes")
                    {
                        Console.WriteLine("On what days of the week? (e.g. 'Monday,Wednesday,Friday'");
                        var day = Console.ReadLine();
                        foreach (var days in day.Split(','))
                        {
                            string n = Convert.ToString(days);

                            if (completed.ContainsKey($"{n.ToLower()}"))
                            {
                                completed[$"{n.ToLower()}"] = "X";
                            }     
                            else
                            { 
                                Console.WriteLine("Invalid input!");
                                break;
                            }
                        }
                    }
                        tracker.Add(new Habits(inputH.ToUpper(), completed));
                }
                Console.WriteLine("\nNice going!\n");
                Console.WriteLine("*~*This Week's Habits*~*");
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(tracker, options);
                string docPath =
                  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "HabitTracker.txt")))
                {
                        outputFile.WriteLine(jsonString);
                }
                //Console.WriteLine(jsonString);
                foreach (var item in tracker)
                {
                    Console.WriteLine($"\n *{item} ");
                }
            }
            return tracker;
        }

        public static void Options()
        {
            Console.WriteLine("Would you like to start a new weekly habit tracker?\n Note: Creating a new tracker will overwrite a previous one.");
            string input2 = Console.ReadLine();

            if (input2.ToLower() == "yes")
            {  
                HabitTracker.AddHabit();
            }
            else if (input2.ToLower() == "no" )
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Enter 'yes' or 'no.'");
            }

        }

        public static void View()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HabitTracker.txt");
            string[] lines = System.IO.File.ReadAllLines(@filePath);

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
                //Console.WriteLine("");
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to return to menu.");
            System.Console.ReadKey();
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
