using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Bullet_Journal
{
    public class BuJo : HabitTracker
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
            Console.WriteLine("3) View Current Habit Tracker");


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

                        

                        UseJournal();
                        break;

                    //View current tracker
                    case "3":

                        Console.WriteLine("\nViewing!!");

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