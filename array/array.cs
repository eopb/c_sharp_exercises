using System;

public class Array
{
    public static void Main(string[] args)
    {
        var arrayTest = new char[7];
        arrayTest[0] = 'E';
        arrayTest[1] = 'C';
        arrayTest[2] = 'F';
        arrayTest[3] = 'A';
        arrayTest[4] = 'D';
        arrayTest[5] = 'G';
        display(arrayTest);
        arrayTest[6] = 'M';
        display(arrayTest);
    }
    private static void display(char[] arrayTest)
    {
        Console.WriteLine(arrayTest);
        Console.WriteLine("Showing array elements");
        for (int counter = 0; counter < arrayTest.Length; counter++)
            Console.WriteLine("Index: {0}, Element: {1}", counter, arrayTest[counter]);

    }
}