using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BotonHTML : Button
    {
        public string render()
        {
            return "Boton Renderizado HTML";
        }

        public string onClick()
        {
            return "onClick Asignado HTML";
        }
    }

}
