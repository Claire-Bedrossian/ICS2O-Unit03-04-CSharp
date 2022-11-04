// Created by: Claire Bedrossian
// Created on: Nov 2022
//
// This program converts degrees fahrenheit to degrees celsuis.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double fahrenheit;
        double celsius;
        Console.WriteLine("This program converts degrees fahrenheit to degrees celsuis.");
        Console.WriteLine("");

        Console.Write("Enter the degrees fahrenheit: ");
        fahrenheit = Convert.ToSingle(Console.ReadLine());

        celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("");
        Console.WriteLine("The degrees celsius is: " + celsius.ToString("0.000") + " °C. ");

        Console.WriteLine("\nDone.");
    }
}