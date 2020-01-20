using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BotonJAVA : Button
    {
        public string render()
        {
            return "Boton Renderizado JAVA";
        }

        public string onClick()
        {
            return "onClick Asignado JAVA";
        }
    }
}
