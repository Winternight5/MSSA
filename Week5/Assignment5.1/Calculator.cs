using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    interface iCalculator
    {
        float number { get; set; }
        float addition(float number);
        float subtraction(float number);
        float multiplication(float number);
        float division(float number);

    }
    internal class Calculator : iCalculator
    {
        public float number { get; set; }
        public float addition(float num) => number + num;
        public float subtraction(float num) => number - num;
        public float multiplication(float num) => number * num;
        public float division(float num) => number / num;

    }
}
