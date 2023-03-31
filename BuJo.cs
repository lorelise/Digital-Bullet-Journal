using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Bullet_Journal
{
    public class BuJo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's get journaling!");
            Console.ReadLine();

            static void UseJournal()
            { 
            
            Console.WriteLine();
            Console.WriteLine("Select option from below to proceed, or type 'Q' to quit:\n");
            Console.WriteLine("1) Text Journal");
            Console.WriteLine("2) Habit Tracker");
            Console.WriteLine("3) Calendar");


            var select = Console.ReadLine();
            

                switch (select)
                {
                    //Option to view journal entries, create new entry, or add to an existing entry
                    case "1":
                        
                        Console.WriteLine("\nJournal!\n");
                        Console.WriteLine("Would you like 'create' a new journal, 'add' to an existing journal, or 'view' an existing journal?\n");
                        string input = Console.ReadLine();

                        if (input.ToLower() == "view")
                        {
                            Journal.View();
                        }
                        else if (input.ToLower() == "create")
                        {
                            Journal.Create();
                        }
                        else if (input.ToLower() == "add")
                        {
                            Journal.Add();
                        }
                        else
                        {
                            Console.WriteLine("Please choose to 'create', 'view', or 'add' to an entry.\n");
                        }

                        //var journal = new Journal();
                        //Journal.ViewMethod();
                       
                        UseJournal();
                        break;

                    //Habit tracker functionality and viewing with call to relevant methods
                    case "2":

                        Console.WriteLine("\nHabit Tracker!");
                        //Console.WriteLine("Would you like to 'view' your tracker or 'add' a new habit?");

                        HabitTracker.Options();
                        //string input2 = Console.ReadLine();

                        //if (input2.ToLower() == "view")
                        //{
                        //    HabitTracker.View();
                        //}
                        //else if (input2.ToLower() == "add")
                        //{
                        //    HabitTracker.AddHabit();
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Please choose to 'view' tracker or 'add' a habit.");
                        //}
                        UseJournal();
                        break;

                    //Calendar functionality
                    case "3":

                        Console.WriteLine("\nCalendar!");
                        UseJournal();
                        break;

                    case "Q":
                    case "q":

                        Console.WriteLine("\nHappy productivity!");
                        break;

                    default:
                        Console.WriteLine("\nUnknown input, please try again.");
                        UseJournal();
                        break;
                }

            }

            UseJournal();
        }
    }
}