using System;

namespace OOP_lab_2_vol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть години для початкового часу:");
            int startHour = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть хвилини для початкового часу:");
            int startMinute = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть секунди для початкового часу:");
            int startSecond = int.Parse(Console.ReadLine());

            Time currentTime = new Time(startHour, startMinute, startSecond);

            Console.WriteLine("Поточний час: " + currentTime);

            Console.WriteLine("Введіть кількість годин для додавання:");
            int hoursToAdd = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість хвилин для додавання:");
            int minutesToAdd = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість секунд для додавання:");
            int secondsToAdd = int.Parse(Console.ReadLine());

            currentTime.AddHours(hoursToAdd);
            currentTime.AddMinutes(minutesToAdd);
            currentTime.AddSeconds(secondsToAdd);

            Console.WriteLine("Час після додавання: " + currentTime);

            string currentLesson = currentTime.WhatLesson();
            Console.WriteLine("Зараз: " + currentLesson);
        }
    }
}