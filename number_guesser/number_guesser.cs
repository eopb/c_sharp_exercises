using System;

public class NumberGuesser
{
    public static void Main(string[] args)
    {
        int attempts = 0;
        Random rnd = new Random();
        int rndNumber = rnd.Next(1, 101);
        Console.WriteLine("Welcome to my guessing game.");
        Console.WriteLine("I am thinking of a number from 1 to 100.");
        while (true)
        {
            Console.Write("Please input your guess: ");
            int input;
            try { input = Int32.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Unable to parse input. Please try again."); continue; }
            attempts++;
            if (input == rndNumber)
            {
                Console.WriteLine("You win!");
                break;
            }
            else if (input > rndNumber)
            {
                Console.WriteLine("Less than");
            }
            else
            {
                Console.WriteLine("More than");
            }
        }
        int score = 1000 / attempts;
        Console.WriteLine("Score {0} ", score);
        Console.ReadKey();
    }
}