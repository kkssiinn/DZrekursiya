// Запрашиваем у пользователя размер массива

        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine());

        
        int[] array = new int[size];

      
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(-999, 999); 
            Console.Write($"{array[i]} ");
        }
        
        Console.WriteLine();
    
       
        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(array, size - 1);


    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return; 
        }

        Console.Write($"{array[index]} "); 
        PrintArrayReverse(array, index - 1); 
    }