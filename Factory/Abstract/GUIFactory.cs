using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface GUIFactory
    {
        IAbstractButton CreateButton();

        IAbstractCheckBox CreateCheckBox();

        IAbstractRadio CreateRadio();
    }
}
