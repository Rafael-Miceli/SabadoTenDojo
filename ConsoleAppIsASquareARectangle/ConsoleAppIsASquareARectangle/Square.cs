using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIsASquareARectangle
{
    public class Square: Rectangle
    {
        public new double Width
        {
            set 
            {
                base.Width = value;
                base.Height = value;
            }
            get { return base.Width; }
        }

        public new double Height
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }

            get { return base.Height; }
        }
    }
}
