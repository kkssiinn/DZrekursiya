// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите значение m:");
        double m = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        double n = double.Parse(Console.ReadLine());

        
        double result = Ackermann(m, n);

     
        Console.WriteLine($"A({m}, {n}) = {result}");
    

    static double Ackermann(double m, double n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else // m > 0 && n > 0
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
