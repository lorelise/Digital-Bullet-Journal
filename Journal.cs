using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Basic_Bullet_Journal
{
    internal class Journal : BuJo
    {

        // method for creating initial journal file
        public static void Create()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bulletjournal.txt");
            if (File.Exists(@filePath))
            {
                Console.WriteLine("Journal already exists. Please select 'add' option to add on to your journal, or 'delete' to delete journal entirely.");
            }
            else
            {
                Console.WriteLine("Input journal text below, and hit enter to submit:");
                
                string journalInput = Console.ReadLine();

                string[] lines = { journalInput };

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write the string array to a new file
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "bulletjournal.txt")))
                {

                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
            }
        }

        // method for viewing journal
        public static void View()
        {


            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bulletjournal.txt");
            string[] lines = File.ReadAllLines(@filePath);

            // display contents
            Console.WriteLine("");
            foreach (string line in lines)
            {

                Console.WriteLine("\t" + line);
                Console.WriteLine("      --------------------------------------------------------------");
            }

            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
        }


        // method for adding to journal
        public static void Add()
        {
            Console.WriteLine("\nBegin typing journal content and press enter to save.");
            // Set a variable to the Documents path.
            var append = Console.ReadLine();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Append text to an existing file
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "bulletjournal.txt"), true))
            {
                outputFile.WriteLine(append);
            }
        }

        public static void Delete()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bulletjournal.txt");
            if (File.Exists(@filePath))
            {
                File.Delete(@filePath);
                Console.WriteLine("Journal has been deleted.");
            }
        }

    }
}
