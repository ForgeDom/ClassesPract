using System.Data;
using ClassesPract.Class;

namespace ClassesPract;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть логічний вираз (наприклад, 3>2 або 7<3):");
        string input = Console.ReadLine();

        try
        {
            bool result = EvaluateExpression(input);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static bool EvaluateExpression(string expression)
    {
        try
        {
            var table = new DataTable();
            table.Columns.Add("expression", typeof(bool), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return (bool)row["expression"];
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Неправильний вираз. Будь ласка, введіть коректний логічний вираз.", ex);
        }
    }
}