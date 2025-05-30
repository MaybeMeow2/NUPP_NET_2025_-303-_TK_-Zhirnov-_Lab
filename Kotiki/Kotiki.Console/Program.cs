using System;
using Kotiki.Common;

class Program
{
    static void Main()
    {
       
        Cat myCat = new Cat("Мурчик", "Чорний", 3);

       
        Console.WriteLine(myCat);

     
        myCat.Meow();

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
