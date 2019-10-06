using System;

public class CountDown
{
    public static void Main(string[] args)
    {
        int count = 12;
        while (count > 0)
        {
            Console.WriteLine(count);
            count--;
        }
    }
}