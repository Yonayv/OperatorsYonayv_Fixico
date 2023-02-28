using System;

namespace OperatorsYonayv_Fixico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");

            // Initializes an integer that multipies two integers
            int intMult = 6 * 45;
            // Initialized an integer that adds to integers
            int intAdd = 55 + 66;
            // Prints the maxium and minimum of the two integers variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isshortGreater}.");

            Console.WriteLine("SHORTS");
            // Initializes an integer that multipies two shorts
            short shortMult = 6 * 45;
            // Initialized an integer that adds to shorts
            short shortAdd = 55 + 66;
            // Prints the maxium and minimum of the two integers variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isShortGreater = shortMult > shortAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");

            Console.WriteLine("LONGS");
            // Initializes an long that multipies two longs
            long longMult = 6 * 45;
            // Initialized an long that adds to long
            long longAdd = 55 + 66;
            // Prints the maxium and minimum of the two longs variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
                $"The min of the two is {Math.Min(longMult, longAdd)}");

            // Initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");
            // Initializes an long that multipies two longs

            Console.WriteLine("FLOATS");
            float floatMult = 6.5f * 45.2f;
            // Initialized a float that adds to floats
            float floatAdd = 55.35f + 66.15f;
            // Prints the maxium and minimum of the two integers variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");

            Console.WriteLine("DOUBLES");
            double doubleMult = 6.5f * 45.2f;
            // Initialized an double that adds to doubles
            double doubleAdd = 55.35f + 66.15f;
            // Prints the maxium and minimum of the two doubles variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}");

            // Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");

            Console.WriteLine("DECIMALS");
            decimal decimalMult = (decimal)(6.25 * 45.25);
            // Initialized an decimal that adds to decimals
            decimal decimalAdd = (decimal)(55.45 + 66.65);
            // Prints the maxium and minimum of the two decimals variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}");

            // Initializes boolean to see if decimaltMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints if intMult is greater than decimal Add
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");
        }
    }
}
