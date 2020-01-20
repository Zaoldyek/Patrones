using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactoryWindows());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactoryMac());
        }

        public void ClientMethod(GUIFactory factory)
        {
            var productA = factory.CreateButton();
            var productB = factory.CreateCheckBox();
            var productC = factory.CreateRadio();

            Console.WriteLine(productA.UsefulFunctionA());
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productC.UsefulFunctionC());
            Console.ReadLine();
        }
    }
}
