using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class ConcreteProductButton1 : IAbstractButton
    {
        public string UsefulFunctionA()
        {
            return "Boton Windows";
        }
    }
}
