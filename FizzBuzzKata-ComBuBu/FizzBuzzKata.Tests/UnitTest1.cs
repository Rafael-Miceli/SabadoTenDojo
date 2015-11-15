using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Garantir_Uma_Lista_De_100_Numeros()
        {
            int resultadoEsperado = 100;

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();

            int resultado = sut.ListaDeNumeros.Count;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Garantir_Fizz_em_3()
        {
            string resultadoEsperado = "Fizz";

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();

            string resultado = sut.Verificar(3);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Garantir_Retorne_2_Ao_Passar_2()
        {
            string resultadoEsperado = "2";

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();

            string resultado = sut.Verificar(2);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Garantir_Fizz_Em_Apenas_Multiplo_de_3()
        {
            string resultadoEsperado = "Fizz";

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();

            string resultado = sut.Verificar(9);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Garantir_Buzz_Em_Apenas_Multiplo_de_5()
        {
            string resultadoEsperado = "Buzz";

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();

            string resultado = sut.Verificar(10);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Garantir_FizzBuzz_Em_15()
        {
            string resultadoEsperado = "FizzBuzz";

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();

            string resultado = sut.Verificar(15);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Garantir_Que_Primeiro_Numero_Da_Lista_Eh_1()
        {
            int resultadoEsperado = 1;

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();

            int resultado = Convert.ToInt32(sut.ListaDeNumeros[0]);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Garantir_Que_Ultimo_Numero_Da_Lista_Eh_100()
        {
            int resultadoEsperado = 100;

            //S.U.T. System Under Test
            FizzBuzz sut = new FizzBuzz();
                
            int resultado = Convert.ToInt32(sut.ListaDeNumeros[99]);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
