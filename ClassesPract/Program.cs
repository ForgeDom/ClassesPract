namespace ClassesPract;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number from 0 and 1:");
        string input = Console.ReadLine();

        try
        {
            int result = Convert.ToInt32(input, 2);
            Console.WriteLine($"The decimal result is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too big");
        }
    }
}