using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment2._2
{
    /* Menu Object with callback function.
     * Use with Helper Class -> MainMenu(MenuItem[]);
     * (For reuse on console applications)
     */
    class MenuItem
    {
        public string name { get; }
        public Action callback { get; }

        public MenuItem(string name, Action callback) {
            this.name = name;
            this.callback = callback;
        }

        public void run() {
            callback();
        }
    }
    class Helper
    { /* Helper Class: 
       * (For reuse on console applications)
       *    Coloring function
       *    Menu item selection/validation
       *    Sanitize input types
       *    Printing console text with color
       */
        private bool activeMenu = true;
        public string[] ColorsName = new string[7] { "red", "blue", "yellow", "cyan", "magenta", "green", "gray" };

        public ConsoleColor Colors(int index) {
            switch (index) {
                case 0:
                    return ConsoleColor.Red;

                case 1:
                    return ConsoleColor.Blue;

                case 2:
                    return ConsoleColor.Yellow;

                case 3:
                    return ConsoleColor.Cyan;

                case 4:
                    return ConsoleColor.Green;

                default:
                    return ConsoleColor.Gray;

            }
        }

        public void MainMenu(MenuItem[] menuOptions, int startOption = 0) {
            char choice = 'Y';
            int option = startOption;

            do {
            start:
                if (option == -1) {
                    ConsoleWriteLineWithColor("Available programs:", ConsoleColor.DarkBlue);
                    ConsoleWriteLineWithColor(string.Join("\n", menuOptions.Select((t, i) => String.Format($"{i+1} = {t.name}"))));

                    do {
                        option = InputInteger("Enter a program number to run: ") - 1;

                    } while (option >= menuOptions.Length || option < 0);

                    Console.WriteLine();
                    menuOptions[option].run();

                } else
                    menuOptions[option].run();

                if (!activeMenu) 
                    goto exitProgram;
                
            tryAgain:
                Console.Write("\nDo you want to try again? Y=Yes, X=Exit, any key=No: ");

                try {
                    choice = Char.ToUpper(Char.Parse(Console.ReadLine()));

                } catch (Exception ex) {
                    ConsoleWriteLineWithColor(ex.Message, ConsoleColor.Red);
                    goto tryAgain;
                }

                if (choice == 'X') {
                    activeMenu = false;

                } else if (choice != 'Y') {
                    ConsoleWriteLineWithColor($"Exiting \"{menuOptions[option].name}\" program.\n", ConsoleColor.Magenta);
                    option = -1;
                    goto start;
                }

            exitProgram:
                if (!activeMenu) 
                    ConsoleWriteLineWithColor($"Good bye.", ConsoleColor.Magenta);
                
            } while (activeMenu);

            Console.ReadLine();
        }

        public void ExitProgram() {
            activeMenu = false;
        }

        public int ValidateMenuOption(string[] arr, string inputLabel) {
            int option;
            do {
                option = InputInteger($"{inputLabel} {string.Join(", ", arr.Select((t, i) => String.Format($"{i}={t}")))}: ");

            } while (option >= arr.Length || option < 0);

            return option;
        }

        public int InputInteger(String inputLabel = "", string inputErrorMsg = "Your input is not in a correct format.") {
        tryAgain:
            // print label of the input
            Console.Write(inputLabel);
            int inputValue = 0;

            try {
                inputValue = Int32.Parse(Console.ReadLine());

            } catch (Exception ex) {
                ConsoleWriteLineWithColor(inputErrorMsg, ConsoleColor.Red);
                goto tryAgain;
            }

            return inputValue;
        }

        public float InputFloat(String inputLabel = "", string inputErrorMsg = "Your input is not in a correct format.") {
        tryAgain:
            // print label of the input
            Console.Write(inputLabel);
            float inputValue = 0;

            try {
                inputValue = float.Parse(Console.ReadLine());

            } catch (Exception ex) {
                ConsoleWriteLineWithColor(inputErrorMsg, ConsoleColor.Red);
                goto tryAgain;
            }

            return inputValue;
        }

        public double InputDouble(String inputLabel = "", string inputErrorMsg = "Your input is not in a correct format.") {
        tryAgain:
            // print label of the input
            Console.Write(inputLabel);
            double inputValue = 0;

            try {
                inputValue = float.Parse(Console.ReadLine());

            } catch (Exception ex) {
                ConsoleWriteLineWithColor(inputErrorMsg, ConsoleColor.Red);
                goto tryAgain;
            }

            return inputValue;
        }

        public decimal InputDecimal(String inputLabel = "", string inputErrorMsg = "Your input is not in a correct format.") {
        tryAgain:
            // print label of the input
            Console.Write(inputLabel);
            decimal inputValue = 0;

            try {
                inputValue = Decimal.Parse(Console.ReadLine());

            } catch (Exception ex) {
                ConsoleWriteLineWithColor(inputErrorMsg, ConsoleColor.Red);
                goto tryAgain;
            }

            return inputValue;
        }

        public string InputString(String inputLabel, bool lettersNumbersOnly = false) {
        // print label of the input
        start:
            Console.Write(inputLabel);

            string value = Console.ReadLine();

            if (lettersNumbersOnly && !Regex.IsMatch(value, @"^[a-zA-Z0-9]+$")) {
                ConsoleWriteLineWithColor("This input only accept alphabet characters, and integers.", ConsoleColor.Red);
                goto start;

            } else if (value == "") {
                ConsoleWriteLineWithColor("This input cannot be empty.", ConsoleColor.Red);
                goto start;

            } else {
                return value;
            }
        }

        public void ConsoleWriteLineWithColor(string text = "This is default message.", ConsoleColor color = ConsoleColor.Gray) {
            if (color != ConsoleColor.Gray)
                Console.ForegroundColor = color;

            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
