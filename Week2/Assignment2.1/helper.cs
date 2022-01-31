using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    class Helper
    {
        /* Helper Class. For reuse on console applications */
        public string[] ColorsName = new string[6] { "red", "blue", "yellow", "cyan", "magenta", "gray" };

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
                    return ConsoleColor.Magenta;

                default:
                    return ConsoleColor.Gray;

            }
        }

        public int ValidateMenuOption(string[] arr, string inputLabel) {
            int option;
            do {
                option = SanitizeIntegerInput($"{inputLabel} {string.Join(", ", arr.Select((d, i) => String.Format("{0}={1}", d.Trim(), i)))}: ");

            } while (option >= arr.Length || option < 0);

            return option;
        }

        public int SanitizeIntegerInput(String inputLabel = "", string inputErrorMsg = "Your input is not in a correct format.") {
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

        public string SanitizeStringInput(String inputLabel) {
        // print label of the input
        start:
            Console.Write(inputLabel);

            string value = Console.ReadLine();

            if (value == "") {
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
