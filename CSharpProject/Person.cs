using System;

namespace CSharpProject
{
    public class Person
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void PrintAge()
        {
            Console.WriteLine($"My age is {Age}");
        }
    }
}
