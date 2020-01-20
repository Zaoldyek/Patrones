using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BotonWindows : Button
    {
        public string render()
        {
            return "Boton Renderizado WINDOWS";
        }

        public string onClick()
        {
            return "onClick Asignado WINDOWS";
        }
    }
}
