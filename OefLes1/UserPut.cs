namespace OefLes1;

public class UserPut
{
    public void Greet()
    {
        Console.Write("Voer je naam in: ");
        string name = Console.ReadLine();
        
        Console.Write("Voer je leeftijd in: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        
        Console.WriteLine("Hallo, " +name+ "! Je bent " +age+ " jaar oud.");
        
    }
}
