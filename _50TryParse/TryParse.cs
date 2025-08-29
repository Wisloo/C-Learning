namespace _50TryParse;

public class TryParse
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a number: ");
        int.TryParse(Console.ReadLine(), out num); // get an integer num value

        // if it fails to get the number then it will store 0
        
        // num = Convert.ToInt32(Console.ReadLine()); 
        // this only works when we put an integer but will throw an error on the program and exits otherwise.

        if (num == 0)
        {
            Console.WriteLine("Test Succeeded");
        }
        else
        {
            Console.WriteLine("Test failed");
        }
    }
}