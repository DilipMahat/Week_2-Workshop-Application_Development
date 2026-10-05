using System;

class Program
{
    static void Main()
    {
        byte byteValue = 100;
        short shortValue = 20000;
        int intValue = 42;
        long longValue = 1000000000L;
        float floatValue = 3.14f;
        double doubleValue = 3.14159;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;

        // Convert integer 42 to string
        string numberString = intValue.ToString();

        // Convert string "3.14" to double
        double convertedDouble = double.Parse("3.14");

        Console.WriteLine("byte: " + byteValue);
        Console.WriteLine("short: " + shortValue);
        Console.WriteLine("int: " + intValue);
        Console.WriteLine("long: " + longValue);
        Console.WriteLine("float: " + floatValue);
        Console.WriteLine("double: " + doubleValue);
        Console.WriteLine("decimal: " + decimalValue);
        Console.WriteLine("char: " + charValue);
        Console.WriteLine("bool: " + boolValue);

        Console.WriteLine("Integer converted to string: " + numberString);
        Console.WriteLine("String converted to double: " + convertedDouble);
    }
}