using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_figures
{
    class Rectangle : ISquareCalculatable
    {
        private double width, height;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("negative or zero value is passed");
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("negative or zero value is passed");
                height = value;
            }
        }
        public double Area()
        {
            return width * height;
        }
        public override string ToString()
        {
            return string.Format("Rectangle. Width: {0} height: {1} area: {2}", width, height, Area());
        }
    }
}
