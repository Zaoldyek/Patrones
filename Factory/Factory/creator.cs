using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Creator
    {
        public abstract Button FactoryMethod();


        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "onClick: " + product.onClick() + ", Render: " + product.render();

            return result;
        }
    }
}
