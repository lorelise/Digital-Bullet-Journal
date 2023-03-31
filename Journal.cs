using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Basic_Bullet_Journal
{
    internal class Journal : BuJo
    {
        //one file option: but add to it, choose options for adding info? 
        //use stack??
        //so there's not an entry for every single day, but rather by month.
        //for view:
        //please select month to view entry for
        //for create:
        //
        public static void Create()
        {
            

            if (File.Exists(@"C:\Users\britl\Documents\entry1.txt"))
            {
                Console.WriteLine("Journal already exists. Please select 'add' option to add on to your journal.");
            }
            else
            {
                Console.WriteLine("Input journal text below, and hit enter to submit:");

                string journalInput = Console.ReadLine();
                // Create a string array with the lines of text
                string[] lines = { journalInput, "Second line", "Third line" };

                // Set a variable to the Documents path.
                string docPath =
                  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "entry1.txt")))
                {

                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
            }
            //var journalInput = Console.ReadLine();
            //// Create a string array with the lines of text
            //string[] lines = { journalInput, "Second line", "Third line" };

            //// Set a variable to the Documents path.
            //string docPath =
            //  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //// Write the string array to a new file named "WriteLines.txt".
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "entry1.txt")))
            //{

            //        foreach (string line in lines)
            //           outputFile.WriteLine(line);
            //}

            

        }

        public static void View()
        {
            //Console.WriteLine("Choose month:")
            //var input = Console.ReadLine();
            //switch (input)
            //{
            //    case J:
            //        {

            //        }
            //}
            //Console.WriteLine("| You are definitely viewing entries right now! |");

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\britl\Documents\entry1.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
                Console.WriteLine("      --------------------------------------------------------------");
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to return to menu.");
            System.Console.ReadKey();
        }


        public static void Add()
        {
            //method for adding to an entry
            Console.WriteLine("\nYou are adding content to an existing entry. Nice!");
        }


    }
}
