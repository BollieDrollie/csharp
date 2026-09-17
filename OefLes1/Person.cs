namespace OefLes1;

using System;

class Person
{
    public string Name;
    public int Age;
    public Person Personn { get; set; }

    public void Introduce() => Console.WriteLine("Hoi, ik ben {Name} en ik ben {Age} jaar oud.");
}

partial class Program
{
    static void Personn()
    {
        Console.Write("Naam: ");
        string name = Console.ReadLine();

        Console.Write("Leeftijd: ");
        int age = int.Parse(Console.ReadLine());

        Person p = new Person { Name = name, Age = age };
        p.Introduce();
    }
}