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
using System.Collections;

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
                foreach (var item in tracker)
                {
                    Console.WriteLine($"\n *{item} ");
                }    
            }
            return tracker;

            //using (TextWriter tw = new StreamWriter("SavedList.txt"))
            //{
            //    foreach (String s in tracker)
            //        tw.WriteLine(s);
            //}
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
                
                HabitTracker.AddHabit();

            }

            else
            {
                Console.WriteLine("Please write 'okay!'");
                HabitTracker.Options();
            }
            //Console.WriteLine("\nYou are definitely viewing habits right now!");
           
           
        }

        public static void View()
        {
            
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
