using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    /* Assignment 2.1 Part 1: Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’.
     * Inherit circle shape from base class and add properties like radius.
     * Override calculate area logic for circle.
     * Inherit square class from shape and add change the calculate area logic.
     * Add property like side of square.
     * Take the input from user to select circle or square and display the calculated area . no hard coded values!
     */
    public abstract class Shape {
        public int id { get; set;  }
        public string name { get; set; }
        public string color { get; set; }
        public double area { get; set; }

        public abstract double CalculateArea();
    }
    class Circle : Shape {
        public int radius { get; set; }
        public Circle(int id, string name, string color, int radius) {
            this.id = id;
            this.name = name;
            this.color = color;
            this.radius = radius;
        }

        public override double CalculateArea() {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

    }

    class Square: Shape {
        public int side { get; set; }
        public Square(int id, string name, string color, int length) {
            this.id = id;
            this.name = name;
            this.color = color;
            this.side = length;
        }

        public override double CalculateArea() {
            return Math.Pow(side, 2);
        }

    }
}
