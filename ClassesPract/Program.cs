namespace ClassesPract;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array of numbers from 0 to 9:");
        string input = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(input);
            Console.WriteLine($"Converted number: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input is not a number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too big");
        }
    }
}