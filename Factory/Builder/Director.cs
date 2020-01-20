using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
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
}
