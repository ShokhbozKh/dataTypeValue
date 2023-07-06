namespace dataTypeValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //byte
            byte byteMax = byte.MaxValue, byteMin=byte.MaxValue;
            Console.WriteLine($"Byte max={byteMax} min={byteMin}");
            
            //short
            short  shortMax=short.MaxValue, shortMin=short.MinValue;
            Console.WriteLine($"Short Max={shortMax} Mini={shortMin}");

            //int
            int intMax=int.MaxValue, intMin=int.MinValue;
            Console.WriteLine($"Int max={intMax} min={intMin}");

            //float
            float floatMax = float.MaxValue, floatMin = float.MinValue;
            Console.WriteLine($" Float max={floatMax} min={floatMin}");

            //double
            double doubleMax = double.MaxValue, doubleMin = double.MinValue;
            Console.WriteLine("Max double=" + doubleMax + "\n min=" +  doubleMin);

            //long
            long longMax = long.MaxValue, longMin = long.MinValue;
            Console.WriteLine($"Long max={longMax} min={longMin}");

            //decimal
            decimal decimalMax=decimal.MaxValue, decimalMin=decimal.MinValue;
            Console.WriteLine($"Decimal max={decimalMax} min={decimalMin}");

            //string
            string name = "Shohboz ";
            string lastName = "Xurramov";
            string stringAdd = string.Concat(name + lastName);
            Console.WriteLine("Assalomu alaykum " + stringAdd);

            //bool
            bool boolTrue = true;
            Console.WriteLine("natija= " + !boolTrue);

            //char
            char charMax=char.MaxValue, charMin=char.MinValue;
            Console.WriteLine("Char max=" + charMax + "min=" + charMin);
            //

        }
    }
}