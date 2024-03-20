using System;

namespace FactoriesPatterns // Note: actual namespace depends on the project name.
{
    internal class FactoriesPatterns
    {
        static void Main(string[] args)
        {
            Creator creator1 = new ConcreteCreator1();
            Creator creator2 = new ConcreteCreator2();

            System.Console.WriteLine(creator1.SomeOperation());
            System.Console.WriteLine(creator2.SomeOperation());

        }
    }
}