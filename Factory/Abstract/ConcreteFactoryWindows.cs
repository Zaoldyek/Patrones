using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{

    #region[Fabrica Windows]
    public class ConcreteFactoryWindows : GUIFactory
    {
        public IAbstractButton CreateButton()
        {
            return new ConcreteProductButton1();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new ConcreteProductCheckBox1();
        }

        public IAbstractRadio CreateRadio()
        {
            return new ConcreteProductRadio1();
        }
    }
    #endregion
}
