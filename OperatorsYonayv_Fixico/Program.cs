using System;

namespace OperatorsYonayv_Fixico
{
    class Program
    {
        static void Main(string[] args)
        {
            int intMult = 6 * 45;
            int intAdd = 55 + 66;

            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}");
        }
    }
}
