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
                    case "1":
                        
                        Console.WriteLine("\nJournal!\n");//call method for Journal
                        Console.WriteLine("Would you like to 'view' journal or 'create' new entry?");
                        var input = Console.ReadLine();
                        if (input.ToLower() == "view")
                        {
                            Journal.View();
                        }
                        else if (input.ToLower() == "create")
                        {
                            Journal.Create();
                        }
                        else
                        {
                            Console.WriteLine("Please choose to 'view' or 'create' an entry.");
                        }

                        //var journal = new Journal();
                        //Journal.ViewMethod();
                       
                        UseJournal();
                        break;


                    case "2":

                        var input2 = Console.ReadLine();
                        //call method for habit tracker creation
                        Console.WriteLine("\nHabit Tracker!");

                        Console.WriteLine("Would you like to view your tracker (1) or add a new habit (2)?");
                        if (input2.ToLower() == "view")
                        {
                            HabitTracker.View();
                        }
                        else if (input2.ToLower() == "add")
                        {
                            HabitTracker.Add();
                        }
                        else
                        {
                            Console.WriteLine("Please choose to 'view' tracker or 'add' a habit.");
                        }
                        UseJournal();
                        break;


                    case "3":

                        //call method for calendar access
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