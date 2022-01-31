using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    class Program
    {
        private static Helper run;
        static void Main(string[] args) {
            run = new Helper();

            run.ConsoleWriteLineWithColor("Assignment 4.1:", ConsoleColor.Blue);

            MenuItem[] menuOptions = new MenuItem[5];

            menuOptions[0] = new MenuItem("Part 1", part1);

            menuOptions[1] = new MenuItem("Part 2", part2);

            menuOptions[2] = new MenuItem("Part 3", part3);

            menuOptions[3] = new MenuItem("Part 4", part4);

            menuOptions[4] = new MenuItem("Exit", run.ExitProgram);

            run.MainMenu(menuOptions, -1);
        }

        /* 1. Return even numbers
         * Write a method that returns a string of even numbers greater than 0 and less than 100.
         * Expected input and output
         * ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"
        */
        static void part1() {
            run.ConsoleWriteLineWithColor("Assignment 4.1 Part 1: Write a method that returns a string of even numbers greater than 0 and less than 100.", ConsoleColor.Blue);

        start:
            int minInput = run.InputInteger("Minimum whole number: ");
            int maxInput = run.InputInteger("Maximum whole number: ");

            if (minInput > maxInput) {
                run.ConsoleWriteLineWithColor("Your min number is greater than max number, please try again.", ConsoleColor.Red);
                goto start;
            }

            run.ConsoleWriteLineWithColor("Result: "+ReturnEvenNumbers(minInput, maxInput), ConsoleColor.DarkCyan);
        }

        static string ReturnEvenNumbers(int min, int max) {
            string result = "";

            min = (min % 2 == 0) ? min + 2 : min + 1;

            for (int i = min; i < max; i += 2)
                result += i.ToString()+" ";

            return result; 
        }

        /* 2. If year is leap
         * Given a year as integer, write a method that checks if year is leap.
         * Expected input and output
         * IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
         */
        static public void part2() {
            run.ConsoleWriteLineWithColor("Assignment 4.1 Part 2: Given a year as integer, write a method that checks if year is leap.", ConsoleColor.Blue);

            int yearInput = run.InputInteger("Year: ");

            // IfYearIsLeap(year) method is not used, since its redundant to use if statement again to change color 
            if (DateTime.IsLeapYear(yearInput)) {
                run.ConsoleWriteLineWithColor($"{yearInput} is leap year.", ConsoleColor.DarkGreen);
            } else {
                run.ConsoleWriteLineWithColor($"{yearInput} is NOT a leap year.", ConsoleColor.DarkRed);
            }
        }

        static bool IfYearIsLeap(int year) {
            if (DateTime.IsLeapYear(year))
                return true;

            return false;
        }

        /* 3. String in reverse order
         * Given a string, write a method that returns that string in reverse order.
         * Expected input and output
         * StringInReverseOrder("qwerty") → "ytrewq" StringInReverseOrder("oe93 kr") → "rk 39eo"
         */
        static void part3() {
            run.ConsoleWriteLineWithColor("Assignment 4.1 Part 3: Given a string, write a method that returns that string in reverse order.", ConsoleColor.Blue);

            string userInput = run.InputString("Input a string: ");

            run.ConsoleWriteLineWithColor($"String reversed: {StringInReverseOrder(userInput)}", ConsoleColor.DarkCyan);
        }

        static string StringInReverseOrder(string str) {
            if (String.IsNullOrEmpty(str))
                return "";

            StringBuilder newStr = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--) {
                newStr.Append(str[i]);
            }

            return newStr.ToString();
        }

        /* 4. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
         * Test Data :
         * Please input a string : This is a test string.
         * Expected Output :
         * "This is a test string." contains 4 spaces
         */
        static public void part4() {
            run.ConsoleWriteLineWithColor("Assignment 4.1 Part 4: Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.", ConsoleColor.Blue);

            string userInput = run.InputString("Write a sentence: ");

            run.ConsoleWriteLineWithColor($"Total spaces in sentence: {CountStringSpaces(userInput)}", ConsoleColor.DarkCyan);
        }

        static int CountStringSpaces(string str) {
            if (String.IsNullOrEmpty(str))
                return 0;

            int count = 0;

            foreach (char c in str) {
                if (c == ' ')
                    count++; 
            }

            return count; 
        }
    }
}
