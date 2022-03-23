using System;

namespace SelectStatementEx
{
    internal class Program
    {
        static void Main (string[] args)
        {
            /*Exercise one
            Console.WriteLine("Pick a number 1 to 10!");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > 9)
            {
                Console.WriteLine("thats too high"); ;
            }
            else if (userInput < 9)
            {
                Console.WriteLine("thats too low");
            }
            else 
            {
                Console.WriteLine("you got it right!");
            }

            int getanswer = ( userInput > 9) ? "Too Low" : "Too high"
            */

            Console.WriteLine("Hey let's talk about our favorite type of book genre, what is yours?");

            var userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
               
                case "nonfiction":
                    Console.WriteLine("Uhm i guess");
                    break;
                case "fiction":
                    Console.WriteLine("Better than nonfiction right?");
                    break;
                case "science fiction":
                    Console.WriteLine("beam me up Scottie! I love it");
                    break;
                default:
                    Console.WriteLine("try again, i didn't catch that");
                    break;
                    
            }






        }


    }
}
