using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    class Program
    {
        private static Helper run;
        private static Random rnd;
        private static Menu home;
        private static Menu homeOverloading;
        private static MathStuff doMath;

        private static bool getUserInput = false;
        private static string assignmentName = "Assignment 4.2";

        static void Main(string[] args) {
            run = new Helper();
            rnd = new Random();
            doMath = new MathStuff();

            run.ConsoleWriteLineWithColor($"{assignmentName}:", ConsoleColor.Blue);

            home = new Menu("Home", true);

            MenuItem[] menuOptions = new MenuItem[5];
            menuOptions[0] = new MenuItem("Part 1", part1);
            menuOptions[1] = new MenuItem("Part 2", part2);
            menuOptions[2] = new MenuItem("Part 3", part3);
            menuOptions[3] = new MenuItem("Part 4", part4);
            menuOptions[4] = new MenuItem("Exit", exitMainMenu);

            home.setMenuItems(menuOptions);

            run.LoadMenu(home, -1);
        }

        static void exitMainMenu() {
            home.activeMenu = false;
        }

        /* 1. Create a 2D array to store integers and print them in matrix format with proper formatting.
         * e. g:
         * | 2 | 3 | 4 |
         * | 1 | 4 | 6 |
        */
        static void part1() {
            run.ConsoleWriteLineWithColor($"{assignmentName} Part 1: Create a 2D array to store integers and print them in matrix format with proper formatting.", ConsoleColor.Blue);

            GetUserInput(3, 3, "Generated 3 x 3 matrix:");
        }

        // Overloading GetUserInput() user input for matrix takes x and y 
        public static void GetUserInput(int x, int y) {
            GetUserInput(x, y, null);
        }

        // Overloading GetUserInput() user input for matrix takes x, y, and matrix label
        public static int[,] GetUserInput(int x, int y, string label) {
            int[,] arr = new int[x, y];
            int maxLength = 0;

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    int inputValue;

                    if (getUserInput)
                        inputValue = run.InputInteger($"Grid ({i}, {j}): ");
                    else
                        inputValue = rnd.Next(100);

                    arr[i, j] = inputValue;

                    int inputLength = run.FindNumberOfDigit(ref inputValue);

                    if (inputLength > maxLength)
                        maxLength = inputLength;
                }
            }
            PrintMatrix(arr, maxLength, label);

            return arr;
        }

        public static void PrintMatrix(int[,] arr, int maxLength, string label) {
            if (arr == null || arr.Length == 0) 
                return;

            StringBuilder[] sbArr = new StringBuilder[arr.Length];

            int ILength = arr.GetLength(0);
            int JLength = arr.GetLength(1);

            label = (label == null || label == "") ? "Your maxtrix:" : label;

            run.ConsoleWriteLineWithColor($"{label}", ConsoleColor.Yellow);

            for (int i = 0; i < ILength; i++) {
                sbArr[i] = new StringBuilder();

                for (int j = 0; j < JLength; j++) {
                    sbArr[i].Append($" {arr[i, j].ToString().PadRight(maxLength)}");

                    if (j < JLength - 1)
                        sbArr[i].Append($"{"|", 2}");
                }

                run.ConsoleWriteLineWithColor($"{sbArr[i]}", ConsoleColor.Yellow);
            }
            Console.WriteLine();
        }

        /* 2. Write a program in C# Sharp for addition of two Matrices of same size.
         * Test Data :
         * Input the size of the square matrix (less than 5): 2
         * Input elements in the first matrix :
         * element - [0],[0] : 1
         * element - [0],[1] : 2
         * element - [1],[0] : 3
         * element - [1],[1] : 4
         * 
         * Input elements in the second matrix :
         * element - [0],[0] : 5
         * element - [0],[1] : 6
         * element - [1],[0] : 7
         * element - [1],[1] : 8
         * 
         * Expected Output:
         * The First matrix is:
         * 1 2
         * 3 4
         * 
         * The Second matrix is :
         * 5 6
         * 7 8
         * 
         * The Addition of two matrix is :
         * 6 8
         * 10 12
         */
        static public void part2() {
            run.ConsoleWriteLineWithColor($"{assignmentName} Part 2: Write a program in C# Sharp for addition of two Matrices of same size.", ConsoleColor.Blue);

            char autoGenerate = run.InputChar("Allow user input (Y=Yes, Any key=No)?: ");

            if (autoGenerate == 'Y')
                getUserInput = true;
            else 
                getUserInput = false;

        askAmount:
            int maxInput = run.InputInteger("Input the size of the square matrix (more than 1 and less than 5): ");

            if (maxInput < 2 ||maxInput >= 5)
                goto askAmount;

            List<int[,]> arrList = new List<int[,]>();

            for (int i = 0; i < 2; i++) {
                int[,] userInput = GetUserInput(maxInput, maxInput, $"The {run.OrdinalString(i+1)} matrix is: ");
                arrList.Add(userInput);
            }

            int[,] arrResult = new int[maxInput, maxInput];
            for (int x = 0; x < 2; x++) {
                int[,] thisArr = arrList[x];

                for (int i = 0; i < maxInput; i++) {
                    for (int j = 0; j < maxInput; j++) {
                        arrResult[i, j] += thisArr[i, j];
                    }
                }
            }
            PrintMatrix(arrResult, 3, $"The Addition of two matrix is:");
        }

        /* 3. Create a console application to create following overloaded methods:
         * Int Add(int a, int b) , int Add(int a,int b, int c)
         * float Multiply(float a, float b), float Multiply(float a , float b, float c)
         * Call the above methods by providing a menu to user.
         */
        static void part3() {
            run.ConsoleWriteLineWithColor($"{assignmentName} Part 3: Create a console application to create following overloaded.", ConsoleColor.Blue);

            homeOverloading = new Menu("Overloaded methods", true);

            MenuItem[] menuOptions = new MenuItem[3];
            menuOptions[0] = new MenuItem("Add", part3p1);
            menuOptions[1] = new MenuItem("Multiply", part3p2);
            menuOptions[2] = new MenuItem("Exit", exitOverloadingMenu);

            homeOverloading.setMenuItems(menuOptions);

            run.LoadMenu(homeOverloading, -1, "Available math features:");
        }

        static void exitOverloadingMenu() {
            homeOverloading.activeMenu = false;
           // home.setMenuItems(menuOptions);
        }

        static void part3p1() {
        start:
            int numInput = run.InputInteger("Enter the amount of numbers to add: ");

            if (numInput < 2)
                goto start;

            int total = 0;
            int[] userInputs = new int[numInput];

            for (int i = 0; i < numInput; i++) 
                userInputs[i] = run.InputInteger($"{run.OrdinalString(i+1)} number: ");
            

            if (numInput == 2) 
                total = doMath.Add(userInputs[0], userInputs[1]);
            
                else
                total = doMath.Add(userInputs);
            
            run.ConsoleWriteLineWithColor($"Your total is {total.ToString()}", ConsoleColor.Yellow);
        }

        static void part3p2() {
        start:
            int numInput = run.InputInteger("Enter the amount of numbers to multiply: ");

            if (numInput < 2)
                goto start;

            float total = 0;
            float[] userInputs = new float[numInput];

            for (int i = 0; i < numInput; i++) 
                userInputs[i] = run.InputFloat($"{run.OrdinalString(i + 1)} number: ");
            

            if (numInput == 2) 

                total = doMath.Multiply(userInputs[0], userInputs[1]);
            else 
                total = doMath.Multiply(userInputs);
            
            run.ConsoleWriteLineWithColor($"Your total is {total.ToString()}", ConsoleColor.Yellow);
        }


        /* 4. Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.
         */
        static public void part4() {
            run.ConsoleWriteLineWithColor($"{assignmentName} Part 4: Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.", ConsoleColor.Blue);

            CircleStuff c1 = new CircleStuff();
            CircleStuff c2 = new CircleStuff();

            c1.radius = run.InputDouble("Radius of the first circle: ");
            c2.radius = run.InputDouble("Radius of the second circle: ");
            c1.area = c1.CalculateArea();
            c2.area = c2.CalculateArea();

            CircleStuff c3 = c1 + c2;
            CircleStuff c4 = c1 - c2;

            run.ConsoleWriteLineWithColor("Result of both circle:", ConsoleColor.DarkYellow);
            run.ConsoleWriteLineWithColor($"Total area combined: {c3.area:0.###}", ConsoleColor.Green);
            run.ConsoleWriteLineWithColor($"Total area differences: {c4.area:0.###}", ConsoleColor.Yellow);
        }
    }
}
