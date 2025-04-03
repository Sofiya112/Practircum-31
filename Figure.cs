using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Figure
    {
        private string name;

        public string Name //Свойство для доступа
        {
            get { return name; }
            set { name = value; }
        }

        public Figure(string Name) // Конструктор без параметров
        {
            Name = name;
        }

        public abstract double Area(); //Площадь фигуры



       public abstract double   Perimeter(); //Площадь фигуры


        public virtual void Print() //Вывод инф 
        {
            Console.WriteLine($"Фигура: {Name}");
        }



    }
}
