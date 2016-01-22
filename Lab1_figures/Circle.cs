using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_figures
{
    class Circle : ISquareCalculatable
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= radius)
                    throw new Exception("negative or zero value is passed.");
                radius = value;
            }
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return string.Format("Circle. Radius: {0} area: {1}", radius, Area());
        }
    }
}
