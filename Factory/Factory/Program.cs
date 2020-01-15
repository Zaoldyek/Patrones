using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Creator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract Button FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "onClick: "+ product.onClick()+", Render: "+product.render();

            return result;
        }
    }

    public interface Button
    {
        string render();
        string onClick();
    }

    // Concrete Products provide various implementations of the Product
    // interface.
    class BotonWindows : Button
    {
        public string render()
        {
            return "Boton Renderizado WINDOWS";
        }

        public string onClick()
        {
            return "onClick Asignado WINDOWS";
        }
    }

    class BotonHTML : Button
    {
        public string render()
        {
            return "Boton Renderizado HTML";
        }

        public string onClick()
        {
            return "onClick Asignado HTML";
        }
    }

    class BotonJAVA : Button
    {
        public string render()
        {
            return "Boton Renderizado JAVA";
        }

        public string onClick()
        {
            return "onClick Asignado JAVA";
        }
    }

    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    class WindowsCreator : Creator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Button FactoryMethod()
        {
            return new BotonWindows();
        }
    }

    class HTMLCreator : Creator
    {
        public override Button FactoryMethod()
        {
            return new BotonHTML();
        }
    }

    class JAVACreator : Creator
    {
        public override Button FactoryMethod()
        {
            return new BotonJAVA();
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched Windows Create.");
            ClientCode(new WindowsCreator());

            Console.WriteLine("");

            Console.WriteLine("App: Launched HTML Create.");
            ClientCode(new HTMLCreator());

            Console.WriteLine("");

            Console.WriteLine("App: Launched JAVA Create.");
            ClientCode(new JAVACreator());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
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
