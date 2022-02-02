using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    class CircleStuff
    {
        public double radius { get; set; }
        public double area { get; set; }

        public static CircleStuff operator +(CircleStuff c1, CircleStuff c2) {
            CircleStuff cnew = new CircleStuff();

            cnew.area = c1.area + c2.area;
            cnew.radius = cnew.CalculateRadius(cnew.area);

            return cnew;
        }
        public static CircleStuff operator -(CircleStuff c1, CircleStuff c2) {
            CircleStuff cNew = new CircleStuff();

            if (c1.radius > c2.radius) 
                cNew.area = c1.area - c2.area;

            else 
                cNew.area = c2.area - c1.area;
            
            return cNew;
        }
        public double CalculateArea() {
            this.area = Math.PI * this.radius * this.radius;
            return this.area;
        }

        public double CalculateRadius(double area) {
            this.radius = Math.Sqrt(area / Math.PI);
            return this.radius;
        }
    }
}
