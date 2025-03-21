using ClassesPract.Class;

namespace ClassesPract;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Number System Conversion");
            Console.WriteLine();
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            Console.WriteLine("3. Decimal to Octal");
            Console.WriteLine("4. Octal to Decimal");
            Console.WriteLine("5. Decimal to Hexadecimal");
            Console.WriteLine("6. Hexadecimal to Decimal");
            Console.WriteLine("7. Binary to Octal");
            Console.WriteLine("8. Octal to Binary");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine();

            var expression = Convert.ToInt32(Console.ReadLine());
            switch (expression)
            {
                case 1:
                    Console.WriteLine("Enter a decimal number: ");
                    var dec = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Binary: {calculator.DecToBin(dec)}");
                    break;
                case 2:
                    Console.WriteLine("Enter a binary number: ");
                    var bin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Decimal: {calculator.BinToDec(bin)}");
                    break;
                case 3:
                    Console.WriteLine("Enter a decimal number: ");
                    dec = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Octal: {calculator.DecToOct(dec)}");
                    break;
                case 4:
                    Console.WriteLine("Enter an octal number: ");
                    var oct = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Decimal: {calculator.OctToDec(oct)}");
                    break;
                case 5:
                    Console.WriteLine("Enter a decimal number: ");
                    dec = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Hexadecimal: {calculator.DecToHex(dec)}");
                    break;
                case 6:
                    Console.WriteLine("Enter a hexadecimal number: ");
                    var hex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Decimal: {calculator.HexToDec(hex)}");
                    break;
                case 7:
                    Console.WriteLine("Enter a binary number: ");
                    bin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Octal: {calculator.BinToOct(bin)}");
                    break;
                case 8:
                    Console.WriteLine("Enter an octal number: ");
                    oct = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Binary: {calculator.OctToBin(oct)}");
                    break;
            }
        }
    }
}