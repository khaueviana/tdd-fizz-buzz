using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace KV.TDD.FizzBuzz.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RetornarSequenciaFizzBuzzParaNumero1()
        {
            // Arrange
            var fizzBuzz = new Domain.FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(1);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "1" }, resultado);
        }

        [TestMethod]
        public void RetornarSequenciaFizzBuzzParaNumero2()
        {
            // Arrange
            var fizzBuzz = new Domain.FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(2);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "1", "2" }, resultado);
        }

        [TestMethod]
        public void RetornarSequenciaFizzBuzzParaNumero3()
        {
            // Arrange
            var fizzBuzz = new Domain.FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(3);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "1", "2", "Fizz" }, resultado);
        }

        [TestMethod]
        public void RetornarSequenciaFizzBuzzParaNumero17()
        {
            // Arrange
            var fizzBuzz = new Domain.FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(17);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17" }, resultado);
        }
    }
}