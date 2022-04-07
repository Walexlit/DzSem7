// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4. 0,5 7 -2 -0,2 1 -3,3 8 -9,9 8 7,8 -7,1 9


// Console.WriteLine("Введите количество строк массива");
// int StrokaMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int StolbMass = Convert.ToInt32(Console.ReadLine());
// double[,] Mass = new double[StrokaMass, StolbMass];

// for (int k = 0; k < StrokaMass; k++)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < StolbMass; i++)
//     {
//         Mass[k, i] = rnd.NextDouble();
//         Console.Write($" {Mass[k, i]}\t");
//     }
//     Console.WriteLine(" ");
// }







// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Пример: 1 4 7 2 5 9 2 3 8 4 2 4 Вывод -> 1 4 7 2 5 81 2 9 8 4 2 4


// Console.WriteLine("Введите количество строк массива");
// int StrokaMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int StolbMass = Convert.ToInt32(Console.ReadLine());
// int[,] Mass = new int[StrokaMass, StolbMass];
// void Massive(int[,] mas)
// {
//     for (int k = 0; k < mas.GetLength(0); k++)
//     {
//         for (int i = 0; i < mas.GetLength(1); i++)
//         {
//             Mass[k, i] = new Random().Next(0, 11);
//             Console.Write($" {Mass[k, i]}\t");
//         }
//         Console.WriteLine(" ");
//     }
// }
// void Massive2(int[,] mas)
// {
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             if (i % 2 == 1 && j % 2 == 1)
//             {
//                 mas[i, j] *= mas[i, j];
//             }
//             Console.Write($" {Mass[i, j]}\t");
//         }
//         Console.WriteLine(" ");
//     }

// }
// Massive(Mass);
// Console.WriteLine(" ");
// Massive2(Mass);






// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Пример:
// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// Console.WriteLine("Введите количество строк массива");
// int StrokaMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int StolbMass = Convert.ToInt32(Console.ReadLine());
// int[,] Mass = new int[StrokaMass, StolbMass];
// void Massive(int[,] mas)
// {
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             Mass[i, j] = new Random().Next(0, 11);
//             Console.Write($" {Mass[i, j]}\t");
//         }
//         Console.WriteLine(" ");
//     }
// }
// void Massive2(int[,] mas)
// {
//     double sum = 0;
//     for (int i = 0; i < mas.GetLength(1); i++)
//     {
//         for (int j = 0; j < mas.GetLength(0); j++)
//         {
//             sum += mas[j, i];
//         }
//         sum /= mas.GetLength(0);
//         Console.WriteLine($" средее арифметическое  столбца {i + 1} равна {sum}");
//         sum = 0;
//     }
// }


// Massive(Mass);
// Console.WriteLine(" ");
// Massive2(Mass);
