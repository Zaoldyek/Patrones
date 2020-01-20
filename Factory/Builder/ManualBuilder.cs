using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
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
}
