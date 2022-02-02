using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment4._2
{
    /* Menu Object with callback function.
     * Use with Helper Class -> MainMenu(MenuItem[]);
     * (For reuse on console applications)
     */
    class Menu
    {
        public string name { get; }
        public bool activeMenu { get; set; }
        public MenuItem[] menuOptions { get; set;  }

        public Menu(string Name, bool activeMenu) {
            this.name = Name;
            this.activeMenu = activeMenu;
        }
        public Menu(string Name, bool activeMenu, MenuItem[] MenuItemArray) {
            this.name = Name;
            this.activeMenu = activeMenu;
        }

        public void setMenuItems(MenuItem[] MenuItemArray) {
            this.menuOptions = MenuItemArray;
        }
    }
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
       *    Menu & sub-menu item selection/validation
       *    Sanitize input types
       *    Printing console text with color
       */

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

        public void LoadMenu(Menu menu, int startOption = 0, string label = "Available programs:") {
            char choice = 'Y';
            int option = startOption;

            do {
                MenuItem[] menuOptions = menu.menuOptions;
            start:
                if (option == -1) {
                    ConsoleWriteLineWithColor(label, ConsoleColor.DarkBlue);
                    ConsoleWriteLineWithColor(string.Join("\n", menuOptions.Select((t, i) => String.Format($"{i + 1} = {t.name}"))));

                    do {
                        option = InputInteger("Enter a program number to run: ") - 1;

                    } while (option >= menuOptions.Length || option < 0);

                    Console.WriteLine();
                    menuOptions[option].run();

                } else
                    menuOptions[option].run();

                if (!menu.activeMenu)
                    goto exitProgram;

                choice = InputChar();

                if (choice == 'X') {
                    menu.activeMenu = false;

                } else if (choice != 'Y') {
                    ConsoleWriteLineWithColor($"Exiting \"{menuOptions[option].name}\" program.\n", ConsoleColor.Magenta);
                    option = -1;
                    goto start;
                }

            exitProgram:
                if (!menu.activeMenu)
                    ConsoleWriteLineWithColor($"Good bye.", ConsoleColor.Magenta);

            } while (menu.activeMenu);

            Console.ReadLine();
        }

        public void ExitProgram(Menu menu) {
            menu.activeMenu = false;
        }

        public int ValidateMenuOption(string[] arr, string inputLabel) {
            int option;
            do {
                option = InputInteger($"{inputLabel} {string.Join(", ", arr.Select((t, i) => String.Format($"{i}={t}")))}: ");

            } while (option >= arr.Length || option < 0);

            return option;
        }

        public int FindNumberOfDigit(ref int number) {
            int count = 0;
            while (number > 0) {
                number /= 10;
                count++;
            }
            return count;
        }

        public string OrdinalString(int number) {
            string _th = "th";
            string _s = number.ToString();

            if (number < 1)
                return _s;

            number %= 100;

            if (number >= 11 && number <= 13)
                return _s + _th;

            switch (number % 10) {
                case 1: return _s + "st";
                case 2: return _s + "nd";
                case 3: return _s + "rd";
                default: return _s + _th;
            }
        }

        public char InputChar(string label = "\nDo you want to run this program again? Y=Yes, X=Exit, any key=No: ") {
            char choice;

        tryAgain:
            Console.Write(label);

            try {
                choice = Char.ToUpper(Char.Parse(Console.ReadLine()));

            } catch (Exception ex) {
                ConsoleWriteLineWithColor(ex.Message, ConsoleColor.Red);
                goto tryAgain;
            }

            return choice;
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