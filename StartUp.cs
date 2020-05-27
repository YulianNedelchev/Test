using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < lines; i++)
            {
                var currentLine = Console.ReadLine().Split();
                var currentPerson = new Person(currentLine[0], int.Parse(currentLine[1]));
                family.AddMember(currentPerson);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
