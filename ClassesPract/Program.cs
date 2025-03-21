using ClassesPract.Class;

namespace ClassesPract;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven",7},
            {"eight", 8},
            {"nine", 9},
            {"zero", 0}
        };
        
        Console.WriteLine("Write word that means the figure fromn 0 - 9:");
        string input = Console.ReadLine().ToLower();

        if (dictionary.ContainsKey(input))
        {
            int number = dictionary[input];
            Console.WriteLine($"Number: {number}");
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}