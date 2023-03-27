using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Basic_Bullet_Journal
{
    internal class Journal : BuJo
    {
        private const string J = "January";

        //use stack??
        public static void Create()
        {
            Console.WriteLine("You are creating a journal entry. Good Job!");
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
            Console.WriteLine("| You are definitely viewing entries right now! |");
        }


    }
}
