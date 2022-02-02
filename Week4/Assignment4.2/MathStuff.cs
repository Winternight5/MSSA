using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    class MathStuff
    {
        public int Add(int n1, int n2) => n1 + n2;

        public int Add(int[] n1) {
            int total = 0;
            int length = n1.Length;

            for (int i = 0; i < length; i++) {
                total += n1[i];
            }

            return total;
        }

        public float Multiply(float n1, float n2) => n1 * n2;
        public float Multiply(float[] n1) {
            float total = n1[0];
            int length = n1.Length;

            for (int i = 1; i < length; i++) {
                total = total * n1[i];
            }

            return total;
        }
    }
}
