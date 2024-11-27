using System;

namespace Hausaufgaben
{
    class Program
    {
        private const int Multiplier = 10000;
        private const int TotalIterations = 10;

        private static int CheckIfPrime(int ValueToCheck)
        {
            if (ValueToCheck <= 1)
                return 0; // Numbers less than or equal to 1 are not prime

            if (ValueToCheck == 2)
                return 1; // 2 is prime

            if (ValueToCheck % 2 == 0)
                return 0; // Even numbers > 2 are not prime

            // any factors of the number greater than its square root
            // will already have a corresponding factor less than the square root  
            for (var i = 3; i * i <= ValueToCheck; i += 2)
            {
                if (ValueToCheck % i == 0)
                    return 0;
            }

            return 1;
        }

        private static int ProcessIteration(int CurrentIteration)
        {
            var Start = CurrentIteration * Multiplier;
            var Stop = Start + Multiplier;
            var PrimesInCurrentIteration = 0;

            Console.WriteLine($"Range\t\t: {Start} and {Stop}");

            for (var ValueToCheck = Start; ValueToCheck < Stop; ValueToCheck++)
            {
                PrimesInCurrentIteration += CheckIfPrime(ValueToCheck);
            }

            Console.WriteLine($"Prime Numbers\t: {PrimesInCurrentIteration}");
            return PrimesInCurrentIteration;
        }

        private static void Main(string[] args)
        {
            var CurrentIteration = 0;
            var TotalPrimes = 0;

            while (CurrentIteration < TotalIterations)
            {
                Console.WriteLine($"Iteration\t: {CurrentIteration + 1}");
                TotalPrimes += ProcessIteration(CurrentIteration);
                CurrentIteration++;
                Console.WriteLine("====================================");
            }

            Console.WriteLine($"Total Primes\t: {TotalPrimes}");
        }
    }
}
