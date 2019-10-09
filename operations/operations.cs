using System;

public class Operations
{
    public static void Main(string[] args)
    {
        Console.Write("Please input an number: ");
        int input_num;
        while (true)
        {
            try { input_num = Int32.Parse(Console.ReadLine()); break; }
            catch { Console.WriteLine("Unable to parse input. Please try again."); }
        }
        Console.Write("Please input an string: ");
        string your_string = Console.ReadLine();
        Console.WriteLine("Your number ...");
        Console.WriteLine("+2 = {0}", input_num + 2);
        Console.WriteLine("/2 = {0}", input_num / 2);
        Console.WriteLine("*2 = {0}", input_num * 2);
        Console.WriteLine("-2 = {0}", input_num - 2);
        Console.WriteLine("%2 = {0}", input_num % 2);
        Console.WriteLine("^2 = {0}", Math.Pow(input_num, 2));
        Console.WriteLine("You did " + (input_num != 2 ? "not " : "") + "input 2");
        Console.WriteLine(
            "Also your string \"" + your_string + "\" is cool. It is " + your_string.Length + " digits long."
        );

    }
}