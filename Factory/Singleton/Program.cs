using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Conexion
    {

        private Conexion() { }

        private static Conexion _instance;

        public static Conexion GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Conexion();
            }
            return _instance;
        }

        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public static void someBusinessLogic()
        {
            // ...
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conexion s1 = Conexion.GetInstance();
            Conexion s2 = Conexion.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
            Console.ReadLine();
        }
        
    }
}
