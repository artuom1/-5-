﻿//    ЗАДАЧА 1



// int size = ReadInt("Введите размерность массива: ");
// int [] numbers = new int[size];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//    if (numbers[i] % 2 == 0)
//    {
//        result++;
//    }
// }
// if (result % 10 == 1)
// {
//    Console.WriteLine($"В массиве {result} четное число");
// }
// if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
// {
//    Console.WriteLine($"В массиве {result} четных числа");
// }
// else

//    Console.WriteLine($"В массиве {result} четных чисел");

// void FillArrayRandomNumbers(int [] array) 
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(99, 999);
//    }
//}

// void PrintArray(int[] array) 
// {
//   for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }


// int ReadInt(string message) 
// {
//    Console.Write(message);
//    return Convert.ToInt32(Console.ReadLine());
// }





//   ЗАДАЧА  2



// int size = ReadInt("Введите размерность массива: ");
// int min = ReadInt("Введите минимальное число массива: ");
// int max = ReadInt("Введите максимальное число массива: ");
// int [] numbers = new int[size];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//    if (i % 2 != 0)
//    {
//        result += numbers[i];
//    }
// }
// Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

// void FillArrayRandomNumbers(int [] array) 
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(min, max);
//    }
//}

// void PrintArray(int[] array) 
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
//}

// int ReadInt(string message)  
// {
//    Console.Write(message);
//    return Convert.ToInt32(Console.ReadLine());
// }




//     ЗАДАЧА  3



// int size = ReadInt("Введите размерность массива: ");
// int min = ReadInt("Введите минимальное число массива: ");
// int max = ReadInt("Введите максимальное число массива: ");
// int [] numbers = new int[size];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int maxFillarray = numbers[0];
// int minFillarray = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//    if (numbers[i] > maxFillarray)
//    {
//        maxFillarray = numbers[i];
//    }
//    if (numbers[i] < minFillarray)
//    {
//        minFillarray = numbers[i];
//    }
// }
// Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");

// void FillArrayRandomNumbers(int [] array) 
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(min, max);
//    }
// }

// void PrintArray(int[] array) 
// {
//    for (int i = 0; i < array.Length; i++)
//    {
 //       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
//}

// int ReadInt(string message)  
//{
//    Console.Write(message);
//    return Convert.ToInt32(Console.ReadLine());
// }
