using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Square : Rectangle //Квадрат
    {
        public Square(double side) : base(side, side)
        {
            Name = "Квадрат";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона квадрата: {Side1}");
        }
    }
}

