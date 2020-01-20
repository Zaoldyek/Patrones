using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new CarBuilder();
            var ManualBuilder = new ManualBuilder();
            director.Builder = builder;

            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            director.Builder = ManualBuilder;
            director.buildFullFeaturedProduct();
            Console.WriteLine(ManualBuilder.GetManual().ListManual());

            Console.ReadLine();
        }
    }
}
