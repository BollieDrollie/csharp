namespace OefLes1;

public class Number
{
    public void Numero()
    {
        Console.Write("Voer een getal in: ");
        int number = Convert.ToInt32(Console.ReadLine());
        {
            if (number > 0)
                Console.WriteLine("Positief");
            else if (number < 0)
                Console.WriteLine("Negatief");
            else
                Console.WriteLine("Nul");
            
            
        }
    }
}