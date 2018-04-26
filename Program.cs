using System;

// Паттерн "Наблюдатель" (Observer)
// https://metanit.com/sharp/patterns/3.2.php

namespace _20180320_Task1_Pattern_Observer
{
    class Program
    {
        static void Main()
        {
            // Создание издателя.
            Rose Rose = new Rose();

            // Создание подписчиков.
            Billy Billy = new Billy("Billy", Rose);
            Jack Jack = new Jack("Jack", Rose);

            // Запуск метода обработчика события.
            Rose.FlirtEvent();            

            Console.Read();
        }
    }
}