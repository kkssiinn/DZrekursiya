// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите значение M:");
int M = int.Parse(Console.ReadLine());
        
Console.WriteLine("Введите значение N:"); 
int N = int.Parse(Console.ReadLine()); 
        
        
Console.WriteLine("Натуральные числа от {0} до {1}:", M, N);

PrintNumbers(M, N);
    static void PrintNumbers(int M, int N)
    {
        if (M > N) 
        return; 
        
        Console.Write($"{M} "); 
        PrintNumbers(M + 1, N); 
    }    