using System;
using System.Collections.Generic;

namespace KV.TDD.FizzBuzz.Domain
{
    /* FizzBuzz
    *
    * Dado um número de 1 a N, o programa deve retornar uma lista FizzBuzz que vai até o número digitado. Exemplo:
    *
    * Número: 17
    * Lista: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17
    *
    * Regras:
    *
    * 1. Números divisíveis por 3 devem aparecer como 'Fizz' ao invés do número;
    * 2. Números divisíveis por 5 devem aparecer como 'Buzz' ao invés do número;
    * 3. Números divisíveis por 3 e 5 devem aparecer como 'FizzBuzz' ao invés do número.
    * 
    */
    public class FizzBuzz
    {
        public List<string> ObterNumeroFizzBuzz(int numero)
        {
            var listaFizzBuzz = new List<string>();

            if (numero < 1)
                throw new Exception("Número deve ser maior ou igual a 1");

            for (int i = 1; i <= numero; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    listaFizzBuzz.Add("FizzBuzz");
                else if (i % 3 == 0)
                    listaFizzBuzz.Add("Fizz");
                else if (i % 5 == 0)
                    listaFizzBuzz.Add("Buzz");
                else
                    listaFizzBuzz.Add(i.ToString());                
            }

            return listaFizzBuzz;
        }
    }
}