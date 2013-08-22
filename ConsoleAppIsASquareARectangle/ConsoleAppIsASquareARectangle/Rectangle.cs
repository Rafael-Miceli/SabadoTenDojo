using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIsASquareARectangle
{
    public class Rectangle
    {
        private double width;
        private double height;

        public virtual double Width 
        { 
            get { return width; }
            set { width = value; }
        }

        public virtual double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
