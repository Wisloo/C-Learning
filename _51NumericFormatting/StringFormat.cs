namespace _51NumericFormatting;
using System;

public class StringFormat
{
    public static void Main(string[] args)
    {
        double value = 1000D / 12.43D;

        Console.WriteLine(value);
        Console.WriteLine("{0:0.00}", value); // displays the value much like printf, in this case since we had 0.00 after ":" it signifies that it will only print 2 decimal values
        Console.WriteLine("{0:0.0}", value);
        Console.WriteLine("{0:0}", value);

        double money = 10D / 3D; // reason we put D is because these are registering as doubles. if we print this without D it will only output "3"
        Console.WriteLine("${0:0.00}", money); // you can add before and after the format
        Console.WriteLine("$10 / $3 = ${0:0.00}", money);
        Console.WriteLine(money.ToString("$"));
    }
}