namespace _61PrintStringInReverse;

public class PrintStringInReverse
{
    public static void Main(string[] args)
    {
        string message = string.Empty;
        
        Console.Write("Enter your message: ");
        message = Console.ReadLine();

        Console.WriteLine("Normal:");
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
        }
        
        Console.WriteLine("\nReversed:");
        for (int i = message.Length - 1; i >= 0; i--)
        {
            Console.Write(message[i]);
        }
        
        
    }
}