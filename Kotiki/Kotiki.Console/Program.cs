using System;
using Kotiki.Common;

class Program
{
    static void Main()
    {
        // Створюємо нового котика
        Cat myCat = new Cat("Мурчик", "Чорний", 3);

        // Виводимо інформацію про кота
        Console.WriteLine(myCat);

        // Викликаємо метод, щоб кіт "мявкнув"
        myCat.Meow();

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
