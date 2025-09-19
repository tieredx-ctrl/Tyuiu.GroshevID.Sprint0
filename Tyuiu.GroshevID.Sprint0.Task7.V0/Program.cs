﻿using Tyuiu.GroshevID.Sprint0.Task7.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #0 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
        Console.WriteLine("* одинаковых массивов по длинне.                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Значение элементов массива №1");
        for (int i = 0; i < arrayNums1.Length; i++)
        {
            Console.Write(arrayNums1[i] + ", ");
        }

        Console.WriteLine();

        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Значение элементов массива №2");
        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Console.Write(arrayNums2[i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (arrayNums1.Length == arrayNums2.Length)
        {
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

            Console.WriteLine("Сумма элементов массива равна:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + ", ");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Исходные имеют разное количество элементов");
        }
        Console.ReadKey();
    }
}