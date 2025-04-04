using System;

namespace Kotiki.Common
{
    public class Cat
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        // Конструктор
        public Cat(string name, string color, int age)
        {
            Id = Guid.NewGuid();
            Name = name;
            Color = color;
            Age = age;
        }

        // Метод для виводу інформації
        public void Meow()
        {
            Console.WriteLine($"{Name} каже: Мяу!");
        }

        // Перевизначення ToString для зручного виводу
        public override string ToString()
        {
            return $"Кіт {Name}, Колір: {Color}, Вік: {Age} років";
        }
    }
}

