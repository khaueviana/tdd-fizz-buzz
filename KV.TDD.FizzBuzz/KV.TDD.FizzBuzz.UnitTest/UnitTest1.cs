using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KV.TDD.FizzBuzz.UnitTest
{
    [TestClass]
    public class UnitTest1
    {   
        [TestMethod]
        public void RetornarNumeroUmParaNumeroUm()
        {
            // Arrange
            var fizzBuzz = new Domain.FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(1);

            // Assert
            Assert.AreEqual("1", resultado);
        }

        [TestMethod]
        public void RetornarNumeroDoisParaNumeroDois()
        {
            // Arrange
            var fizzBuzz = new Domain.FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(2);

            // Assert
            Assert.AreEqual("2", resultado);
        }

        [TestMethod]
        public void RetornarFizzParaNumeroTres()
        {
            // Arrange
            var fizzBuzz = new Domain.FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(3);

            // Assert
            Assert.AreEqual("Fizz", resultado);
        }
    }
}