using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    #region[Fabrica Mac]
    public class ConcreteFactoryMac : GUIFactory
    {
        public IAbstractButton CreateButton()
        {
            return new ConcreteProductButton2();
        }

        public IAbstractCheckBox CreateCheckBox()
        {
            return new ConcreteProductCheckBox2();
        }

        public IAbstractRadio CreateRadio()
        {
            return new ConcreteProductRadio2();
        }
    }
    #endregion
}
