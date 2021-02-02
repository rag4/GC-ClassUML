using System;
using System.Collections.Generic;

namespace Lab_12___Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person a = new Student("Ramon Guarnes", "1111", "C#", 1, 1.5);
            Person a1 = new Student("Wendi Magee", "2222", ".NET", 2, 1.5);
            Person a2 = new Student("Antonio Manzari", "3333", "Back-End", 3, 1.5);
            Person b = new Staff("Tommy Waalkes", "444", "GrandCircus", 10);
            Person b1 = new Staff("Stephen Jedlicki", "55555", "Bootcamp", 20);

            people.Add(a);
            people.Add(a1);
            people.Add(a2);
            people.Add(b);
            people.Add(b1);

            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }

        }
    }
}
