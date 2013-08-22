using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIsASquareARectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Square s = new Square();
            s.Height = 1;
            s.Width = 2;

            SetWidthViolatingLsp(s);

            Console.WriteLine(s.Height);
            Console.WriteLine(s.Width);

            Console.ReadKey();

        }

        public static void SetWidthViolatingLsp(Rectangle r)
        {
            r.Width = 32;

            Console.WriteLine(r.Height);
            Console.WriteLine(r.Width);
        }

        public static void SetHeightViolatingLsp(Rectangle r)
        {
            r.Height = 10;
        }
    }
}
