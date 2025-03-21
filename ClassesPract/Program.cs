using System.Security.Cryptography;
using System.Text.RegularExpressions;
using ClassesPract.Class;

namespace ClassesPract;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            CreditCard card = new CreditCard("1234567890123456", "John Doe", "123", "12/23");
            Console.WriteLine(card);
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}