using System;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(2000, 5, 15);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageDifference = currentDate - birthDate;

        int age = (int)(ageDifference.TotalDays / 365.25);

        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current date: " + currentDate);
        Console.WriteLine("Age: " + age + " years");

        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine("Birthdate after 10 days: " + newDate.ToShortDateString());
    }
}