﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance
{
    class Beo : Udara
    {
        String NamaHewan = "Beo";
        public void Terbang()
        {
            Console.WriteLine(NamaHewan + " Terbang di Udara");
        }
        public void Bernafas()
        {
            Console.WriteLine(NamaHewan + " Bernafas");
        }
    }
}