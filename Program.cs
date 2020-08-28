using System;

namespace ConsoleProjectSix
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random numberGen = new Random();

            int numberOfAttempts = 0;
            int attempt = 0;
            
            while (attempt != 6) //Is not equal to 6
            {
                attempt = numberGen.Next(1, 7);
                Console.WriteLine("Tom rolled:" + attempt + ".");
                numberOfAttempts++;
            }
            Console.WriteLine("It took Tom" + numberOfAttempts + "attempt to roll a six");
            Console.ReadKey();
        }
    }
}
