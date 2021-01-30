using System;
using System.Collections.Generic;
using TeamAssignment.Model;

namespace TeamAssignment
{
    class Program
    {
        static List<string> unassignedPeople;
        static Team teamAlpha = new Team { Name = "Team Alpha" };
        static Team teamBravo = new Team { Name = "Team Bravo" };
        static Team teamCharlie = new Team { Name = "Team Charlie" };
        static int teamIndex = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Putting people in teams".ToUpper());
            unassignedPeople = People.All;
            while (unassignedPeople.Count > 0)
            {
                var personToAssign = GetPerson(unassignedPeople);
                AssignPerson(personToAssign, teamIndex);
                teamIndex++;
                teamIndex = teamIndex == 4 ? 1 : teamIndex++;
            }
            teamAlpha.Print();
            teamBravo.Print();
            teamCharlie.Print();
        }
        private static void AssignPerson(string persontoAssign, int teamIndex)
        {
            switch (teamIndex)
            {
                case 1:
                    teamAlpha.People.Add(persontoAssign);
                    break;
                case 2:
                    teamBravo.People.Add(persontoAssign);
                    break;
                case 3:
                    teamCharlie.People.Add(persontoAssign);
                    break;
            }
        }
        static string GetPerson(List<string> unassignedPeople)
        {
            var randomIndex = new Random().Next(unassignedPeople.Count);
            var pickedPerson = unassignedPeople[randomIndex];
            unassignedPeople.Remove(pickedPerson);
            return pickedPerson;
        }
    }
}
