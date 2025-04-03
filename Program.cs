using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
                new Circle(5),              // Круг 
                new Rectangle(4, 6),        // Прямоугольник 
                new Square(3),              // Квадрат  
                new Triangle(3, 4, 5)       // Треугольник 
            };

            foreach (var figure in figures)
            {
                figure.Print();
                Console.WriteLine(); 
            }
            Console.ReadLine();
        }
    }
}
