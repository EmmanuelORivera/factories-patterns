
namespace FactoriesPatterns
{
    // Abstract product interface
    interface IButton
    {
        void Render();
    }

    // Concrete products
    class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Rendering a Windows-style button");
        }
    }

    class LinuxButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Rendering a Linux style button");
        }
    }

    // abstract factory interface
    interface IUIFactory
    {
        IButton CreateButton();
    }

    // Concrete factories
    class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
    }

    class LinuxUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }
    }
}