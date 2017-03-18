using static System.Console;
using ImplementIterator.Iterator;

namespace ImplementIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primes2To1000 = new Primes(2, 1000);
            foreach (long prime in primes2To1000)
            {
                Write($"{prime}, ");
            }

            ReadKey();
        }
    }
}
