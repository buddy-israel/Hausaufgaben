using System;

namespace Hausaufgaben
{
    class ConverterProgram
    {
        static string ToBinaryString(int value)
        {
            string AsBinary = "";

            while (value > 0)
            {
                int remainder = value % 2;
                AsBinary = remainder + AsBinary;
                value /= 2;
            }

            return AsBinary;
        }

        static string ToOctalString(int value)
        {
            string AsOctal = "";

            while (value > 0)
            {
                int remainder = value % 8;
                AsOctal = remainder + AsOctal;
                value /= 8;
            }

            return AsOctal;
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
            Console.WriteLine("Binär: " + ToBinaryString(input));
            Console.WriteLine("Octal: " + ToOctalString(input));
            Console.WriteLine("HexaDezimal: " + ToHexaDecimalString(input));
        }
    }
}
