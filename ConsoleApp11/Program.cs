        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество членов n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("Количество членов n должно быть положительным числом!");
            return;
        }
        double sum = 1.0;
        for (int i = 1; i < n; i++)
        {
            double term = Math.Pow(x, 2 * i) / Factorial(2 * i);
            sum += term;
        }
        Console.WriteLine($"Сумма первых {n} членов ряда = {sum}");    
    static double Factorial(int num)
    {
        double result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

