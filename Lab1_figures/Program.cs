using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_figures
{
    /// <summary>
    /// This program computes the area of rectangle, square, triangle, circle. Classes are inherited from interface
    /// with Area() method. 
    /// </summary>
    interface ISquareCalculatable
    {
        double Area();
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle r = new Rectangle();
                r.Width = 10;
                r.Height = 4;
                Console.WriteLine(r);
                Square s = new Square();
                s.Side = 5.5;
                Console.WriteLine(s);
                Circle c = new Circle();
                c.Radius = 2;
                Console.WriteLine(c);
                Triangle t = new Triangle();
                t.A = 4;
                t.B = 7;
                t.Angle = 30;
                Console.WriteLine(t);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}