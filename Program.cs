using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("ชั้นของสามเหลี่ยมปาสคาล: ");
            int rowNumber = int.Parse(Console.ReadLine());

            if (rowNumber < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            }
                


            for (int i = 0; i <= rowNumber; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    int value = CalculatePascalValue(i, j);
                Console.Write(CalculatePascalValue(i, j) + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }

    public static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }

        int numerator = CalculateFactorial(row);
        int denominator = CalculateFactorial(column) * CalculateFactorial(row - column);

        return numerator / denominator;
    }

    public static int CalculateFactorial(int number)
    {
        if (number == 0 || number == 1)
        {
            return 1;
        }

        int factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
