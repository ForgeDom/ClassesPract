using ClassesPract.Class;

namespace ClassesPract;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Passport passport = new Passport("John Doe", "123456", "2021-01-01");
            Console.WriteLine($"Full Name: {passport.FullName}");
            Console.WriteLine($"Passport Number: {passport.PassportNumber}");
            Console.WriteLine($"Date of Issue: {passport.DateOfIssue}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}