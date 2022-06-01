// Created by: Evgeny Vovk
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculate which movie rate can you watch
        int length1;
        int length2;
        int length3;

        // input
        Console.Write("This program tells you which type of triangle you entered. ");
        Console.WriteLine("");
        Console.Write("\nInput three lengths of your triangle: ");
        Console.Write("\n\nfirst length:");
        length1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("second length:");
        length2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("third length:");
        length3 = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if ((length1 <= 0) || (length2 <= 0) || (length3 <= 0)) {
            Console.WriteLine("The length cannot be 0 or negative number..");
        }
        else if ((length1 == length2) && (length2 == length3)) {
            Console.WriteLine("The triangle is an equilateral triangle because all of the lengths and angles are same and equal to each other.");
        }
        else if ((length1 == length2) || (length2 == length3) || (length3 == length1)){
            Console.WriteLine("The triangle is an isosceles triangle because two of the lengths are equal to each other.");
        }
        else if ((length1 != length2) || (length2 != length3) || (length3 != length1)){
            Console.WriteLine("The triangle is a scalene triangle because none of the lengths are equal to each other.");
        }
        Console.WriteLine("\nDone.");
    }
}