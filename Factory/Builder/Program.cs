using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        public interface IBuilder
        {
            void reset();

            void setSeats();

            void setEngine();

            void setTripComputer();

            void setGPS();
        }

        public class ManualBuilder : IBuilder
        {
            private Manual manual = new Manual();

            public ManualBuilder()
            {
                reset();
            }

            public void reset()
            {
                this.manual = new Manual();
            }

            public void setEngine()
            {
                manual.Add("Se Agrego Manual Engine");
            }

            public void setGPS()
            {
                manual.Add("Se Agrego Manual GPS");
            }

            public void setSeats()
            {
                manual.Add("Se Agrego Manual Seats");
            }

            public void setTripComputer()
            {
                manual.Add("Se Agrego Manual Trip Computer");
            }

            public Manual GetManual()
            {
                Manual result = this.manual;

                reset();

                return result;
            }
        }

        public class CarBuilder : IBuilder
        {
            private Car car = new Car();

            public CarBuilder()
            {
                reset();
            }

            public void reset()
            {
                this.car = new Car();
            }

            public void setEngine()
            {
                car.Add("Se Agrego Engine");
            }

            public void setGPS()
            {
                car.Add("Se Agrego GPS");
            }

            public void setSeats()
            {
                car.Add("Se Agrego Seats");
            }

            public void setTripComputer()
            {
                car.Add("Se Agrego Trip Computer");
            }

            public Car GetProduct()
            {
                Car result = this.car;

                reset();

                return result;
            }
        }

        public class Car
        {
            private List<object> _parts = new List<object>();

            public void Add(string part)
            {
                this._parts.Add(part);
            }

            public string ListParts()
            {
                string str = string.Empty;

                for (int i = 0; i < this._parts.Count; i++)
                {
                    str += this._parts[i] + ", ";
                }

                str = str.Remove(str.Length - 2); // removing last ",c"

                return "Car parts: " + str + "\n";
            }

        }
        public class Manual
        {
            private List<object> _parts = new List<object>();

            public void Add(string part)
            {
                this._parts.Add(part);
            }

            public string ListManual()
            {
                string str = string.Empty;

                for (int i = 0; i < this._parts.Count; i++)
                {
                    str += this._parts[i] + ", ";
                }

                str = str.Remove(str.Length - 2); // removing last ",c"

                return "Manuales : " + str + "\n";
            }

        }

        public class Director
        {
            private IBuilder _builder;

            public IBuilder Builder
            {
                set { _builder = value; }
            }

            // The Director can construct several product variations using the same
            // building steps.
            public void buildMinimalViableProduct()
            {
                this._builder.setEngine();
            }

            public void buildFullFeaturedProduct()
            {
                this._builder.setEngine();
                this._builder.setGPS();
                this._builder.setTripComputer();
                this._builder.setSeats();
            }
           
        }

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
