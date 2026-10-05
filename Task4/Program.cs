using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 7, 25, 10, 42, 3 };

        // Sort in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        Console.WriteLine("Numbers:");

        // Print each element
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of a number
        int numberToFind = 25;
        int position = Array.IndexOf(numbers, numberToFind);

        Console.WriteLine("Position of " + numberToFind + ": " + position);
    }
}