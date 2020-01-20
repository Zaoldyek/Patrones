using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class WindowsCreator : Creator
    {
        public override Button FactoryMethod()
        {
            return new BotonWindows();
        }
    }

}
