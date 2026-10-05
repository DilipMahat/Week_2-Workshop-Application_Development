using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of fruits
        List<string> fruits = new List<string>
        {
            "Apple",
            "Mango",
            "Banana"
        };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        Console.WriteLine("Fruits:");

        // Print all fruits
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a dictionary
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

        // Add a new entry
        fruitDictionary.Add(4, "Orange");

        Console.WriteLine("\nFruit Dictionary:");

        // Print key-value pairs
        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine("ID: " + item.Key + ", Fruit: " + item.Value);
        }
    }
}