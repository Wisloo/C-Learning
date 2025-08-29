namespace _62PasswordChecker;

public class PasswordChecker
{
    public static void Main(string[] args)
    {
        /* ask user to enter a password, and store
         ask the user again to enter a password, and store
         check if they are both containing something
            if so check if they are the same
                if they are then print "passwords match"
                if they aren't then print "passwords does not match" 
            if empty prints "Please enter a password"*/

        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        
        Console.Write("Enter a password again: "); // reconfirmation of password
        string passwordC = Console.ReadLine();

        if (!password.Equals(string.Empty) && !passwordC.Equals(string.Empty)) // checks if both password and passwordC variable are not empty
        {
            if (password.Equals(passwordC)) // compares if password is equals to passwordC
            {
                Console.WriteLine("Passwords Match!");
            }
            else
            {
                Console.WriteLine("Passwords does not match!");
            }
        }
        else
        {
            Console.WriteLine("Please enter a password!");
        }
    }
}