using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._4
{
    public enum BeverageSize
    {
        Tall,
        Grande,
        Venti
    }

    public abstract class Beverage
    {
        public string Name { get; set; }
        public BeverageSize Size { get; set; }
    }

    public class Coffee : Beverage
    {
        public Double Price { get; set; }
    }
}