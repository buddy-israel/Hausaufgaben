using System;

namespace Hausaufgaben1
{
    class ConverterProgram
    {
        static string SimpleConverter(int input, int multiplier)
        {
            var output = "";

            while (input > 0)
            {
                int remainder = input % multiplier;
                output = remainder + output;
                input /= multiplier;
            }

            return output;
        }

        static string ToHexaDecimalString(int value)
        {
            string AsHexaDecimal = "";
            string[] LookUp = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            while (value > 0)
            {
                int remainder = value % 16;
                AsHexaDecimal = LookUp[remainder] + AsHexaDecimal;
                value /= 16;
            }

            return AsHexaDecimal;
        }


        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number {input} in");
            Console.WriteLine("=============================");
            Console.WriteLine($"Binary\t\t: {SimpleConverter(input, 2)}");
            Console.WriteLine($"Octal\t\t: {SimpleConverter(input, 8)}");
            Console.WriteLine($"HexaDecimal\t: {ToHexaDecimalString(input)}");
        }
        
    }
}
