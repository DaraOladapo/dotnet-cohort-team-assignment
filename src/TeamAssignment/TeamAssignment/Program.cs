using System;
using System.Collections.Generic;

namespace TeamAssignment
{
    class Program
    {
        public static List<string> People = new List<string> { "AndrewK", "AndrewO", "Winie", "Ben", "Mathew", "Adam", "Gabi", "Stephen", "Usama", "James", "Olga" };
        static void Main(string[] args)
        {
            foreach(var a in People)
            {
                Console.WriteLine(  a);
            }
        }
    }
}
