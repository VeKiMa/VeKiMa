﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UčenjeCS.E18Ekstenzije
{
    internal class Grupa : Entitet, ISucelje
    {
        public void Posao() 
        {
            Console.WriteLine("Radim posao grupa");
        }
    }
}
