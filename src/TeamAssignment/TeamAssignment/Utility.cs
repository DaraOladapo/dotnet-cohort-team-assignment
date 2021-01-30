using System;
using System.Collections.Generic;
using System.Text;
using TeamAssignment.Model;

namespace TeamAssignment
{
    public static class Utility
    {
        public static void Print(this Team team)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine("______________");
            Console.WriteLine("Members are");
            Console.WriteLine("______________");
            foreach (var member in team.People)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine();
        }
    }
}
