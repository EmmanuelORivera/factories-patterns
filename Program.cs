using System;

namespace FactoriesPatterns // Note: actual namespace depends on the project name.
{
    internal class FactoriesPatterns
    {
        static void Main(string[] args)
        {
            // Factory method example
            Creator creator1 = new ConcreteCreator1();
            Creator creator2 = new ConcreteCreator2();

            System.Console.WriteLine(creator1.SomeOperation());
            System.Console.WriteLine(creator2.SomeOperation());

            // Abstract factory method
            string platform = args.Length > 0 ? args[0] : "Windows";

            // create the appropiate factory
            IUIFactory factory;
            if (platform == "Windows")
            {
                factory = new WindowsUIFactory();
            }
            else if (platform == "Linux")
            {
                factory = new LinuxUIFactory();
            }
            else
            {
                throw new ArgumentException("Invalid platform");
            }

            // Use the factory to create a button
            IButton button = factory.CreateButton();
            button.Render();

        }
    }
}