/* 
namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
*/

namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj górny zakres liczb:");
            int gornyLimit = int.Parse(Console.ReadLine());
            FizzBuzz fizzBuzz = new FizzBuzz(gornyLimit);
            fizzBuzz.Run();
        }
    }

    public class FizzBuzz
    {
        private int _gornyLimit;

        public FizzBuzz(int gornyLimit)
        {
            _gornyLimit = gornyLimit;
        }

        public void Run()
        {
            for (int i = 1; i <= _gornyLimit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
