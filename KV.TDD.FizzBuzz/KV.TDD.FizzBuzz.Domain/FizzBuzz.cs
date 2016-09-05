namespace KV.TDD.FizzBuzz.Domain
{
    public class FizzBuzz
    {
        public string ObterNumeroFizzBuzz(int numero)
        {
            if (numero == 3)
                return "Fizz";
            else
                return numero.ToString();
        }
    }
}