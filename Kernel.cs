using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosGuess
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                guess.Main();
                var input = Console.ReadLine();

            }
            
            
        }
    }
    class GuessNumber
    {
        public static int num = 0;
        public static int maxs = 100;

        public static int curr = 0;
        public static bool Comp()
        {
            if (curr == num)
            {
                Console.WriteLine("you guess the number");
                return true;
            }
            if (curr > num) Console.WriteLine("you number is to big");
            if (curr < num) Console.WriteLine("you number is to low");
            return false;

        }
        public static void gets()
        {
            int nn = 0;
            String s = "";
            Console.WriteLine("give me a number? < {0}", maxs);
            s = Console.ReadLine();
            nn = int.Parse(s);
            curr = nn;

        }
        public static void gene()
        {
            Random rand = new Random();
            // Random integer less than maxs
            num = rand.Next(maxs);



        }
        public static void guessLoop(int maxn)
        {
            maxs = maxn;
            gene();
            while (true)

            {
                bool b = false;
                gets();
                b = Comp();
                if (b) break;
            }
        }

    }




    class guess
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("gess a number !");
            GuessNumber.guessLoop(100);
        }
    }
}
