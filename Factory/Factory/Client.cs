using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
   public class Client
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
}
