using System;

namespace CSharpDataTypeChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nByte:");
            Console.WriteLine("Min={0} , Max={1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}", clsNumberToStringConverter.ConvertNumberToText(byte.MinValue), clsNumberToStringConverter.ConvertNumberToText(byte.MaxValue));

            Console.WriteLine("\nSByte:");
            Console.WriteLine("Min={0} , Max={1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}", clsNumberToStringConverter.ConvertNumberToText(sbyte.MinValue), clsNumberToStringConverter.ConvertNumberToText(sbyte.MaxValue));
            //  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine("\nShort:");
            Console.WriteLine("Min={0} , Max={1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}", clsNumberToStringConverter.ConvertNumberToText(short.MinValue), clsNumberToStringConverter.ConvertNumberToText(short.MaxValue));

            Console.WriteLine("\nUShort:");
            Console.WriteLine("Min={0} , Max={1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}", clsNumberToStringConverter.ConvertNumberToText(ushort.MinValue), clsNumberToStringConverter.ConvertNumberToText(ushort.MaxValue));
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("\nInt:");
            Console.WriteLine("Min={0} , Max={1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}", clsNumberToStringConverter.ConvertNumberToText(int.MinValue), clsNumberToStringConverter.ConvertNumberToText(int.MaxValue));

            Console.WriteLine("\nUInt:");
            Console.WriteLine("Min={0} , Max={1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}",
                clsNumberToStringConverter.ConvertNumberToText(uint.MinValue),
                clsNumberToStringConverter.ConvertNumberToText(uint.MaxValue));

            Console.WriteLine("\nLong:");
            Console.WriteLine("Min={0} , Max={1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}",
              clsNumberToStringConverter.ConvertNumberToText(long.MinValue),
              clsNumberToStringConverter.ConvertNumberToText(long.MaxValue));

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min={0} , Max={1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Min={0}\n Max={1}",
             clsNumberToStringConverter.ConvertNumberToText(ulong.MinValue),
             clsNumberToStringConverter.ConvertNumberToText(ulong.MaxValue));

            Console.WriteLine("\nFloat:");
            Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);

            Console.WriteLine("\nDouble:");
            Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);

            Console.WriteLine("\nDecimal:");
            Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);


            //Scientific Notation
            //Use e or E to indicate the power of 10 
            //as exponent part of scientific notation with float, double or decimal.

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000



            //hex & Binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            Console.ReadKey();

        }
    }
}
