using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fzbz = new FizzBuzz();

            foreach (int num in fzbz.ListaDeNumeros)
            {
                Console.WriteLine(fzbz.Verificar(num));


            }

            Console.Read();

        }




    }
}
