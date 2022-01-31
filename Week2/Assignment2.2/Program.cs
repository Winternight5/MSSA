using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2._2
{
    class Program
    {
        private static Helper run;
        private static string _path = @"c:\Files\";
        private static string _filename = "Assignment2.2Part1.txt";

        static void Main(string[] args) {
            run = new Helper();

            MenuItem[] menuOptions = new MenuItem[3];

            menuOptions[0] = new MenuItem("Assignment 2.2 Part 1", part1);

            menuOptions[1] = new MenuItem("Assignment 2.2 Part 2", part2);

            menuOptions[2] = new MenuItem("Exit", run.ExitProgram);

            run.MainMenu(menuOptions, -1);
        }

        /* Assignment 2.2 Part 1: Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.
         */
        static public void part1() {
            run.ConsoleWriteLineWithColor("Assignment 2.2 Part 1: Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.", ConsoleColor.Blue);

            string filename = run.InputString("Enter a file name: ", true);

            filename = ((filename == "") ? _filename : filename) + ".txt";

            Part1WriteFile(filename);
            Part1ReadFile(filename);
        }

        static public void Part1WriteFile(string path) {
            if (!File.Exists(path)) {
                StreamWriter sw=null;
                try {
                    run.ConsoleWriteLineWithColor("Enter basic details...", ConsoleColor.DarkYellow);
                    using (sw = File.CreateText(path)) {
                        sw.WriteLine("Name: " + run.InputString("Person full name: "));
                        sw.WriteLine("Age: " + run.InputInteger("Age (integer): "));
                        sw.WriteLine("Address: " + run.InputString("Address: "));
                    }
                    run.ConsoleWriteLineWithColor("Writing a text file with basic details...", ConsoleColor.Yellow);

                } catch (Exception ex) {
                    run.ConsoleWriteLineWithColor("Write Error: " + ex.Message, ConsoleColor.Red);
                    run.ConsoleWriteLineWithColor(ex.StackTrace, ConsoleColor.Red);

                } finally {
                    sw.Close();
                }
            } else {
                run.ConsoleWriteLineWithColor("Text file already exist.", ConsoleColor.Yellow);
            }
        }

        static public void Part1ReadFile(string path) {

            if (File.Exists(path)) {
                StreamReader sr = null;
                try {
                    run.ConsoleWriteLineWithColor("Reading the details from same text file:", ConsoleColor.Yellow);
                    using (sr = File.OpenText(path)) {
                        string s = "";
                        while ((s = sr.ReadLine()) != null) {
                            Console.WriteLine(s);
                        }
                    }

                } catch (Exception ex) {
                    run.ConsoleWriteLineWithColor("Read Error: " + ex.Message, ConsoleColor.Red);
                    run.ConsoleWriteLineWithColor(ex.StackTrace, ConsoleColor.Red);

                } finally {
                    sr.Close();
                }

            } else {
                run.ConsoleWriteLineWithColor($"{_filename} file does not exist.", ConsoleColor.Yellow);
            }
        }

        /* Assignment 2.2 Part 2: Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.
         */
        static public void part2() {
            run.ConsoleWriteLineWithColor("Assignment 2.2 Part 2: Design a tip calculator, enter the bill total, tip % and display grand total after adding tip.", ConsoleColor.Blue);

            double bill = run.InputDouble("Enter the bill total: $");
            double tipPercent = run.InputInteger("Enter tip percent (whole number): ");

            double tipValue = Math.Round(bill * (tipPercent / 100), 2);
            double grandTotal = Math.Round(bill + tipValue, 2);

            run.ConsoleWriteLineWithColor($"Tip amount:\t{tipValue.ToString("C"), 8}", ConsoleColor.DarkYellow);
            run.ConsoleWriteLineWithColor(("").PadRight(24, '-'), ConsoleColor.DarkYellow);
            run.ConsoleWriteLineWithColor($"Grand total:\t{grandTotal.ToString("C"), 8}", ConsoleColor.Green);
        }
    }
}
