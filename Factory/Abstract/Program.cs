using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{

    public interface GUIFactory
    {
        IAbstractButton CreateButton();

        IAbstractCheckBox CreateCheckBox();

        IAbstractRadio CreateRadio();
    }

    #region[Fabrica Windows]
    class ConcreteFactoryWindows : GUIFactory
    {
        public IAbstractButton CreateButton()
        {
            return new ConcreteProductButton1();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new ConcreteProductCheckBox1();
        }

        public IAbstractRadio CreateRadio()
        {
            return new ConcreteProductRadio1();
        }
    }
    #endregion

    #region[Fabrica Mac]
    class ConcreteFactoryMac : GUIFactory
    {
        public IAbstractButton CreateButton()
        {
            return new ConcreteProductButton2();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new ConcreteProductCheckBox2();
        }

        public IAbstractRadio CreateRadio()
        {
            return new ConcreteProductRadio2();
        }
    }
    #endregion

    #region[Radio]
    public interface IAbstractRadio
    {
        string UsefulFunctionC();
    }
    class ConcreteProductRadio1 : IAbstractRadio
    {
        public string UsefulFunctionC()
        {
            return "Radio Windows";
        }
    }

    class ConcreteProductRadio2 : IAbstractRadio
    {
        public string UsefulFunctionC()
        {
            return "Radio Mac";
        }
    }
    #endregion

    #region[button]
    public interface IAbstractButton
    {
        string UsefulFunctionA();
    }

    class ConcreteProductButton1 : IAbstractButton
    {
        public string UsefulFunctionA()
        {
            return "Boton Windows";
        }
    }

    class ConcreteProductButton2 : IAbstractButton
    {
        public string UsefulFunctionA()
        {
            return "Boton Mac";
        }
    }
    #endregion

    #region[CheckBox]
    public interface IAbstractCheckBox
    {
        string UsefulFunctionB();

    }

    class ConcreteProductCheckBox1 : IAbstractCheckBox
    {
        public string UsefulFunctionB()
        {
            return "CheckBox Windows";
        }

    }

    class ConcreteProductCheckBox2 : IAbstractCheckBox
    {
        public string UsefulFunctionB()
        {
            return "CheckBox Mac";
        }

    }
    #endregion

    class Client
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

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
