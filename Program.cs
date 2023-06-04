// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A:");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B:");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(GetNumberStep());

// int GetNumberStep()
// {
//     int Step = A;

//     for (int i = 1; i < B; i++)
//     {
//         Step = Step * A;
//     }
//     return Step;
// } 

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumNumbers());

// int SumNumbers()
// {
//     int i = 0;
//     int num2 = 0;
//     int Sum = 0;

//     while (num > 0)
//     {
//         num2 = num%10;
//         Sum = Sum + num2;
//         num = num/10;
//         i = i++;
//     }
//     return Sum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void CreateArray()
// {
//     int[] arr = new int[8];
//     int i = 0;
//     while (i < arr.Length)
//     {
//         arr[i] = new Random().Next(1,99);
//         Console.Write($"{arr[i]}, " );
//         i++;
              
//     }
// }
// CreateArray();