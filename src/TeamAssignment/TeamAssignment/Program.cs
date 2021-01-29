using System;
using System.Collections.Generic;
using TeamAssignment.Model;

namespace TeamAssignment
{
    class Program
    {
       
        static void Main(string[] args)
        {
            foreach(var a in People.All)
            {
                Console.WriteLine(  a);
            }
        }
    }
}
