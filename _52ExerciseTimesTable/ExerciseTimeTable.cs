namespace _52ExerciseTimesTable;

public class ExerciseTimeTable
{
    public static void Main(string[] args)
    { // Print the multiplication table of a number to 10
        int num, result;
        Console.Write("Enter a number to know the multiplication table to 10: ");

        
        if (int.TryParse(Console.ReadLine(), out num))
        {
            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                // Console.Write(result + " = ");
                Console.WriteLine("{0} * {1} = {2}", num, i, result);
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number: ");
        }    
    }
}