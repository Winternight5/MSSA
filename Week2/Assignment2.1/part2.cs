using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    // Assignment 2.1 Part 2: Design a class hierarchy of your choice. (Need only class files )  
    public class Movie
    {
        public string VideoFormat { get; set; }
    }

    public class Comedy: Movie
    {
        public string Genre { get; set; }
    }

    public class Action: Comedy
    {
        public string Title { get; set; }
        public string Language { get; set; }
        public string ReleaseDate { get; set; }
    }

    public class Romantic: Comedy
    {
        public string Title { get; set; }
        public string Language { get; set; }
        public string ReleaseDate { get; set; }
    }
}
