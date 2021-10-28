using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WH13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building building = new Building("Новоnторская", 5, 7, 8);
            //Multibuilding multibuilding = new Multibuilding("Новоторская", 5, 7, 8, 7);
            //multibuilding.Print();
            //Console.ReadKey();
        }
    }
    class Building
    {
        //
        public string Adress { get; set; }
        public int Lenght { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Building(string adress, int lenght, int width, int height)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес дома {0}, длина дома {1}, ширина дома {2}, высота дома {3}", Adress, Lenght, Width, Height);
        }
    }
    sealed class Multibuilding:Building
    {
        public int Floor { get; set; }
        public Multibuilding (string adress, int lenght, int width, int height, int floor)

            :base (adress, lenght, width, height)
        {
            Floor = floor;
        }
        public void Print()
        {
            Console.WriteLine("Адрес дома {0}, длина дома {1}, ширина дома {2}, высота дома {3}", Adress, Lenght, Width, Height, Floor);
        }
    }
}
