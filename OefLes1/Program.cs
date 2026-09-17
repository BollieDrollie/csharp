using System;
namespace OefLes1
{
    partial class Program
    {
        static void Main()
        {
            String name = "Arthur";
            int age = 19;
            double pi = 3.14159;
            bool isProgrammingFun = true;
            Console.WriteLine("Mijn naam is "+ name+". Ik ben "+age+" Jaar oud.");
            Console.WriteLine("De waarde van pi is "+ pi+ ".");
            Console.WriteLine("Vind ik programmeren leuk? "+isProgrammingFun);
            
            UserPut myInput = new UserPut();
            myInput.Greet();
            
            Number myNumber = new Number();
            myNumber.Numero();
            
            Loop myLoop = new Loop();
            myLoop.Loopie();
            
            Person  myPerson = new Person();
            myPerson.Personn = new Person();
        }
        
    }
}
