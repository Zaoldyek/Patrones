using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
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
}
