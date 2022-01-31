using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    class Program
    {

        static void Main(string[] args) {
            MainMenu();
        }
        /* Assignment 2.1 Part 1: Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’.
         * Inherit circle shape from base class and add properties like radius.
         * Override calculate area logic for circle.
         * Inherit square class from shape and add change the calculate area logic.
         * Add property like side of square.
         * Take the input from user to select circle or square and display the calculated area . no hard coded values!
         */
        static void MainMenu(int option = 0) {
            Helper helper = new Helper();
            string[] menuOptions = new string[2] { "Circle", "Square" };
            string[] ColorsName = helper.ColorsName;
            bool activeMenu = true;
            char choice = 'Y';

            helper.ConsoleWriteLineWithColor("Assignment 2.1 Part 1: Class ‘Shape’ and with properties id, name and color and method calculate area.", ConsoleColor.Blue);

            do {
                int shape = helper.ValidateMenuOption(menuOptions, "Please enter choice");

                helper.ConsoleWriteLineWithColor($"You selected {menuOptions[shape]}", ConsoleColor.Green);

                int id = helper.SanitizeIntegerInput("ID: ");
                string name = helper.SanitizeStringInput("Name: ");
                int color = helper.ValidateMenuOption(ColorsName, "Select color options");
                double area = 0;

                switch (menuOptions[shape]) {
                    case "Circle":
                        int radius = helper.SanitizeIntegerInput("Radius (cm, integer only): ");
                        Circle circle = new Circle(id, name, ColorsName[color], radius);
                        area = circle.CalculateArea();
                        break;

                    case "Square":
                        int side = helper.SanitizeIntegerInput("Side's Length (cm, integer only): ");
                        Square square = new Square(id, name, ColorsName[color], side);
                        area = square.CalculateArea();
                        break;

                }

                helper.ConsoleWriteLineWithColor($"Your shape is {menuOptions[shape]}, named {name} ({id}), {ColorsName[color]} color, and the area is {area.ToString()} cm", helper.Colors(color));

            tryAgain:
                Console.Write("\nDo you want to try again? (enter Y or N): ");

                try {
                    choice = Char.ToUpper(Char.Parse(Console.ReadLine()));

                } catch (Exception ex) {
                    helper.ConsoleWriteLineWithColor(ex.Message, ConsoleColor.Red);
                    goto tryAgain;
                }

                if (choice != 'Y') {
                    helper.ConsoleWriteLineWithColor("Good bye.", ConsoleColor.Magenta);
                    activeMenu = false;
                }

            } while (activeMenu);
            Console.ReadLine();
        }
    }
}
