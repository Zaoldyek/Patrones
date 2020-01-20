﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class JAVACreator : Creator
    {
        public override Button FactoryMethod()
        {
            return new BotonJAVA();
        }
    }
}
