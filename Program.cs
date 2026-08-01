using System;
using System.Globalization;

class GuessNumber { 
    public static int num =0;
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
        Console.WriteLine("give me a number? < {0}",maxs);
        s=Console.ReadLine();
        nn = int.Parse(s) ;
        curr = nn;
    
    }
    public static void gene() 
    {
        Random rand = new Random();
        // Random integer less than maxs
        num=rand.Next(maxs);



    }
    public static void guessLoop(int maxn) 
    {
        maxs= maxn;
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




class guess {
    public static void Main(String[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("gess a number !");
        GuessNumber.guessLoop(100);
    }
}