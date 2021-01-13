/*
Programmer: Felipe SG
Date: 12/01/2021
Program: 3exercise10
Objective: 
Write a program that takes as input a four-digit number in format abcd
(e.g. 2011) and performs the following actions:
- Calculates the sum of the digits (in our example 2+0+1+1 = 4).
- Prints on the console the number in reversed order: dcba (in our
example 1102).
- Puts the last digit in the first position: dabc (in our example 1201).
- Exchanges the second and the third digits: acbd (in our example
2101).
 */


using System;

namespace _3Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int number, fisrtDigit, secondDigit, thirdDigit, fourthDigit, sum;

            Console.WriteLine("Welcome \n");
            Console.WriteLine("Please insert a 4 digit number: ");
            number = Convert.ToInt32(Console.ReadLine());
            fisrtDigit = (int)(number.ToString()[0]) - 48;
            secondDigit = (int)(number.ToString()[1]) - 48;
            thirdDigit = (int)(number.ToString()[2]) - 48;
            fourthDigit = (int)(number.ToString()[3]) - 48;

            // Sum all digits
            sum = fisrtDigit + secondDigit + thirdDigit + fourthDigit;

            // Print the results
            Console.WriteLine("The typed number is: {0}", number);
            Console.WriteLine("The sum of the digits is: {0}", sum);
            Console.WriteLine("The reversed order of {0} is: {4}{3}{2}{1}", number, fisrtDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("The last digit in first position: {3}{0}{1}{2}", fisrtDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("The swap between second and third position: {0}{2}{1}{3}", fisrtDigit, secondDigit, thirdDigit, fourthDigit);

        }
    }
}
