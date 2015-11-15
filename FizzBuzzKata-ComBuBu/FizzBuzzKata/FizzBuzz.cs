using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public ArrayList ListaDeNumeros = new ArrayList(100);

        public FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                ListaDeNumeros.Add(i);
            }
            
        }

        public string Verificar(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return "FizzBuzz";

            if (num % 5 == 0)
                return "Buzz";

            if (num % 3 == 0)
                return "Fizz";
            
            return num.ToString();
        }


    }
}
